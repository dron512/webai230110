#include <stdio.h>

int main(){

    double arr1[] = {10,20,30};

    printf("arr1 = %d\n",arr1);
    printf("arr1+1 = %d\n",&arr1[1]);
    printf("arr1+1 = %d\n",arr1+1);
    printf("arr1+2 = %d\n",&arr1[2]);

    printf("\n");

    double *p = &arr1[0];
    printf("p = %d\n",p);
    printf("p+1 = %d\n",p+1);
    printf("p+2 = %d\n",p+2);
}