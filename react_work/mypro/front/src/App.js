import './App.css';

import React, { useState } from 'react';

function App() {
    const [data, setData] = useState([{ bk_name: 'aaa' }, { bk_name: 'aaaa' }]);

    const rootfn = () => {
        fetch(`http://localhost:5000/`)
            .then((result) => result.text())
            .then((data) => {
                console.log(data);
            });
    };
    const rootfn1 = () => {
        fetch(`http://localhost:5000/book`)
            .then((result) => result.json())
            .then((getdata) => {
                console.log(...data);
                console.log(...getdata);
                const myresult = [...data,...getdata];
                setData(myresult);
            });
    };
    return (
        <div className="App">
            <header className="App-header">
                <button onClick={rootfn}>버튼1</button>
                <button onClick={rootfn1}>버튼2</button>
                <div>
                    <ul>
                        {data.map((obj) => {
                            return <h2>{obj.bk_name}</h2>;
                        })}
                    </ul>
                </div>
            </header>
        </div>
    );
}

export default App;
