import React, { useState } from 'react';

const Counter = ({ name }) => {
    console.log(`name ${name}`);
    const [count,setCount] = useState(0);
    return (
        <>
            <h1>{name}</h1>
            <button onClick={()=>{setCount(count-1)}}>-</button>
            <span>{count}</span>
            <button onClick={()=>{setCount(count+1)}}>+</button>
        </>
    );
};

export const AA = ()=>{ return (<div><h1>aa</h1></div>)}

export default Counter;
