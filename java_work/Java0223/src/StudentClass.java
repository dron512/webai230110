
class student{	// 학생 클래스
	// - 속성: 이름, 학번, 나이, 전화번호
	private String name;
	private String num;
	private int age;
	private String tel;
	
	// - 메소드: 각 속성에 대한 get/set 메소드
	public String getName() {
		return name;
	}
	public void setName(String n) {
		this.name = n;	// "이 객체"의 name 속성값을 n으로 설정한다.
	}
	public String getNum() {
		return num;
	}
	public void setNum(String num) {
		this.num = num;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
	}
	public String getTel() {
		return tel;
	}
	public void setTel(String tel) {
		this.tel = tel;
	}
	
	// 생성자 :: 메소드 중 하나 (특별한 메소드)
	// 다음 시간에 계속...
}

public class StudentClass {d
	public static void main(String[] args) {
		// 객체 생성
		student s1=new student();	// s1 객체 생성
		s1.setName("lee");	// s1을 가리키며, 이 객체의 이름을 변경하였음
		student s2=new student();	// s2 객체 생성
		s2.setName("kim");	// s2를 가리키며, 이 객체의 이름을 변경하였음
		
		System.out.println("s1의 이름: "+s1.getName());
		System.out.println("s2의 이름: "+s2.getName());
	}
}
