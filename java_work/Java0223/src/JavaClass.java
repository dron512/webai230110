
// 클래스 선언
class Person{	// 사람 클래스
	// 접근제어자 :: private(공개X), public(공개O)
	
	// 속성 (필드)
	// 속성 선언 :: [접근제어자] [자료형] [속성이름];
	// (속성 선언 시, 보통 접근제어자는 private으로 설정한다.)
	private String name;
	private int age;
	private double height;
	
	// 메소드 (함수)
	// [접근제어자] [반환형(뱉어낼 자료형)] [메소드이름] { 명령문; }
	// -> get 함수 :: 특정 속성의 값을 뱉어내는 함수
	public String getName() {	
		return name;
	}
	// -> set 함수 :: 특정 속성의 값을 수정하는 함수
	public void setName(String n) {
		name=n;
	}
	
}

public class JavaClass {
	public static void main(String[] args) {
		// 객체 :: 실생활에서 우리가 볼 수 있는 실체 (클래스로 인해 만들어진 것)
		// 클래스 :: 객체를 만들어내는 틀
		
		// 객체 생성 및 멤버 호출
		Person lee=new Person();	// 객체 "lee" 생성
		lee.setName("lee");
		Person park=new Person();	// 객체 "park" 생성
	}
}
