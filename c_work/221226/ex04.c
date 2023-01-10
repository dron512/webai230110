#include <stdio.h>

int main(){

    int arr1[3][2]={0,1,2,3,4,5};
    int arr2[2][3]={0,1,2,3,4,5};

    printf(" ======arr1에 대한주소값======\n");
    printf(" arr1 = %d\n",arr1);
    printf(" arr1+1 = %d\n",arr1+1);
    printf(" arr1+2 = %d\n\n",arr1+2);

    printf(" ======arr2에 대한주소값======\n");
    printf(" arr2 = %d\n",arr2);
    printf(" arr2+1 = %d\n\n",arr2+1);

    printf(" ======arr1에 대한 값======\n");
    printf(" **arr1 = %d\n",arr1[0][0]);
    printf(" arr1[1][1] = %d\n",arr1[1][1]);
    printf(" **(arr1+2) = %d\n\n",*(*(arr1+2)));

    printf(" ======arr2에 대한 값======\n");
    printf(" **arr2 = %d\n",**arr2);
    printf(" **(arr2+1) = %d\n",**(arr2+1));

}