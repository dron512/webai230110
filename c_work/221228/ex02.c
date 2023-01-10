#include <stdio.h>

int main(){
    int ch1;
    while(1){
        ch1 = getchar();
        if(ch1 ==EOF){
            printf("EOF 입력하여 종료됩니다.\n");
            break;
        }
        putchar(ch1);
    }
    return 0;
}