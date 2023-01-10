/*
    세개 의 정수를 인자로 전달 받아서 그 중 가장 큰 수를 반환하는 함수와
    가장 작은수를 반환하는 함수를 정의해보자
    그리고 이 함수를 호출하는 적절한 main 함수도 작성해보자
*/
#include<stdio.h>
//가장 큰수 반환
int retbvalue(int a,int b, int c){
    if ( a > b )
    {
        if ( a>c ){
            return a;
        }else{
            return c;
        }
    }
    else{
        if ( b >c ){
            return b;
        }
        else{
            return c;
        }
    }
    return b;
}
// 가장 작은수 반환
int retsvalue(int a, int b, int c){
    if( a > b)
    {
        if( b > c){
            return c;
        }
        else{
            return b;
        }
    }
    else{
        if (a >c){
            return c;
        }
        else{
            return a;
        }
    }
    return a;
}

int main(){
    printf("가장 큰 수 %d\n",retbvalue(5,10,3));
    printf("가장 큰 수 %d\n",retbvalue(10,5,3));
    printf("가장 큰 수 %d\n",retbvalue(5,7,10));
    printf("가장 작은 수 %d\n",retsvalue(5,10,3));
    printf("가장 작은 수 %d\n",retsvalue(3,7,10));
    printf("가장 작은 수 %d\n",retsvalue(10,3,7));
}