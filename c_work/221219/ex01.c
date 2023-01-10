/*
    page 249
    5 10개의 소수 
    2 3 5 7 11 13 17 19 23 29

    6 초입력 시 분 초 
*/
#include <stdio.h>

void main(){
    int i = 0;
    int cnt = 0; 
    printf("2 3 ");
    int sosu = 5;
    while (i < 13){
        int divsu = 0;
        while( cnt < 3)
        {
            divsu++;
            if( sosu % divsu ==0){
                cnt++;
            }
            if(divsu>sosu){
                // printf("\nsosu = %d divsu %d cnt %d\n",sosu,divsu,cnt);
                break;
            }
        }   
        if(cnt == 2){
            printf("%d ", sosu);
            i++;
            divsu = 0;
        }
        cnt = 0;
        sosu++;
    }
}