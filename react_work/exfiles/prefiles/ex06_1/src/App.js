import Test from "./components/Test";
import "./App.css";
import ContentMessage from "./components/ContentMessage";

export const App = ()=>{
    const mystyle = { color : "red" , backgroundColor : "#c9c9c9", padding: "1rem" };
    return (
        <>
        {console.log('Test')}
            <Test></Test>
            <h1 style={mystyle}>test</h1>
            <ContentMessage color="#ff0" message="잘지내시죠?"></ContentMessage>
            <ContentMessage color="pink" message="못지냅니다."></ContentMessage>
            <ContentMessage color="blue" message="잘지냅니다."></ContentMessage>
            <button  onClick={   ()=>{ alert('test'); }  }>버튼</button>
        </>
    );
}