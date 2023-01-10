#include <stdio.h>

/*
    문제1 
    int arr []=1,2,3,4,5
    ptr 2씩증가 
*/
void main(){

    int arr[] = {1,2,3,4,5};
    int *ptr=NULL;
    ptr = arr;
    // *ptr = 10;
    // 출력하는 for구문
    for(int i =0; i< sizeof(arr)/sizeof(int); i++){
        printf("arr[%d] = %d\n",i,arr[i]);
    }

    // 증가 시키는 for구문
    for(int i =0; i< sizeof(arr)/sizeof(int); i++){
        ptr[i] = ptr[i] +2;
    }
    printf("\n");
    // 출력하는 for구문
    for(int i =0; i< sizeof(arr)/sizeof(int); i++){
        printf("arr[%d] = %d\n",i,arr[i]);
    }

    // 증가 시키는 for구문
    for(int i =0; i< sizeof(arr)/sizeof(int); i++){
        *(ptr+i) = *(ptr+i) +2;
    }

    printf("\n");
    // 출력하는 for구문
    for(int i =0; i< sizeof(arr)/sizeof(int); i++){
        printf("arr[%d] = %d\n",i,arr[i]);
    }

    // 감소하는 for구문
    for(int i =4; i>-1; i--){
        *(ptr+i) = *(ptr+i) -1;
    }

    printf("\n");
    printf("ptr =%d\n",ptr);
    printf("ptr+4 =%d\n",ptr+4);

    printf("*(ptr+4) =%d\n",*(ptr+4));

    printf("sizeof(ptr) =%d\n",sizeof(ptr));

    printf("\n");
    // 출력하는 for구문
    for(int i =0; i< sizeof(arr)/sizeof(int); i++){
        printf("arr[%d] = %d\n",i,arr[i]);
    }
}