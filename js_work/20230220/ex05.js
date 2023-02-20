class Square{
    static count=0;
    constructor(length){
        this.length = length;
        Square.count = Square.count + 1;
        console.log(`생성자에서 Square.count = ${Square.count}`)
    }
    print(){
        console.log(Square.count);
    }
}