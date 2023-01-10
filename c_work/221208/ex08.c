#include <stdio.h>

int main(){
    int num1 = 3,num2 = 2;

    printf("%d / %d = %d\n",num1,num2,num1/num2);
    printf("(double)%d / %d = %d\n",num1,num2,(double)num1/num2);
    printf("(double)%d / %d = %f",num1,num2,(double)num1/num2);

    return 0;
}