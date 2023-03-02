import React, { useState } from 'react';

const MyButton = () => {
    const [number,setNumber] = useState(10);

    return <div>
        <h1>Number = {number}</h1>
        <button onClick={()=>{
            setNumber(number+1);
        }}>버튼</button>
    </div>;
};

export default MyButton;
