/*
    call by reference
    call by value
*/

#include <stdio.h>
// call by value
void whovalue(int value){
    printf("value = %d\n",value);
    value = 20;
    printf("value = %d\n",value);
}
// call by reference
int whoref(int *reference){
    printf("reference = %d\n",reference);
    *reference = 20;
    printf("*reference = %d\n",*reference);
}
int main(){
    int a = 10;
    printf("a = %d\n",a);
    whovalue(a);
    printf("a = %d\n",a);
    whoref(&a);
    printf("&a = %d\n",&a);
    printf("a = %d\n",a);

    return 0;
}