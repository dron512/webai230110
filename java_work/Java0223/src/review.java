import java.util.Scanner;	// Scanner를 쓸 예정이라 명시

public class review {
	public static void main(String[] args) {
		// 저장 및 실행 :: ctrl + F11
		// 출력 :: println(표준), print, printf
		System.out.print("hello Java");
		System.out.println("hello Java");
		
		// 입력 :: Scanner 선언 필요 (new 키워드 - 클래스에서 설명하는 것과는 다름)
		Scanner sc=new Scanner(System.in);	// Scanner 사용
		int i=sc.nextInt();
		double d=sc.nextDouble();
		char c=sc.next().charAt(0);
		String s=sc.next();
		
		// 조건문(if-else if-else, switch), 반복문(for, while, do-while)
		// 배열 (new 키워드)
		// 자료형 배열이름[] = new 자료형 [배열크기];
		int a[]=new int [4];
		
		// int arr[]=new int [4];
		// arr[]={500,100,10,5};
		int arr[]= {500,100,10,5};
	}
}
