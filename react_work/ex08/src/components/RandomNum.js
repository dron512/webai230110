import React, { useState } from 'react';

const RandomNum = () => {
    const [winlose, setWinLose] = useState([0, 0, 0]);
    const [num, setNum] = useState(0);
    const getNum = () => {
        const num = Math.random();
        setNum(num * 255);
    };
    const doGame = (e) => {
        const comNum = parseInt(Math.random() * 3);
        const personNum = e.target.dataset.num;
        console.log(`comNum ${comNum} personNum ${personNum}`);
        // 0 가위, 1 바위, 2 보
        if (comNum == 0 && personNum == 0) {
            winlose[2]++;
            setWinLose([...winlose]);
        } else if (comNum == 0 && personNum == 1) {
            winlose[0]++;
            setWinLose([...winlose]);
        } else if (comNum == 0 && personNum == 2) {
            winlose[1]++;
            setWinLose([...winlose]);
        }
        // 0 가위, 1 바위, 2 보
        if (comNum == 1 && personNum == 0) {
            winlose[1]++;
            setWinLose([...winlose]);
        } else if (comNum == 1 && personNum == 1) {
            winlose[2]++;
            setWinLose([...winlose]);
        } else if (comNum == 1 && personNum == 2) {
            winlose[0]++;
            setWinLose([...winlose]);
        }
        // 0 가위, 1 바위, 2 보
        if (comNum == 2 && personNum == 0) {
            winlose[0]++;
            setWinLose([...winlose]);
        } else if (comNum == 2 && personNum == 1) {
            winlose[1]++;
            setWinLose([...winlose]);
        } else if (comNum == 2 && personNum == 2) {
            winlose[2]++;
            setWinLose([...winlose]);
        }
        console.log(winlose);
    };
    return (
        <>
            <h1>{num}</h1>
            <button onClick={getNum}>생성</button>
            <h1>{`승 ${winlose[0]} 패 ${winlose[1]} 무${winlose[2]} `}</h1>
            <button onClick={doGame} data-num="0" data-value="aa">
                가위
            </button>
            <button onClick={doGame} data-num="1" data-value="bb">
                바위
            </button>
            <button onClick={doGame} data-num="2" data-value="cc">
                보
            </button>
        </>
    );
};

export default RandomNum;
