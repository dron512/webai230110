import Studnet from "./components/Student";
import React, { useState } from "react";

export default function App() {
  const [students, setStudents] = useState([
    { name: "구름", kor: 87, eng: 98, math: 95, scy: 80 },
    { name: "별이", kor: 80, eng: 78, math: 85, scy: 75 },
  ]);

  return (
    <div className="App">
      <h1>Hello CodeSandbox</h1>
      <h2>Start editing to see some magic happen!</h2>
      <button
        onClick={() => {
          setStudents([
            ...students,
            { name: "겨울", kor: 78, eng: 88, math: 80, scy: 60 },
            { name: "바다", kor: 75, eng: 90, math: 90, scy: 85 },
          ]);
        }}
      >
        추가
      </button>
      {students.map((obj) => {
        return <Studnet key={obj.name} student={obj} />;
      })}
    </div>
  );
}
