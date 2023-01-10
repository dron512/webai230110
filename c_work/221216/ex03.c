#include <stdio.h>

int main(){


    int arr[3];
    printf("arr = %d\n",arr);
    printf("&arr[0] = %d\n",&arr[0]);
    printf("&arr[1] = %d\n",&arr[1]);
    printf("&arr[2] = %d\n\n",&arr[2]);

    int *p = arr;
    printf("p = %d\n",p);
    printf("*p = %d =\n",*p);

    *p = 10;
    printf("arr[0] = %d\n",arr[0]);
    printf("*p = %d \n",*p);
}