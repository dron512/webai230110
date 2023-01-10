#include <stdio.h>

int main(){

    printf("숫자 입력: \n");
    int num;
    scanf("%d",&num);

    switch (num)
    {
        case 10:
            printf("num 은 10입니다");
        case 20:
            printf("num 은 20입니다");
        case 30:
            printf("num 은 30입니다");
            break;
        default:
            printf("default...");
            break;
    }

}