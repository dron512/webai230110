// const doa = ()=>{
//     return new Promise();
// }

module.exports = ()=>{
    return new Promise((resolve,reject)=>{
        setTimeout( ()=>{
            const data = 'aixos통해서 받은 데이터';
            if(data){
                resolve(data)
            }else{
                reject('에러에러')
            }
        },2000);
    });
};