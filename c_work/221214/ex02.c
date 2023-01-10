#include <stdio.h>

int factorial(int n){
    if(n==1)
        return 1;
    else
        return n * factorial(n-1);
}
/*
    factorial(4)
    4 * factorial(3)
    4 * 3 * factorial(2)
    4 * 3 * 2 * factorial(1)
    4 * 3 * 2 * 1 
*/
int main(){
    printf("4! = %d",factorial(4));
}