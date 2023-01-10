#include <stdio.h>

void showArr21d(int (*arr)[3],int *ptr,int **dptr){
    printf("ptr = %d ",ptr);
    printf("*ptr = %d\n",*ptr);

    printf("**dptr = %d\n",**dptr);

    **dptr = 30;

    for (int i =0; i<3 ; i++){
        for (int j=0 ;j< 3; j++){
            printf("arr[%d][%d] = %d ",i,j,arr[i][j]);
        }
        printf("\n");
    }
}

int main(){
    int num = 10;
    int *pnum = &num;

    int arr[][3] = {1,2,3,4,5,6,7,8};
    showArr21d(arr,&num,&pnum);

    printf("num = %d",num);
    return 0;
}