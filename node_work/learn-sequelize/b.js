const obj = {};

const aa = ()=>{
    console.log('함수 a');
}
const bb = ()=>{
    console.log('함수 b');
}
const cc = ()=>{
    console.log('함수 c');
}
obj.aa = aa;
obj.bb = bb;
obj['cc'] = cc;
module.exports = obj;