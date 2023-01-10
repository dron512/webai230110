#include <stdio.h>

int sfunc(int a){
    printf("a = %d\n",a);
}
double sfunc2(double a){
    printf("a = %g\n",a);
}
int main(){

    int (*fptr)(int) = sfunc;
    double (*fptr2)(double) = sfunc2;

    sfunc(10);
    fptr(20);

    sfunc2(10.5);
    fptr2(20.5);

}