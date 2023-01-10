#include <stdio.h>
/*
    arr1[0] = *arr1
    &arr1[0] = arr1
*/
int main(){
    int arr1[3] = {10,20,30};
    double arr2[3] = {1.1,2.2,3.3};

    printf("arr1[0] = %d \t arr2[0] = %g\n",arr1[0],arr2[0]);
    printf("*arr1 = %d \t *arr2 = %g\n",*arr1,*arr2);

    arr1[0] += 100;
    *arr2 +=100;

    printf("arr1[0] = %d \t arr2[0] = %g\n",arr1[0],arr2[0]);
    printf("*arr1 = %d \t *arr2 = %g\n",*arr1,*arr2);
}
