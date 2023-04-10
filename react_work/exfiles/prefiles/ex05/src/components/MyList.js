import React from 'react';

const MyList = () => {
    const arr = ["고토","누시다","료코"];
    const brr = arr.filter((ele)=> ele!=='누시다')
    console.log(brr);

    const obj1 = [{ name:arr[0], age:20 },
                  { name:arr[1], age:30 },
                  { name:arr[2], age:40 }]

    return ( <div>
        {arr.map((ele,idx)=>{return <h1 key={idx}>{ele}</h1>})}
        {brr.map((ele,idx)=>{return <h1 key={idx}>{ele}</h1>})}
        {obj1.map( (ele,idx)=>{
            console.log(`ele.name = ${ele.name} ele.age = ${ele.age}`);
            console.log(`idx = ${idx}`);
            return <div><h1>나이 {ele.name}</h1><h1>{ele.age}</h1></div>
        }  )}
    </div> );
}
 
export default MyList;