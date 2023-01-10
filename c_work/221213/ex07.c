#include <stdio.h>

void doB(){
    printf("doB함수 호출\n");
}

int doA(){
    printf("doA함수 호출\n");
    doB();
    return 0;
}

int main(){
    printf("======main 시작=======\n");
    doA();
    printf("======main 끝========\n");
}
