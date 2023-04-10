const ContentMessage = ({color,message}) => {
    const doA = { aa:"avalue",bb:"bvalue"};
    const {aa,bb} = doA;

    // const {color,message} = props;
    const style = 
    { 
        color:color,
        fontSize:"2rem" 
    };
    return ( 
        <p style={style}>
            {message}
            <h1>{aa}</h1>
            <h1>{bb}</h1>
        </p> 
    );
}
 
export default ContentMessage;