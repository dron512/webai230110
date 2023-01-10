#include <stdio.h>

int sfnc(int *param,int len){
    for (int i =0; i<len; i++)
        printf("param[%d] %d\n",i,param[i]);
}
int addary(int *param,int len,int add){
    for (int i =0; i<len; i++)
        param[i] = param[i] + add;
}

int main(){
    int arr1[3] = {11,22,33};
    sfnc(arr1,sizeof(arr1)/sizeof(int));
    addary(arr1,sizeof(arr1)/sizeof(int),5);
    printf("\n");
    sfnc(arr1,sizeof(arr1)/sizeof(int));
    addary(arr1,sizeof(arr1)/sizeof(int),10);
    sfnc(arr1,sizeof(arr1)/sizeof(int));


    addary(arr1,sizeof(arr1)/sizeof(int),20);
    sfnc(arr1,sizeof(arr1)/sizeof(int));
    return 0;
}