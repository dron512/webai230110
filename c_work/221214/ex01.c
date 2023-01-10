/*
    page 161
    문제 2
    0 ~ 100
    0이상 100이하의 정수중에서 짝수의 합을 출력하는 프로그램을 구현하되,
    do ~ while 문 기반으로 구현해보자
    참고로 덧셈의 결과는 2550이 되어야 한다

    page 167
    for문 활용
    문제1
    프로그램사용자로부터 두 개의 정수를 입력 받아서
    두 정수를 포함하여 그 사이에 존재하는 정수들의 합을 계산해서 출력하는
    프로그램을 작성해보자 예를 들어서 3,5과 입력되면 3+4+5의
    출력되어야 한다

    문제2
    5 = 5*4*3*2*1 
    3 = 3*2*1
    다음 수식인 계승을 계산하는 프로그램을 작성하자
    n! = 1*2*3* ... *n
    프로그램사용자로부터 n에 해당하는 정수를 입력받는다
    n!계산해서 출력하자

    page 189 [if~else문 활용]
    문제1
    1이상 100미만의 정수 중에서 7의 배수와 9의 배수를 출력하는 
    프로그램을 작성하자 단 ! 7의 배수이면서 동시에 9의 배수인 정수는
    한번만 출력되어야 한다.

    문제2
    두개의 정수를 입력받아서 두 수의 차를 출력하는 프로그램을 구현해보자.
    단, 무조건 큰수에서 작은수를 뺸 결과를 출력 해야 한다.
    예를 들어서 입력된 두 수가 순서에 상관없이 12와 5라면 7이 출력되어야하고,
    입력된 두수가 순서에 상관없이 4와 16이라면 12가 출력되어야 한다.
    즉, 출력결과는 무조건 0이상이 되어야 한다.
*/

#include <stdio.h>

// 0~100사이의 짝수의합 구하는 함수
void ex01(){
    int start = 0;
    int total = 0;

    do{
        start = start+2;
        total = total + start;
    }while( start != 100);

    printf("total = %d\n\n",total);
}

// 입력받은 두수의 사이의 합
void ex02(){
    int start = 0, end = 0;
    int total = 0;
    printf("시작 정수 입력:\n");
    scanf("%d",&start);
    printf("끝 정수 입력:\n");
    scanf("%d",&end);

    printf("end = %d start = %d\n ",end,start);
    for (int i = start ; i<end+1; i++){
        total = total + i;
    }
    printf("total = %d\n\n",total);
}

void ex03(){
    int input;
    int total = 1;
    printf("구하고 싶은 팩토리얼 정수 입력 : ");
    scanf("%d",&input);

    for( ; input >0 ; input= input-1 ){
        total = total *input;
    }

    printf("total = %d ",total);
}
int main(){
    ex01();
    ex02();
    ex03();
}
