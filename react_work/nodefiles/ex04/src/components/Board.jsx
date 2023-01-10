import React from 'react';

function Board() {
    const arr = [1, 2, 3, 4, 5];
    return (
        <>
            <table>
                <thead>
                    <tr>
                        <th>index</th>
                        <th>title</th>
                        <th>writer</th>
                        <th>date</th>
                    </tr>
                </thead>
                <tbody>
                    {arr.map((inx) => {
                        return (
                            <tr key={inx}>
                                <td>{inx}</td>
                                <td>제목</td>
                                <td>작성자</td>
                                <td>2023.01.01</td>
                            </tr>
                        );
                    })}
                </tbody>
            </table>
        </>
    );
}

export default Board;
