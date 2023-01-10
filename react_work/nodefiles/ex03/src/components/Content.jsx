import React, { useEffect, useState } from 'react';

function Content() {
    const [arrm, setArrm] = useState([0, 30, 60]);
    const [mydis, setMydis] = useState(0);
    useEffect(() => {
        const timer = setInterval(() => {
            if (mydis === -60) {
                setMydis(0);
            } else {
                let test = mydis - 30;
                setMydis(test);
            }
        }, 3000);
        // return () => clearInterval(timer);
    }, [mydis]);
    return (
        <>
            <div>
                <ul
                    style={{
                        listStyle: 'none',
                        overflow: 'hidden',
                        width: '30rem',
                        height: '20rem',
                    }}
                >
                    <li className="cli" style={{ marginLeft: `${mydis}rem` }}>
                        <img
                            src="images/a.png"
                            style={{ float: 'left', width: '30rem', height: '20rem' }}
                        />
                        <img
                            src="images/b.png"
                            style={{ float: 'left', width: '30rem', height: '20rem' }}
                        />
                        <img
                            src="images/c.png"
                            style={{ float: 'left', width: '30rem', height: '20rem' }}
                        />
                    </li>
                </ul>
            </div>
        </>
    );
}

export default Content;
