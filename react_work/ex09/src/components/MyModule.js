import React, { useState } from 'react';
import aa from './MyModule.module.scss';

const MyModule = () => {
    const [test, setTest] = useState(aa.mp);
    return (
        <>
            <p className={test}>lorem lorem lorem lorem lorem</p>
            <button className={aa.button}
                onClick={() => {
                    if (test == aa.mp) setTest(aa.mp1);
                    else setTest(aa.mp);
                }}
            >
                버튼
            </button>
            <h1 className={aa.h1s}>Hello MyModule css</h1>
        </>
    );
};

export default MyModule;
