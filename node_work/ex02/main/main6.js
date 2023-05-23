const doa = require('../com/e.js')

const aa = async()=>{
    try{
        const result = doa();
        console.log(result);
    }catch(e){
        console.log(e);
    }
}

aa();
console.log('test');

// doa()
// .then((resolve)=>{
//     console.log(resolve);
// })
// .catch((reject)=>{
//     console.log(reject);
// })
// .finally(()=>{
//     console.log('무조건 실행이됨');
// });