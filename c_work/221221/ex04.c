#include <stdio.h>

void main(){

    int arr[][4] = {
        {1,2,3,4},
        {4,5},
        {6,7,8},
    };

    printf("sizeof(arr) %d\n",sizeof(arr));
    printf("sizeof(arr[0]) %d\n",sizeof(arr[0]));
    printf("sizeof(arr[1]) %d\n",sizeof(arr[1]));
    printf("sizeof(arr[2]) %d\n",sizeof(arr[2]));

    //     48/16 = 3
    for ( int x = 0; x< sizeof(arr)/sizeof(arr[0]); x++)
    {
        //      16/4 = 4
        for (int y = 0; y<sizeof(arr[x])/sizeof(int); y++){
            printf("arr[%d][%d] =%d ",x,y,arr[x][y]);
        }
        printf("\n");
    }
}