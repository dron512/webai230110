#include <stdio.h>

int main(){
    double arr[3] = {11,22,33};
    double brr[3] = {44,55,66};

    // int *ptr;
    // ptr =&arr[0];
    double *ptr=&arr[0];
    *ptr = 44;

    ptr = brr;
    // arr = brr;

    printf("주소값 arr %d\n",arr);
    printf("주소값 arr+1 %d\n",arr+1);
    printf("주소값 arr+2 %d\n\n",arr+2);

    printf("값 *arr %f\n",*arr);
    printf("값 *(arr+1) %f\n",*(arr+1));
    printf("값 *(arr+2) %f\n\n",*(arr+2));

    printf("값 arr %f\n",arr[0]);
    printf("값 arr[1] %f\n",arr[1]);
    printf("값 arr[2] %f\n",arr[2]);
}