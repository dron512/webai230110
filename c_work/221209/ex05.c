#include <stdio.h>

int main()
{

    int dan = 0, num = 1;
    printf(" 몇단 입력 : ?");
    scanf("%d", &dan);

    while (1)
    {
        
        printf("%d * %d = %d\n", dan, num, dan * num);
        num++;

        break;
        
    }
}