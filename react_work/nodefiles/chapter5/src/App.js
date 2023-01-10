import './App.css';
import Content from './components/Content';
import MainFooter from './components/MainFooter';
import MainHeader from './components/MainHeader';

function App() {
  return (
    <div id="wrap">
      <MainHeader></MainHeader>
      <Content></Content> 
      <MainFooter></MainFooter>     
    </div>
  );
}

export default App;
