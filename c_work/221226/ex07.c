#include <stdio.h>

double func(double x){
    return x*x;
}

int main(){
    double lim = 1e-4;
    printf("%g\n",lim);

    double bunja = (func(10+lim) - func(10));
    double bunmo = lim;

    printf("bunja %g\n",bunja);
    printf("bunja/bunmo %g\n",bunja/bunmo);
}