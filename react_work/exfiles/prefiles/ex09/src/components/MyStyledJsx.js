const MyStyledJsx = () => {
    return (
        <>
            <div className="container">
                <h1>MyStyledJsx</h1>
                <p>
                    MyStyledJsx 스타일 주는 방법입니다.
                    방법이 많기 떄문에 편리한 방법을 선택하시면 됩니다.
                </p>
            </div>
            <style jsx>{`
                .container {
                    background-color: blue;
                    padding:16px;
                }
                h1{
                    color:yellow;
                }
                p{
                    color:white;
                }
            `}</style>
        </>
    );
};

export default MyStyledJsx;
