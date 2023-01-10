#include <stdio.h>

/*
    변수 a 에다가 3넣고
    변수 b 에다가 4넣고
    합과 곱을 출력해보시오.

    d: 드라이브이동
    cd work\c_work\221207 폴더이동
    dir 내용보기
*/
int main(){
    int a = 3;
    int b = 4;

    printf("%d + %d = %d\n", a, b, a+b);
    printf("%d * %d = %d", a, b, a*b);

    return 0;
}