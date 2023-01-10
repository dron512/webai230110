#include <stdio.h>

int main(){
    double arr[] = {11.1,22.2,33.3};

    double *ptr = &arr[0];

    printf("주소값 =======\n");
    printf("%d %d %d\n",ptr,ptr+1,ptr+2);
    printf("값 ===========\n");
    printf("%g %g %g\n",*ptr,*(ptr+1),*(ptr+2));
    printf("값 ===========\n");
    printf("%g %g %g\n", ptr[0],ptr[1],ptr[2]);
}