#include <stdio.h>

int main(){
    // File *file = open("a.txt","wt");
    int ch1,ch2;

    ch1 = getchar();
    ch2 = fgetc(stdin);

    putchar(ch1);
    // fputc(ch2,stdout);
    // putchar(ch2);
    printf("ch2 = %d",ch2);
    printf("ch2 = %c",ch2);
    return 0;
}