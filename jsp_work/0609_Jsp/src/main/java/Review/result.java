package Review;

import Review.user;
import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class result
 */

@WebServlet("/result")
public class result extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public result() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		response.getWriter().append("Served at: ").append(request.getContextPath());
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		request.setCharacterEncoding("UTF-8");
		
		String name=request.getParameter("name");
		int age=Integer.parseInt(request.getParameter("age"));
		String gender=request.getParameter("gender");
		String tel=request.getParameter("tel");
		String email=request.getParameter("email");
		
		user u=new user(name, age, gender, tel, email);
		
		response.setContentType("text/html; charset=utf-8");
		PrintWriter pw=response.getWriter();
		pw.println("<!doctype html><html><head></head><body>");
		pw.println("<p>이름: "+u.getName()+"<br>나이: "+u.getAge()+"<br>성별: "+u.getGender());
		pw.println("<br>전화번호: "+u.getTel()+"<br>이메일: "+u.getEmail());
		pw.println("</p></body></html>");
	}

}





