/*
    page 157
    while 문 중첩
    문제1
    프로그램 사용자로부터 총 5개의 정수를 입력받아 그 수의 합을
    출력하는 프로그램작성해보자.
    단 한가지 조건이 있다 정수는 반드시 1이상이어야 한다. 만약에 1미만의수가
    입력되는 경우에는 이를 입력하지 않고 재 요구해야 한다.
    그래서 결국 1이상의 정수 5개를 모두 입력받을수있도록 완성

    문제2
    *
    O *
    O O *
    O O O *
    O O O O *
    참고로 총 5행에 걸쳐서 출력이 이루어 지고 행이 더해질때 마다 O가 추가됨
*/
#include <stdio.h>

int main(){
    int input = 0, total = 0;
    int num = 0;
    while(num<5){
        printf("정수입력\n");
        scanf("%d",&input);
        while(input < 0){
            printf("정수가 0 보다 작습니다 재입력 하세요..\n");
            scanf("%d",&input);
        }
        total = total + input;
        num = num + 1;
        printf("total = %d\n",total);
        printf("num = %d\n",num);
    }

    
}