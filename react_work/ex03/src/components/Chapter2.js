import React, { useState } from 'react';

const Chapter2 = () => {
    const doA = () => {
        setTest('setTest');
    };
    const [test, setTest] = useState('test');

    const a = {
        name: '누시다',
        age: 20,
    };
    a.name = 'Nusida';

    const b = `이름은 ${a.name} 나이는 ${a.age} 살 입니다`;

    const hi = () => {
        return '안녕하세요';
    };
    const month = 1;
    function fntest(a) {
        return a;
    }
    const arrotest = (b, c) => b + c;
    return (
        <div>
            <h1>Chapter2</h1>
            <p>
                이름 {a.name}
                나이 {a.age}
            </p>
            <h2>{test}</h2>
            <button onClick={doA}>버튼</button>
            <h3>{b}</h3>
            <h3>{`여러분 ${hi()}~! ${month * 2} 월입니다.`}</h3>
            <h3>{`${fntest('안녕 함수')} ${arrotest('화살표함수')}`}</h3>
            <h3>{`   ${arrotest('aaa', 'bbb')}   `}</h3>
        </div>
    );
};

export default Chapter2;
