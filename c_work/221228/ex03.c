#include <stdio.h>

int main(){
    char *str = "Simple String";
    printf("puts test \n");
    puts(str);
    puts("자동으로 줄바꿈 되네요");

    printf("fputs test \n");
    fputs(str,stdout);
    fputs("자동으로 줄바꿈 안되네요",stdout);
    return 0;
}