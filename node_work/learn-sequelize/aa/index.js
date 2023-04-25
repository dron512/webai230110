console.log('aaaa');
const a = 10;
const b = 20;

const aa = {};

aa.test = ()=>{
    console.log('테스트 함수가 실행됩니다.');
}

aa.test();
console.log(a+b);

class BB{
    doA(){
        console.log("aa");
    }
    doB = ()=>{
        console.log("bb")
    }
}

aa.bb = new BB();

module.exports = aa;