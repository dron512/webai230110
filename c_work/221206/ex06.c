#include <stdio.h>

int main(){

    int a = 3;
    int b = 2;
    printf("%d += %d\n",a,b);
    a+=b; // a = a+b;
    printf("a = %d\n",a);

    printf("%d *= %d\n",a,b);
    a*=b;
    printf("a = %d\n",a);


}