const MyMap = () => {
    const arr = ["누시다","사키오카","고토"];

    arr.map( (name,idx) => { 
        console.log(`name ${name}\n idx ${idx}`);
    } ); 
    const brr = arr.filter((name)=>{
        return name!=='누시다'
    });
    console.log(brr);
    return <div>
        {arr.map((name,idx)=><h1 key={idx}>{name}</h1>)}
        {brr.map((name,idx)=><h1 key={idx}>{name}</h1>)}
    </div>;
};

export default MyMap;
