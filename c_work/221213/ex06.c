#include <stdio.h>

void doA(int num){
    if (num ==0)
        return;
    printf("aaa\n");
    num = 30;
    printf("\ndoA num = %d\n",num);
}

int main(){
    int num = 20;
    printf("num = %d\n",num);
    doA(0);
    printf("num = %d\n",num);
    doA(10);
    printf("num = %d\n",num);
}

