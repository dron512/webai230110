#include<stdio.h>

/*
    call by reference
    call by value
*/
void whoareyou(char *test){
    printf("==========whoareyou start======\n");
    printf("%d\n",test);
    printf("%s\n",test);
    printf("==========whoareyou end =======\n");
}
void main(){
    char str1[] = "My String";
    char *str2 = "My String";
    printf("str1 = %s\n",str1);
    printf("str2 = %s\n",str2);
    str1[0] = 'X';
    // str2[0] = 'X';
    printf("str1 = %s\n",str1);
    printf("str2 = %s\n",str2);

    printf("&str1[0] %d\n",&str1[0]);
    printf("str2 %d\n",str2);
    whoareyou(str1);
}