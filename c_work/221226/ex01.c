#include<stdio.h>

int main(){

    int num = 10;
    // int *ptr = &num;
    // int **dptr = &ptr;

    int *ptr = NULL;
    ptr = &num;
    int **dptr = NULL;
    dptr = &ptr;

    printf("======num 값 =======\n");
    printf("num = %d\n",num);

    printf("======num 주소값 =======\n");
    printf("&num = %d\n",&num);
    printf("ptr = %d\n",ptr);

    printf("======ptr 주소값 =======\n");
    printf("&ptr = %d\n",&ptr);
    printf("dptr = %d\n",dptr);

    num = 20;
    printf("======num 값 =======\n");
    printf("num = %d\n",num);
    printf("*ptr = %d\n",*ptr);
    printf("**dptr = %d\n",**dptr);

    *ptr = 30;
    printf("======num 값 =======\n");
    printf("num = %d\n",num);
    printf("*ptr = %d\n",*ptr);
    printf("**dptr = %d\n",**dptr);

    **dptr = 40;
    printf("======num 값 =======\n");
    printf("num = %d\n",num);
    printf("*ptr = %d\n",*ptr);
    printf("**dptr = %d\n",**dptr);
    return 0;
}

