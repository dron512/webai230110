/*
    1 두 개의 정수를 입력받아 뺄셈과 곱셈
*/

#include <stdio.h>

int main(){
    int n1,n2;
    printf("숫자 입력");
    scanf("%d",&n1);
    printf("숫자 입력");
    scanf("%d",&n2);

    printf("%d - %d = %d",n1,n2,n1-n2);
}