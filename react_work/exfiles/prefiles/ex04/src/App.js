import './App.css';
import MyButton from './components/MyButton.js';
import MyMap from './components/MyMap';
import MyProfile from './components/MyProfile.js';

function App() {
  let a = "aa";
  a = "bb";
  const b = { a:"aa"};
  b.a = "bb";
  const profile = {
    name:"누시다",
    age:20
  };
  const arr = [10,20];
  const [ele1,ele2] = arr; 
  const sayHello = (name='홍길동')=>{ return `안녕하세요 ${name}님`};

  const sumfn = (num1,num2) => num1+num2;

  const arr1 = [20,30];
  const arr2 = arr1;
  const arr3 = [...arr1];

  arr2[0] = 10;
  arr3[0] = 50;

  console.log(`arr1 = ${arr1}`);
  console.log(`arr2 = ${arr2}`);
  console.log(`arr3 = ${arr3}`);

  const obj1 = {aa:10,bb:20};
  const obj2 = {...obj1};
  const obj3 = obj1;

  obj2.aa = 30;
  obj3.aa = 20;

  console.log(`obj1.aa = ${obj1.aa} obj1.bb = ${obj1.bb}`);
  console.log(`obj2.aa = ${obj2.aa} obj2.bb = ${obj2.bb}`);
  console.log(`obj3.aa = ${obj3.aa} obj3.bb = ${obj3.bb}`);

  return (
    <div className="App">
      <h1>{a}</h1>
      <h1>{b.a}</h1>
      <MyButton></MyButton>
      <MyButton></MyButton>
      <MyButton></MyButton>
      <MyProfile a={profile} b="사람"></MyProfile>
      <h3>arr[0] = {ele1}</h3>
      <h3>arr[1] = {ele2}</h3>
      <h2>{sayHello('누시다')}</h2>
      <h2>{sayHello()}</h2>
      <MyProfile a={{age:30}} b="사람"></MyProfile>
      <h1>{sumfn(arr[0],arr[1])}</h1>
      <h1>{sumfn(...arr)}</h1>
      <MyMap></MyMap>
    </div>
  );
}

export default App;

