#include <stdio.h>

int main()
{
    int total = 0, num = 0;

    do
    {
        printf("num 입력 : ");
        scanf("%d", &num);
        total = total + num;
    } while (num != 0);

    printf("total = %d", total);
}