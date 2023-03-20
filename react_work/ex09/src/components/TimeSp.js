import React, { useState,useEffect } from 'react';

export const MyTag = () => {
    const [tag,setTag] = useState('MyTag');
    const [tag2,setTag2] = useState('MyTag2');
    
    useEffect(()=>{
        console.log('render');
    },[tag,tag2]);
    // [] <- 초기에 한번만 실행한다.

    return (
        <div>
            <h1>{tag}</h1>
            <h1>{tag2}</h1>
            <button onClick={
                ()=>{setTag('test')}
            }>버튼1</button>
            <button onClick={
                ()=>{setTag2('test')}
            }>버튼2</button>
        </div>
    );
};

const TimeSp = ({ name }) => {
    const [hour, setHour] = useState(0);
    const [min, setMin] = useState(0);
    const [second, setSecond] = useState(0);
    const [time, setTime] = useState([0, 0, 0]);
    const handleInput = (e) => {
        const num = e.target.value;
        const hour = parseInt(num / 3600);
        const min = parseInt((num % 3600) / 60);
        const second = num % 60;
        setHour(hour);
        setMin(min);
        setSecond(second);
        setTime([hour, min, second]);
    };
    return (
        <div>
            <h1>{name} 시간 입력</h1>
            <input onChange={handleInput}></input>
            <h2>
                {' '}
                {hour} 시 {min} 분 {second} 초
            </h2>
            <h2>
                {' '}
                {time[0]} 시 {time[1]} 분 {time[2]} 초
            </h2>
        </div>
    );
};

export default TimeSp;
