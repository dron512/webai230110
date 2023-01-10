#include <stdio.h>

int main()
{

    float num = 0.0;

    for (int i = 0; i < 100; i=i+1)
    {
        printf("i = %d\n",i);
        num = num + 0.1;
    }

    printf("num  = %f",num);
    return 0;
}