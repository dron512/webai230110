#include <stdio.h>

int doAdd(int a,int b)
{
    return a+b;
}
int main(){
    // printf("a = %d",a);
    int result;

    result = doAdd(3,4);
    printf("result = %d\n",result);

    result = doAdd(5,8);
    printf("result = %d",result);
}