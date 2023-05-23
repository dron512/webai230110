select stu.std_num, stu.std_name,tut.tut_num,tut_name,tut_teacher
from kb_student stu
full outer join kb_tutorial tut on stu.tut_num = tut.tut_num
 order by stu.std_num asc


