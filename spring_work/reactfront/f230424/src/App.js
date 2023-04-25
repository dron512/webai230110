import "./App.css";
import React, { useEffect, useState } from "react";
import axios from "axios";

function App() {
  const [hi, setHi] = useState();
  useEffect(() => {
    axios
      .get(`http://localhost:8080/select`)
      .then((result) => setHi(result.data) );
  }, []);

  const aa = ()=>{ 
    axios
    .get(`http://localhost:8080/aa`)
    .then((result) => setHi(result.data) );
  }
  const bb = ()=>{ 
    axios
    .get(`http://localhost:8080/bb`)
    .then((result) => setHi(result.data) );
  }
  return (
    <div className="App">
      <h1>{hi}</h1>
      <button onClick={aa}>aa</button>
      <button onClick={bb}>bb</button>
    </div>
  );
}

export default App;
