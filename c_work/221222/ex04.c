#include <stdio.h>

void SwapIntPtr(int **dp1,int **dp2){
    int *temp = *dp1;
    *dp1 = *dp2;
    *dp2 = temp;
}

int main(){
    int num1 = 10, num2 = 20;
    int *ptr1, *ptr2;
    ptr1 = &num1, ptr2 = &num2;

    printf("*ptr1, *ptr2 : %d %d\n",*ptr1,*ptr2);
    printf("num1, num2 : %d %d\n",num1,num2);

    printf("\n");
    SwapIntPtr(&ptr1,&ptr2);
    printf("*ptr1, *ptr2 : %d %d\n",*ptr1,*ptr2);
    printf("num1, num2 : %d %d\n",num1,num2);
}