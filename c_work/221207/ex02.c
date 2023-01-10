#include <stdio.h>

int main()
{
    int n1 = 10;
    int n2 = 20;

    printf("%d < %d = %d\n", n1, n2, n1 < n2);
    printf("%d > %d = %d\n", n1, n2, n1 > n2);
    printf("%d == %d = %d", n1, n2, n1 == n2);

    printf("\n");
    if(n1>n2){
        printf("참 True");
    }else{
        printf("거짓 False");
    }

    return 0;
}