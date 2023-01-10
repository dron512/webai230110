#include <stdio.h>
#include <stdlib.h>

int main(){

    int *ptr1 = (int*) malloc(sizeof(int));
    int *ptr2 = (int*) malloc(sizeof(int)*7);

    printf("ptr1 = %d\n",ptr1);
    printf("ptr1+1 = %d\n\n",ptr1+1);

    *ptr1 = 10;
    printf("*ptr1 = %d\n",*ptr1);

    printf("ptr2 = %d\n",ptr2);
    printf("ptr2+1 = %d\n",ptr2+1);
    printf("ptr2+2 = %d\n",ptr2+2);
    printf("ptr2+3 = %d\n",ptr2+3);

    *ptr2= 20;
    ptr2[1] = 30;
    *(ptr2+2) =40;
    *(ptr2+3) = 50;
    ptr2[4] = 60;
    printf("*ptr2 = %d\n",*ptr2);
    printf("ptr2[1] = %d\n",ptr2[1]);
    printf("*(ptr2+2) = %d\n",*(ptr2+2));
    printf("*(ptr2+3) = %d\n",*(ptr2+3));
    printf("ptr2[4] = %d\n",ptr2[4]);

    free(ptr1);
    free(ptr2);
}