#include <stdio.h>

int main(){
    double total=0.0,input=0.0;
    int num =0;

    for(    ; input>=0.0;  num++   ){
        total+=input;
        printf("실수 입력: (마이너스넣으면종료)");
        scanf("%lf",&input);
       
    }

    printf("평균 = %f\n",total/(num-1));
    return 0;

}