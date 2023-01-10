/*
    *
    O *
    O O *
    O O O *
    O O O O *
    참고로 총 5행에 걸쳐서 출력이 이루어 지고 행이 더해질때 마다 O가 추가됨
*/

#include<stdio.h>

int main(){
    int c_cnt = 0;
    int num = 1;
    int t_cnt = 0;

    while(t_cnt < 5){
        while(c_cnt>0){
            printf(" O ");
            c_cnt = c_cnt-1;
        }
        printf(" * \n");
        c_cnt = c_cnt+num;
        num = num + 1;
        t_cnt = t_cnt+1;
    }

}