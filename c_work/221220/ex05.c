#include <stdio.h>

void swap(int n1,int n2){
    int temp = n1;
    n1 = n2;
    n2 = temp;
    printf("n1   = %d n2   = %d\n",n1,n2);
}

void main(){
    int num1 = 10,num2 = 20;
    printf("num1 = %d num2 = %d\n",num1,num2);

    swap(num1,num2);
    
    printf("num1 = %d num2 = %d\n",num1,num2);
}