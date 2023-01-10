/*
    3,5 3,4,5단
    5,3 3,4,5
    2,4 234
    4,2 234
*/

#include <stdio.h>

int main(){
    int start=0,end=0;
    printf("두수를 입력하세요(띄워쓰기나 엔터키사용가능)\n");
    scanf("%d %d",&start,&end);

    printf("start = %d\n",start);
    printf("end = %d\n",end);
    
    // end가 start 보다 작을 때...
    if ( end < start ){
        // temp 라는 변수를 만들어서 start에 값을 넣어놓자
        int temp = start;
        start = end;
        // temp 안에 있는 20을 end 에 넣자
        end = temp;
    }
    /* 
        start * 1 = 
        start * 2 = 
        start * 3 = 
        start<end+1
    */
    for ( ; start< end+1; start++ ){
        for( int i =1; i <10 ;i++ ){
            printf("%d*%d=%d ",start,i,start*i);
        }
        printf("\n");
    }
}