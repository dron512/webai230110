#include<stdio.h>

int main(){

    int arr2d[3][3] ={0};

    printf("arr2d[0][0] =%d\n\n",arr2d[0][0]);

    printf("arr2d =%d\n",arr2d);
    printf("&arr2d[0] =%d\n",&arr2d[0]);
    printf("&arr2d[0][0] =%d\n\n",&arr2d[0][0]);

    printf("&arr2d[1] =%d\n",&arr2d[1]);
    printf("&arr2d[1][0] =%d\n\n",&arr2d[1][0]);

    printf("&arr2d[2] =%d\n",&arr2d[2]);
    printf("&arr2d[2][0] =%d\n\n",&arr2d[2][0]);

    printf("sizeof(arr2d) =%d\n",sizeof(arr2d));
    printf("sizeof(arr2d[0]) =%d\n",sizeof(arr2d[0]));
    printf("sizeof(arr2d[1]) =%d\n",sizeof(arr2d[1]));
    printf("sizeof(arr2d[2][0]) =%d\n\n",sizeof(arr2d[2][0]));



    return 0;
}
