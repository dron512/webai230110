import java.util.Random;
import java.util.Scanner;

public class Ex_10807 {
	public static void main(String[] args) {
		// 입력: 배열의 크기, 배열값들, 임의의 숫자(v)
		// 출력: 배열값들 중 v와 같은 숫자인 개수
		
		// 1. 3가지 순차적으로 입력
		// *번외: Random 함수
		Scanner sc=new Scanner(System.in);	// Scanner 클래스에 대한 객체 생성
		Random rd=new Random();	// Random 클래스에 대한 객체 생성
		int	n=sc.nextInt();		// n: 배열의 크기
		int arr[]=new int [n];	// arr: 배열값
		for(int i=0;i<n;i++) {
			arr[i]=rd.nextInt(10);	// i번째 배열의 값 입력 (랜덤)
		}
		int v=sc.nextInt();		// v: 임의의 숫자
		
		// 2. 연산 :: arr의 값들 중에서 v와 같은 숫자인 값의 개수
		int cnt=0;		// 같은 숫자의 개수 
		for(int i=0;i<n;i++){	// 배열값들 탐색
			if(arr[i]==v){
				cnt++;		//발견하면 1 더하기
			}		
		}
		
		for(int i=0;i<n;i++) {
			System.out.print(arr[i]+" ");
		}
		System.out.println();
		System.out.println(cnt);
	}
}
