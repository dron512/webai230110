#include <stdio.h>

int main(){

    printf("숫자 입력: \n");
    int num;
    scanf("%d",&num);

    if( num > 30){
        printf("%d는 30보다 크다\n",num);
    }
    else if(num > 20){
        printf("%d는 20보다 크다\n",num);
    }
    else if(num > 10){
        printf("%d는 10보다 크다\n",num);
    }
    else{
        printf("%d는 0보다 크다\n",num);
    }

}