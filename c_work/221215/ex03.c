#include <stdio.h>

int main(){
    int arr[] = {1,2,3,4,5,6,1,2,3,1,2,3,1,2,3,1,2,3};

    printf("sizeof = %d\n",sizeof(arr));
    int len = sizeof(arr)/sizeof(int);
    printf("len = %d\n",len);

    for ( int i =0; i<len;i++)
        printf("arr[%d] = %d\n",i,arr[i]);
}