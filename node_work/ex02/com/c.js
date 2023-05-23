class MyC{
    static aa = 10;
    static doA(){
        console.log('doA');
    }
    doB(){
        console.log('doB');
    }
}

MyC.doA = ()=>{ console.log('doAAA'); }

const myc = new MyC();

module.exports = {MyC,myc};