#include <stdio.h>

int main(){

    int arr1[2][2] = {1,2,3,4};
    int arr2[3][2] = {5,6,7,8,9,10};
    int arr3[1][2] = {11,22};

    int (*ptr)[2] = arr1;
    printf("*(ptr[0]) %d ",*(ptr[0]));
    printf("ptr[0][1] %d\n",ptr[0][1]);
    printf("ptr[1][0] %d ",ptr[1][0]);
    printf("ptr[1][1] %d\n\n",ptr[1][1]);

    ptr = arr2;
    printf("ptr[0][0] %d ",ptr[0][0]);
    printf("ptr[0][1] %d\n",ptr[0][1]);
    printf("ptr[1][0] %d ",ptr[1][0]);
    printf("ptr[1][1] %d\n",ptr[1][1]);
    printf("ptr[2][0] %d ",ptr[2][0]);
    printf("ptr[2][1] %d\n\n",ptr[2][1]);

    ptr = arr3;
    printf("ptr[0][0] %d ",ptr[0][0]);
    printf("ptr[0][1] %d\n",ptr[0][1]);


    return 0;
}