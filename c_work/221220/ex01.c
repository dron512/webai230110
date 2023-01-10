/*
    page260
    1. 길이가 5인 int형 배열을 선언해서 프로그램
    사용자로부터 총 5개의정수를 입력받자
    그리고 입력이 끝나면
       입력된 수중에서 최댓값
       입력된 수중에서 최솟값
       입력된 정수의 총합
    2.
    char 1차원배열을 선언과 동시에 
    "Good Time"
    저장하고 출력하자

    page 268
    1. Array라는 단어가 입력되면 길이를 계산해서 출력
    2. char형 배열에 저장한뒤 문자열을 역순으로
    3. LOVE라는 단어를 입력받아 아스키 보드값중 가장 큰 값인
    V를 출력하자
*/

#include <stdio.h>

void main(){
    int max = 0;
    int min = 0;
    int total = 0;

    int arr[5];
    for(int i =0; i<5; i++){
        printf("정수 입력 ");
        scanf("%d",&arr[i]);
        total += arr[i];
    }
    max = arr[0];
    // max 구하는 비교시작
    for ( int i =0; i<5; i++){
        if ( max < arr[i])
            max = arr[i];
    }

    min = arr[0];
    for ( int i =0; i<5; i++){
        if ( min > arr[i])
            min = arr[i];
    }

    printf("\n");
    for(int i =0; i<5 ; i++){
        printf("arr[%d] = %d\n",i,arr[i]);
    }
    printf("\n");
    printf("total = %d\n",total);
    printf("max = %d\n",max);
    printf("min = %d\n",min);
    
    char str[] = "Good Time";
    printf("str = %s",str);
}