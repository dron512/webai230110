#include <stdio.h>

int main(int ac,char *arg[]){
     printf("전달된 문자열의 수 %d\n",ac);

     for (int i =0; i<ac;i++){
        printf("%d문자열 %s\n",i,arg[i]);
     }
}