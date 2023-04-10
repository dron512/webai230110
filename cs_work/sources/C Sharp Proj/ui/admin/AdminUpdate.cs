using KBbooks.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBbooks.ui.admin
{
    partial class AdminUpdate : UserControl
    {
        DaoOra ora;
        MainForm mf;
        string originCode;
        string imagename; //이미지 이름
        string imagepath;     //이미지 파일 경로
        int ordered = 0;
        int clickedcolumn = 0;
        int searched = 0;
        string searchedcolumn = "";
        string find = "";
        string searchquery = "";
        public AdminUpdate(DaoOra ora, MainForm mf)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
            for (int i = 2023; i >= 1940; i--)
            {
                year.Items.Add($"{i}");
            }
            for (int i = 1; i <= 31; i++)
            {
                day.Items.Add($"{i}");
            }
            initListView();
            
        }
        private void initListView()
        {
            bookView.Items.Clear();
            List<Book> list = ora.dataShow(); // 오라클 데이터를 list에 담는다.
            for (int i = 0; i < list.Count; i++)
            {
                bookView.Items.Add(new ListViewItem(new string[] { list[i].Code, list[i].Title, list[i].Author,
                    list[i].Pub, list[i].Price, list[i].Date, list[i].Genre}));
            }
        }
        private void initListView(string column, string order)
        {
            bookView.Items.Clear();
            List<Book> list = ora.dataShow(column, order); // 오라클 데이터를 list에 담는다.
            for (int i = 0; i < list.Count; i++)
            {
                bookView.Items.Add(new ListViewItem(new string[] { list[i].Code, list[i].Title, list[i].Author,
                    list[i].Pub, list[i].Price, list[i].Date, list[i].Genre}));
            }
        }
        private void searchResult(string query)
        {
            bookView.Items.Clear();
            List<Book> list = ora.dataShow(query); // 오라클 데이터를 list에 담는다.
            for (int i = 0; i < list.Count; i++)
            {
                bookView.Items.Add(new ListViewItem(new string[] { list[i].Code, list[i].Title, list[i].Author,
                    list[i].Pub, list[i].Price, list[i].Date, list[i].Genre}));
            }
        }
        private void saleslabel_MouseEnter(object sender, EventArgs e)
        {
            saleslabel.Font = new Font(saleslabel.Font.Name, saleslabel.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void saleslabel_MouseLeave(object sender, EventArgs e)
        {
            saleslabel.Font = new Font(saleslabel.Font.Name, saleslabel.Font.SizeInPoints, FontStyle.Bold);
        }
        private void saleslabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminSales(ora, mf), "AdminSales");
        }
        private void bookadd_MouseEnter(object sender, EventArgs e)
        {
            bookadd.Font = new Font(bookadd.Font.Name, bookadd.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void bookadd_MouseLeave(object sender, EventArgs e)
        {
            bookadd.Font = new Font(bookadd.Font.Name, bookadd.Font.SizeInPoints, FontStyle.Bold);
        }
        private void salesmanagelabel_MouseEnter(object sender, EventArgs e)
        {
            salesmanagelabel.Font = new Font(salesmanagelabel.Font.Name, salesmanagelabel.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void salesmanagelabel_MouseLeave(object sender, EventArgs e)
        {
            salesmanagelabel.Font = new Font(salesmanagelabel.Font.Name, salesmanagelabel.Font.SizeInPoints, FontStyle.Bold);
        }
        private void salesmanagelabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminSalesManage(ora, mf), "AdminSalesManage");
        }
        private void booklabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminAdd(ora, mf), "AdminAdd");
        }
        private void noticelabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminNoticeManage(ora, mf), "AdminNoticeManage");
        }

        private void bookadd_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminAdd(ora, mf), "AdminAdd");
        }

        private void bookupdate_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminUpdate(ora, mf), "AdminUpdate");
        }

        private void deleteImage_Click(object sender, EventArgs e)
        {
            pic.Image = null;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            pic.Image = null;
        }

        private void bookView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookView.SelectedItems.Count != 0)
            {
                int n = bookView.SelectedItems[0].Index;
                string code = bookView.Items[n].SubItems[0].Text;
                string title = bookView.Items[n].SubItems[1].Text;
                string author = bookView.Items[n].SubItems[2].Text;
                string pub = bookView.Items[n].SubItems[3].Text;
                string price = bookView.Items[n].SubItems[4].Text;
                string date = bookView.Items[n].SubItems[5].Text;
                string genre = bookView.Items[n].SubItems[6].Text;

                viewCode.Text = code;
                viewTitle.Text = title;
                viewPrice.Text = price;
                viewAuthor.Text = author;
                viewPub.Text = pub;
                month.Text = int.Parse(date.Substring(5, 2)).ToString();
                year.Text = date.Substring(0, 4);
                day.Text = int.Parse(date.Substring(8, 2)).ToString();
                viewGenre.Text = genre;
                originCode = code;
                ora.getImg(pic, code);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e) // 수정 버튼
        {
            int err = 0;
            label1.Focus();
            if(viewTitle.Text == "" || viewTitle.Text == "제목을 입력하세요.")
            {
                viewTitle.Text = "제목을 입력하세요.";
                err++;
            }
            if(viewAuthor.Text == "" || viewAuthor.Text == "저자를 입력하세요.")
            {
                viewAuthor.Text = "저자를 입력하세요.";
                err++;
            }
            if(viewPub.Text == "" || viewPub.Text == "출판사를 입력하세요.")
            {
                viewPub.Text = "출판사를 입력하세요.";
                err++;
            }
            Regex reg = new Regex(@"[0-9]");
            if (!reg.IsMatch(viewPrice.Text))
            {
                viewPrice.Text = "가격을 올바르게 입력하세요.";
                err++;
            }
            if (viewPrice.Text == "" || viewPrice.Text == "가격을 올바르게 입력하세요." || viewPrice.Text == "가격을 입력하세요.")
            {
                viewPrice.Text = "가격을 입력하세요.";
                err++;
            }
            if(err == 0)
            {
                string date = year.Text + "/" + month.Text.PadLeft(2, '0') + "/" + day.Text.PadLeft(2, '0');
                List<Book> list = ora.updateData(originCode, new Book(viewCode.Text, viewTitle.Text, viewAuthor.Text, viewPub.Text, viewPrice.Text, date, viewGenre.Text));
                ora.commit();
                imagename = Path.GetFileNameWithoutExtension(imagepath);
                if (imagename != null)
                {
                    ora.upImge(new Book(imagename), imagepath, viewCode.Text);
                    imagepath = null;
                    imagename = null;
                    pic.Image = null;
                }
                ora.commit();
                updateListView(list);
                MessageBox.Show("도서 정보가 수정되었습니다.");
                pic.Image = null;
                viewCode.Text = "";
                viewTitle.Text = "";
                viewAuthor.Text = "";
                viewPub.Text = "";
                viewPrice.Text = "";
                year.SelectedIndex = -1;
                month.SelectedIndex = -1;
                day.SelectedIndex = -1;
                viewGenre.SelectedIndex = -1;
            }
        }

        private void updateListView(List<Book> list)
        {
            bookView.BeginUpdate();
            bookView.Items.Clear();
#if true
            for (int i = 0; i < list.Count; i++)
            {
                bookView.Items.Add(new ListViewItem(
                    new string[]
                    {

                        list[i].Code,
                        list[i].Title,
                        list[i].Author,
                        list[i].Pub,
                        list[i].Price,
                        list[i].Date,
                        list[i].Genre
                    }));
            }
#else
            int num = 1;
            foreach(var n in list)
            {
                memLView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (num++).ToString(),
                        n.Code,
                        n.Title,
                        n.Author,
                        n.Pub,
                        n.Price,
                        n.Date,
                        n.Genre
                    }));
            }
#endif
            bookView.EndUpdate();
        }
        private void selectImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = @"C:\";
                ofd.Filter = "jpeg 파일(*.jpg)|*.jpg|" +
                    "png 파일(*.png)|*.png|" +
                    "gif 파일(*.gif)|*.gif|" +
                    "모든 파일(*.*)|*.*";
                ofd.FilterIndex = 0;
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagepath = ofd.FileName;
                    Image img = Image.FromFile(imagepath);
                    pic.Image = img;
                }
                
            }
            catch (FileNotFoundException)
            {
            }
        }

        private void viewCode_Enter(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (month.Text == "1" || month.Text == "3" || month.Text == "5" || month.Text == "7" || month.Text == "8" || month.Text == "10" || month.Text == "12")
            {
                day.Items.Clear();
                for (int i = 1; i <= 31; i++)
                {
                    day.Items.Add($"{i}");
                }
                day.Text = "";
            }
            else if (month.Text == "4" || month.Text == "6" || month.Text == "9" || month.Text == "11")
            {
                day.Items.Clear();
                for (int i = 1; i <= 30; i++)
                {
                    day.Items.Add($"{i}");
                }
                day.Text = "";
            }
            else if (month.Text == "2")
            {
                day.Items.Clear();
                for (int i = 1; i <= 28; i++)
                {
                    day.Items.Add($"{i}");
                }
                day.Text = "";
            }
        }

        private void bookView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if(searched == 0)
            {
                if (e.Column == 0)
                {
                    if (clickedcolumn != 0)
                    {
                        clickedcolumn = 0;
                        ordered = 0;
                        initListView("book_code", "asc");
                    }
                    else
                    {
                        if (ordered == 0)
                        {
                            ordered = 1;
                            initListView("book_code", "asc");
                        }
                        else if (ordered == 1)
                        {
                            ordered = 2;
                            initListView("book_code", "desc");
                        }
                        else if (ordered == 2)
                        {
                            ordered = 0;
                            initListView();
                        }
                    }
                }
                else if (e.Column == 1)
                {
                    if (clickedcolumn != 1)
                    {
                        clickedcolumn = 1;
                        ordered = 1;
                        initListView("book_title", "asc");
                    }
                    else
                    {
                        if (ordered == 0)
                        {
                            ordered = 1;
                            initListView("book_title", "asc");
                        }
                        else if (ordered == 1)
                        {
                            ordered = 2;
                            initListView("book_title", "desc");
                        }
                        else if (ordered == 2)
                        {
                            ordered = 0;
                            initListView();
                        }
                    }
                }
                else if (e.Column == 2)
                {
                    if (clickedcolumn != 2)
                    {
                        clickedcolumn = 2;
                        ordered = 1;
                        initListView("book_author", "asc");
                    }
                    else
                    {
                        if (ordered == 0)
                        {
                            ordered = 1;
                            initListView("book_author", "asc");
                        }
                        else if (ordered == 1)
                        {
                            ordered = 2;
                            initListView("book_author", "desc");
                        }
                        else if (ordered == 2)
                        {
                            ordered = 0;
                            initListView();
                        }
                    }
                }
                else if (e.Column == 3)
                {
                    if (clickedcolumn != 3)
                    {
                        clickedcolumn = 3;
                        ordered = 1;
                        initListView("book_pub", "asc");
                    }
                    else
                    {
                        if (ordered == 0)
                        {
                            ordered = 1;
                            initListView("book_pub", "asc");
                        }
                        else if (ordered == 1)
                        {
                            ordered = 2;
                            initListView("book_pub", "desc");
                        }
                        else if (ordered == 2)
                        {
                            ordered = 0;
                            initListView();
                        }
                    }
                }
                else if (e.Column == 4)
                {
                    if (clickedcolumn != 4)
                    {
                        clickedcolumn = 4;
                        ordered = 1;
                        initListView("book_price", "asc");
                    }
                    else
                    {
                        if (ordered == 0)
                        {
                            ordered = 1;
                            initListView("book_price", "asc");
                        }
                        else if (ordered == 1)
                        {
                            ordered = 2;
                            initListView("book_price", "desc");
                        }
                        else if (ordered == 2)
                        {
                            ordered = 0;
                            initListView();
                        }
                    }
                }
                else if (e.Column == 5)
                {
                    if (clickedcolumn != 5)
                    {
                        clickedcolumn = 5;
                        ordered = 1;
                        initListView("book_date", "asc");
                    }
                    else
                    {
                        if (ordered == 0)
                        {
                            ordered = 1;
                            initListView("book_date", "asc");
                        }
                        else if (ordered == 1)
                        {
                            ordered = 2;
                            initListView("book_date", "desc");
                        }
                        else if (ordered == 2)
                        {
                            ordered = 0;
                            initListView();
                        }
                    }
                }
                else if (e.Column == 6)
                {
                    if (clickedcolumn != 6)
                    {
                        clickedcolumn = 6;
                        ordered = 1;
                        initListView("book_genre", "asc");
                    }
                    else
                    {
                        if (ordered == 0)
                        {
                            ordered = 1;
                            initListView("book_genre", "asc");
                        }
                        else if (ordered == 1)
                        {
                            ordered = 2;
                            initListView("book_genre", "desc");
                        }
                        else if (ordered == 2)
                        {
                            ordered = 0;
                            initListView();
                        }
                    }
                }
            }
            else if(searched == 1)
            {
                if (e.Column == 0)
                {
                    if (clickedcolumn != 0)
                    {
                        clickedcolumn = 0;
                        ordered = 0;
                        searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                  $"ORDER BY book_code asc";
                        searchResult(searchquery);
                    }
                    else
                    {
                        if (ordered == 0)
                        {
                            ordered = 1;
                            searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                      $"ORDER BY book_code asc";
                            searchResult(searchquery);
                        }
                        else if (ordered == 1)
                        {
                            ordered = 2;
                            searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                      $"ORDER BY book_code desc";
                            searchResult(searchquery);
                        }
                        else if (ordered == 2)
                        {
                            ordered = 0;
                            searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                      $"ORDER BY UTL_MATCH.EDIT_DISTANCE_SIMILARITY ({searchedcolumn}, '{find}') desc";
                            searchResult(searchquery);
                        }
                    }
                }
                else if (e.Column == 1)
                {
                    if (clickedcolumn != 1)
                    {
                        clickedcolumn = 1;
                        ordered = 1;
                        searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 or {searchedcolumn} like '%{find.Replace(' ', '%')}%' " +
                                  $"ORDER BY book_title asc";
                        searchResult(searchquery);
                    }
                    else
                    {
                        if (ordered == 0)
                        {
                            ordered = 1;
                            searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 or {searchedcolumn} like '%{find.Replace(' ', '%')}%' " +
                                      $"ORDER BY book_title asc";
                            searchResult(searchquery);
                        }
                        else if (ordered == 1)
                        {
                            ordered = 2;
                            searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 or {searchedcolumn} like '%{find.Replace(' ', '%')}%' " +
                                      $"ORDER BY book_title desc";
                            searchResult(searchquery);
                        }
                        else if (ordered == 2)
                        {
                            ordered = 0;
                            searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 or {searchedcolumn} like '%{find.Replace(' ', '%')}%' " +
                                      $"ORDER BY UTL_MATCH.EDIT_DISTANCE_SIMILARITY ({searchedcolumn}, '{find}') desc";
                            searchResult(searchquery);
                        }
                    }
                }
                else if (e.Column == 2)
                {
                    if (clickedcolumn != 2)
                    {
                        clickedcolumn = 2;
                        ordered = 1;
                        searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                  $"ORDER BY book_author asc";
                        searchResult(searchquery);
                    }
                    else
                    {
                        if (ordered == 0)
                        {
                            ordered = 1;
                            searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                      $"ORDER BY book_author asc";
                            searchResult(searchquery);
                        }
                        else if (ordered == 1)
                        {
                            ordered = 2;
                            searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                      $"ORDER BY book_author desc";
                            searchResult(searchquery);
                        }
                        else if (ordered == 2)
                        {
                            ordered = 0;
                            searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                      $"ORDER BY UTL_MATCH.EDIT_DISTANCE_SIMILARITY ({searchedcolumn}, '{find}') desc";
                            searchResult(searchquery);
                        }
                    }
                }
                else if (e.Column == 3)
                {
                    if (clickedcolumn != 3)
                    {
                        clickedcolumn = 3;
                        ordered = 1;
                        searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                  $"ORDER BY book_pub asc";
                        searchResult(searchquery);
                    }
                    else
                    {
                        if (ordered == 0)
                        {
                            ordered = 1;
                            searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                      $"ORDER BY book_pub asc";
                            searchResult(searchquery);
                        }
                        else if (ordered == 1)
                        {
                            ordered = 2;
                            searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                      $"ORDER BY book_pub desc";
                            searchResult(searchquery);
                        }
                        else if (ordered == 2)
                        {
                            ordered = 0;
                            searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                      $"ORDER BY UTL_MATCH.EDIT_DISTANCE_SIMILARITY ({searchedcolumn}, '{find}') desc";
                            searchResult(searchquery);
                        }
                    }
                }
                else if (e.Column == 4)
                {
                    if (clickedcolumn != 4)
                    {
                        clickedcolumn = 4;
                        ordered = 1;
                        searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                  $"ORDER BY book_price asc";
                        searchResult(searchquery);
                    }
                    else
                    {
                        if (ordered == 0)
                        {
                            ordered = 1;
                            searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                      $"ORDER BY book_price asc";
                            searchResult(searchquery);
                        }
                        else if (ordered == 1)
                        {
                            ordered = 2;
                            searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                      $"ORDER BY book_price desc";
                            searchResult(searchquery);
                        }
                        else if (ordered == 2)
                        {
                            ordered = 0;
                            searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                      $"ORDER BY UTL_MATCH.EDIT_DISTANCE_SIMILARITY ({searchedcolumn}, '{find}') desc";
                            searchResult(searchquery);
                        }
                    }
                }
                else if (e.Column == 5)
                {
                    if (clickedcolumn != 5)
                    {
                        clickedcolumn = 5;
                        ordered = 1;
                        searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                  $"ORDER BY book_date asc";
                        searchResult(searchquery);
                    }
                    else
                    {
                        if (ordered == 0)
                        {
                            ordered = 1;
                            searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                      $"ORDER BY book_date asc";
                            searchResult(searchquery);
                        }
                        else if (ordered == 1)
                        {
                            ordered = 2;
                            searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                      $"ORDER BY book_date desc";
                            searchResult(searchquery);
                        }
                        else if (ordered == 2)
                        {
                            ordered = 0;
                            searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 " +
                                      $"ORDER BY UTL_MATCH.EDIT_DISTANCE_SIMILARITY ({searchedcolumn}, '{find}') desc";
                            searchResult(searchquery);
                        }
                    }
                }
                else if (e.Column == 6)
                {
                    if (clickedcolumn != 6)
                    {
                        clickedcolumn = 6;
                        ordered = 1;
                        searchquery = $"select * from proj_books where {searchedcolumn} = '{find}'";
                        searchResult(searchquery);
                    }
                    else
                    {
                        if (ordered == 0)
                        {
                            ordered = 1;
                            searchquery = $"select * from proj_books where {searchedcolumn}  = '{find}' " +
                                      $"ORDER BY book_code asc";
                            searchResult(searchquery);
                        }
                        else if (ordered == 1)
                        {
                            ordered = 2;
                            searchquery = $"select * from proj_books where {searchedcolumn}  = '{find}' " +
                                      $"ORDER BY book_code desc";
                            searchResult(searchquery);
                        }
                        else if (ordered == 2)
                        {
                            ordered = 0;
                            searchquery = $"select * from proj_books where {searchedcolumn} = '{find}'";
                            searchResult(searchquery);
                        }
                    }
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            viewTitle.Focus();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            viewAuthor.Focus();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            viewPub.Focus();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            viewPrice.Focus();
        }

        private void viewTitle_Enter(object sender, EventArgs e)
        {
            if(viewTitle.Text == "제목을 입력하세요.")
            {
                viewTitle.Text = "";
            }
        }

        private void viewAuthor_Enter(object sender, EventArgs e)
        {
            if(viewAuthor.Text == "저자를 입력하세요.")
            {
                viewAuthor.Text = "";
            }
        }

        private void viewPub_Enter(object sender, EventArgs e)
        {
            if(viewPub.Text == "출판사를 입력하세요.")
            {
                viewPub.Text = "";
            }
        }

        private void viewPrice_Enter(object sender, EventArgs e)
        {
            if(viewPrice.Text == "가격을 입력하세요." || viewPrice.Text == "가격을 올바르게 입력하세요.")
            {
                viewPrice.Text = "";
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(searchColumn.Text != "")
            {
                if(searchColumn.Text == "도서 제목")
                {
                    searchedcolumn = "book_title";
                }
                else if(searchColumn.Text == "저자")
                {
                    searchedcolumn = "book_author";
                }
                else if(searchColumn.Text == "출판사")
                {
                    searchedcolumn = "book_pub";
                }
                else if(searchColumn.Text == "장르")
                {
                    searchedcolumn = "book_genre";
                }
                if (searchText.Text != "" && searchColumn.Text != "장르")
                {
                    searched = 1;
                    find = searchText.Text;
                    searchquery = $"select * from proj_books where UTL_MATCH.jaro_winkler_similarity({searchedcolumn}, '{find}') > 80 or {searchedcolumn} like '%{find.Replace(' ', '%')}%' " +
                                  $"ORDER BY UTL_MATCH.EDIT_DISTANCE_SIMILARITY ({searchedcolumn}, '{find}') desc";
                    searchResult(searchquery);
                }
                else if(searchColumn.Text == "장르")
                {
                    searched = 1;
                    find = searchGenre.Text;
                    searchquery = $"select * from proj_books where {searchedcolumn} = '{find}'";
                    searchResult(searchquery);
                }
                else if (searchColumn.Text != "장르" && (searchText.Text == "" || searchText.Text == "검색어를 입력하세요."))
                {
                    searchText.Text = "검색어를 입력하세요.";
                    label1.Focus();
                }
            }
        }

        private void searchColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(searchColumn.Text != "장르")
            {
                searchText.Visible = true;
                searchGenre.Visible = false;
            }
            else
            {
                searchText.Visible = false;
                searchGenre.Visible = true;
            }
        }

        private void searchText_Enter(object sender, EventArgs e)
        {
            if(searchText.Text == "검색어를 입력하세요.")
            {
                searchText.Text = "";
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            searched = 0;
            initListView();
            searchText.Text = "";
            searchGenre.Text = "";
            searchColumn.Text = "";
            searchedcolumn = "";
            ordered = 0;
            clickedcolumn = 0;
            find = "";
        }

        private void noticelabel_MouseEnter(object sender, EventArgs e)
        {
            noticelabel.Font = new Font(noticelabel.Font.Name, noticelabel.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }

        private void noticelabel_MouseLeave(object sender, EventArgs e)
        {
            noticelabel.Font = new Font(noticelabel.Font.Name, noticelabel.Font.SizeInPoints, FontStyle.Bold);
        }
        private void bookreview_MouseEnter(object sender, EventArgs e)
        {
            bookreview.Font = new Font(bookreview.Font.Name, bookreview.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }

        private void bookreview_MouseLeave(object sender, EventArgs e)
        {
            bookreview.Font = new Font(bookreview.Font.Name, bookreview.Font.SizeInPoints, FontStyle.Bold);
        }

        private void bookreview_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminReview(ora, mf), "AdminReview");
        }
        private void memberlabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminMember(ora, mf), "AdminMember");
        }
        private void memberlabel_MouseEnter(object sender, EventArgs e)
        {
            memberlabel.Font = new Font(memberlabel.Font.Name, memberlabel.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void memberlabel_MouseLeave(object sender, EventArgs e)
        {
            memberlabel.Font = new Font(memberlabel.Font.Name, memberlabel.Font.SizeInPoints, FontStyle.Bold);
        }

        private void bookdelete_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(MessageBox.Show("선택하신 도서를 삭제합니다.\n(해당 도서의 판매 내역이 있으면 삭제할 수 없습니다.)\n정말 삭제하시겠습니까?", "도서 삭제", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                i = ora.deleteBook(viewCode.Text);
                if (i == 1)
                {
                    MessageBox.Show("도서 삭제가 완료되었습니다.");
                    initListView();
                    pic.Image = null;
                    viewCode.Text = "";
                    viewTitle.Text = "";
                    viewAuthor.Text = "";
                    viewPub.Text = "";
                    viewPrice.Text = "";
                    year.SelectedIndex = -1;
                    month.SelectedIndex = -1;
                    day.SelectedIndex = -1;
                    viewGenre.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("도서를 삭제하지 못했습니다.\n(판매 내역이 존재합니다.)");
                }
            }
        }
    }
}
