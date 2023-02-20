class Parent{
    constructor(){
        console.log('부모생성자');
    }
    doA(){
        console.log('부모 doA');
    }
}
class Child extends Parent{
    constructor(){
        super();
        console.log('자식생성자');
    }
    doA(){
        // super.doA();
        console.log('자식 doA');
    }
}