/*
  문제 5 프로그램사용자로부터 정수의 평균을 출력하되
    먼저 몇개의 정수를 입력할 것인지 사용자에게
    묻는다 그리고 그 수만큼 정수를 입력
    평균값은 소수점 이하까지 출력
*/
#include <stdio.h>

int main(){
    printf("몇개의 정수를 입력할래 ?");
    int num;
    scanf("%d",&num);
    int cnt = num;
    int total = 0;
    int input = 0;
    while( num>0 ){
        printf("점수 입력 : ");
        scanf("%d",&input);
        total = total + input;
        num = num - 1;
    }
    printf("총 합 %d \n",total);
    printf("총 합 %.2f \n",total/(double)cnt);
}