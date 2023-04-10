const TrueFalse = () => {
    const a = null;
    const aTest = a||'설정된게 없습니다.';

    let aTest1;
    if(a){
        aTest1 = "설정됨";
    }
    else{
        aTest1 = "설정된게 없습니다.";
    }

    const b = 100;
    const bTest = b||"설정된게 있습니다.";
    return ( <>
        <h1>{aTest}</h1>
        <h1>{aTest1}</h1>
        <h1>{bTest}</h1>
    </> );
}
 
export default TrueFalse;