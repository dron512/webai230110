#include <stdio.h>

int main(){
    int a = 10;
    a++;// a = a+1;
    printf("a = %d\n",a);
    a--;// a = a-1;
    printf("a = %d\n\n",a);
    printf("a = %d\n",a++);
    printf("a = %d\n",a--);
    printf("a = %d\n\n",a);
    printf("a = %d\n",--a);
    printf("a = %d\n",++a);
    printf("a = %d\n",a);

}