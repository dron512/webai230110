#include <stdio.h>

int main(){

    char str[] = "Good morning!";

    printf("sizeof(str) = %d \n",sizeof(str));

    str[12]= '?';
    // %s = \0 널문자가 있는데 까지 문자열을 출력한다
    printf("str = %s\n",str);
    printf("str[13] = %c\n",str[13]);
    printf("str[13] = %d\n",str[13]);
}