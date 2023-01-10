#include <stdio.h>

int main(){

    int a = 10;
    // int *pnum;
    // pnum = &a;
    int *pnum = &a;
    

    printf("a = %d\n",a);
    printf("&a = %d\n",&a);
    printf("pnum = %d\n",pnum);
    printf("&pnum = %d\n",&pnum);
    printf("*pnum = %d\n\n",*pnum);

    printf("sizeof(a) = %d\n",sizeof(a));
    printf("sizeof(pnum) = %d\n",sizeof(pnum));

    *pnum = 20;

    printf("*pnum = %d\n\n",*pnum);
    printf("a = %d\n\n",a);
}
