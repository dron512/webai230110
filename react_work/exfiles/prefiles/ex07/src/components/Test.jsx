import React, { useState } from 'react';

const Test = (props) => {
    // const {backgroundColor,color} = props;

    const [color,setColor] = useState(props.color);
    const [backgroundColor,setBackgroundColor] = useState(props.backgroundColor);

    const mystyle = {
        color,
        backgroundColor,
    };
    const changeColor = ()=>{
        // const $h1 = document.querySelector('h1');
        // $h1.style.color = "red";
        const [r,g,b] = [Math.random()*255,Math.random()*255,Math.random()*255];
        setColor(`rgba(${r},${g},${b},0.5)`);
        setBackgroundColor(`rgba(${r},${g},${b},0.5)`);
    }
    return (
        <div style={mystyle}>
            <h1>안녕하세요</h1>
            <button onClick={changeColor}>색깔바꾸기</button>
        </div>
    );
};

export default Test;
