#include <stdio.h>

int doA(){
    printf("doA함수\n");
    return 1;
}
void doB(){
    printf("doB함수\n");
}
int doC(int a,int b){
    printf("doC함수\n");
    return a+b;
}

int main(){
    int ma = doA();
    doB();
    int mb = doC(10,20);

    printf("ma = %d\n",ma);
    printf("mb = %d\n",mb);

    // doA();
    // doA();
    // doA();
    return 0;
}