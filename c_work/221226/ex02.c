#include <stdio.h>
/*
page 320
문제 2
세변수에 저장된 값을 서로 뒤바꾸는 함수를 정의하자
*/

void swap3(int *ptr1,int *ptr2,int *ptr3);

int main(){
    int num1 = 10,num2 = 20, num3= 30;
    swap3(&num1,&num2,&num3);

    printf("num1 = %d\n",num1);
    printf("num2 = %d\n",num2);
    printf("num3 = %d\n",num3);
}

void swap3(int *ptr1,int *ptr2,int *ptr3){
    int temp1 = *ptr1;
    *ptr1 = *ptr3;
    int temp2 = *ptr2;
    *ptr2 = temp1;
    *ptr3 = temp2;
}