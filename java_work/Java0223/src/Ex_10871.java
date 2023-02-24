import java.util.Scanner;

public class Ex_10871 {
	public static void main(String[] args) {
		// 입력:: 배열의 크기, 임의의 숫자(v), 배열값들
		// 출력:: 배열값들 중 v보다 작은 숫자들 순차적으로 출력
		
		// 1. 입력
		Scanner sc=new Scanner(System.in);
		int n=sc.nextInt();		// n: 배열의 크기
		int v=sc.nextInt();		// v: 임의의 숫자
		int arr[]=new int [n];	// arr: 배열값들
		for(int i=0;i<n;i++) {
			arr[i]=sc.nextInt(); // arr의 i번째 배열값 순차적으로 입력
		}
		
		// 2. 바로 비교하고, 바로 출력
		for(int i=0;i<n;i++) {
			if(arr[i]<v) {	// "현재 위치의 배열값이 v보다 작다면"
				System.out.print(arr[i]+" ");
			}
		}
		System.out.println();
	}
}
