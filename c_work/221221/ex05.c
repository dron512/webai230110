#include<stdio.h>

int main(){
    int arr[][2] = {1,2,3,4,5,6,7};

    printf("&arr[%d][%d] =%d %d\n",0,0,&arr[0][0],arr[0][0]);
    printf("&arr[%d][%d] =%d %d\n",0,1,&arr[0][1],arr[0][1]);

    printf("&arr[%d][%d] =%d %d\n",1,0,&arr[1][0],arr[1][0]);
    printf("&arr[%d][%d] =%d %d\n",1,1,&arr[1][1],arr[1][1]);

    printf("&arr[%d][%d] =%d %d\n",2,0,&arr[2][0],arr[2][0]);
    printf("&arr[%d][%d] =%d %d\n",2,1,&arr[2][1],arr[2][1]);
    
    printf("&arr[%d][%d] =%d %d\n",3,0,&arr[3][0],arr[3][0]);
    printf("&arr[%d][%d] =%d %d\n",3,1,&arr[3][1],arr[3][1]);

    printf("&arr[%d] = %d\n",0,&arr[0]);
    printf("&arr[%d] = %d\n",1,&arr[1]);
    printf("&arr[%d] = %d\n",2,&arr[2]);
    printf("&arr[%d] = %d\n",3,&arr[3]);

}