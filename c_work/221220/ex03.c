#include <stdio.h>

int sfunc(int num){
    num = 30;
    printf("num = %d\n",num);
    return 30;
}

int main(){
    int age = 20;
    age = sfunc(age);
    printf("age = %d\n",age);
    return 0;
}