#include <stdio.h>

int main()
{
    int cur = 2;
    int is = 1;

    while (cur < 10)
    {
        is = 1;
        while (is < 10)
        {
            printf("%d * %d = %d \n", cur, is, cur * is);
            is = is + 1;
        }
        printf("\n");
        cur = cur + 1;
    }
}