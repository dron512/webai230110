#include <stdio.h>

int main(){

    int total=0,num=0;

    printf("몇까지 더하고 싶나요?");
    scanf("%d",&num);

    for(int i=0; i< num+1;i=i+1){
        total= total+i;
    }

    printf("total = %d",total);
    
}