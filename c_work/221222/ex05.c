#include <stdio.h>

int main(){

    int num = 100;
    // int *ptr = &num;
    int *ptr = NULL;
    ptr = &num;

    printf("num =%d\n",num);
    printf("&num =%d\n",&num);
    printf("&ptr =%d\n",&ptr);
    printf("ptr =%d\n",ptr);
    printf("*ptr =%d\n",*ptr);
    printf("\n");

    *ptr = 200;
    printf("num =%d\n",num);
    printf("&num =%d\n",&num);
    printf("&ptr =%d\n",&ptr);
    printf("ptr =%d\n",ptr);
    printf("*ptr =%d\n",*ptr);
}