#include <stdio.h>

int num;

int Add(int val){
    num = num + val;
}

int main(){
    printf("num = %d\n",num);
    Add(10);
    printf("num = %d\n",num);
    num ++;
    printf("num = %d\n",num);

}
