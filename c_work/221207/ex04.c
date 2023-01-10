#include <stdio.h>

int main()
{
    int n1, n2, result;

    printf("n1 을 입력 하세요 ");
    scanf("%d", &n1);

    printf("n2 을 입력 하세요 ");
    scanf("%d", &n2);

    result = n1 + n2;
    printf("%d + %d = %d", n1, n2, result);

    return 0;
}