#include <stdio.h>

void main(){

    int num1 = 10; 
    int num2 = 20;
    int num3 = 30;

    int *ptr[3] = {&num1,&num2,&num3};

    // 주소값에 가서 *를 만나면,, *가 int 형 4바이트를 읽어서 출력한다.

    printf("*ptr[0] %d\n",*(ptr[0]));
    printf("*ptr[1] %d\n",*(ptr[1]));
    printf("*ptr[2] %d\n",*(ptr[2]));

    printf("*(*ptr) %d\n",*(*ptr));
    printf("*(*ptr) %d\n",*(*(ptr+1)) );
    printf("*(*ptr) %d\n",*(*(ptr+2)) );
}
