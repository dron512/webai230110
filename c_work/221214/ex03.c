/*
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

void ex01(){
    int a = 1;
    while( a<100 )
    {
        // 7로 나누었을때 0으로 떨어지면.
        if( a % 7 ==0 ){
            printf("%d\t",a);
            a++;
            continue;
        }
        if (a % 9 ==0){
            printf("%d\t",a);
        }
        a++;
    }
}

void ex02(){
    int num1,num2;

    printf("\n\n첫번째 수 입력");
    scanf("%d",&num1);
    printf("두번째 수 입력");
    scanf("%d",&num2);

    int result = num1>num2? num1-num2:num2-num1;
    printf("result = %d",result);
}

void main(){
    ex01();
    ex02();
}