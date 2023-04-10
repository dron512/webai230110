import React from 'react';

const Three = () => {
    const val1 = 1>0? "true입니다":"false입니다";
    console.log(`val1 = ${val1}`);
    // const printFormat = (num)=>{
    //     return typeof(num) ==="number"?num.toLocaleString():"숫자입력하세요";
    // }
    const printFormat = (num)=>{
        let test;
        if(typeof(num)==="number"){
            test = num.toLocaleString();
        }else{
            test = "숫자 입력하세요"
        }
        return test;
    }
    // function printFormat(num){
    //     return typeof(num) ==="number"?num.toLocaleString():"숫자입력하세요";
    // }
    return ( 
        <>
         <h1>{val1}</h1>
         <h2>{printFormat(13000)}</h2>       
         <h2>{printFormat("13000")}</h2>       
        </> 
    );
}
 
export default Three;