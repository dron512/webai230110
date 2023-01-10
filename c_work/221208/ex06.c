#include <stdio.h>

int main(){
    int a = 10;
    const int b = 20;

    a = 20;
    // b = 30;
    printf("a = %d\n",a);
    printf("b = %d",b);
}