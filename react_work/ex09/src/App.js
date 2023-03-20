// import './App.css';
import MyInlin from './components/MyInlin';
import MyModule from './components/MyModule';
import MyStyledJsx from './components/MyStyledJsx';
import TimeSp, { MyTag } from './components/TimeSp';

function App() {
    return (
        <div className="App">
            <header className="App-header">
                <MyStyledJsx />
                <MyInlin />
                <MyModule />
                {/* <MyTag/>
        <TimeSp name="첫번째"/>
        <TimeSp name="두번째"/> */}
            </header>
        </div>
    );
}

export default App;
