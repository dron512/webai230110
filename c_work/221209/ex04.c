#include <stdio.h>

int main()
{
    // alt + shift + f
    // ctrl + z 뒤로 돌아가기
    // ctrl + y 앞으로 가기
    int num = 0;
    while (num < 5)
    {
        printf("Hello World %d\n", num);
        num = num + 1; // num++;
    }

    return 0;
}