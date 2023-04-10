import { useReducer, useRef } from 'react';
import Student from './components/Student';
import {
  CenterDiv,
  MyButton,
  MyInput,
  MyStudentDiv,
} from './styedcomponents/MyStylesCom';

const colorary = ['blue', 'red', 'green'];
const datas = {
  count: 3,
  students: [
    { key: 1, name: '홍길동', age: 20, bo: colorary[0] },
    { key: 2, name: '김길동', age: 30, bo: colorary[1] },
    { key: 3, name: '이길동', age: 40, bo: colorary[2] },
  ],
};

const reducer = (state, action) => {
  switch (action.type) {
    case 'add-data':
      console.log(state.students);
      state = {
        count: state.count + 1,
        students: [
          ...state.students,
          {
            key: state.count + 1,
            name: action.student.name,
            age: action.student.age,
            bo: colorary[state.count % 3],
          },
        ],
      };
      return state;
    case 'del-data':
      console.log(`key = ${action.name}`);
      state = {
        count: state.count + 1,
        students: state.students.filter((data) => data.name !== action.name),
      };
      return state;
    default:
      return state;
  }
};

const Students = () => {
  const [rdata, dispatch] = useReducer(reducer, datas);
  const nameRef = useRef();
  const ageRef = useRef();
  return (
    <div>
      <h1>학생관리프로그램</h1>
      <div style={{ border: `1px solid #333`, width: `500px`, margin: `1rem` }}>
        <h2>학생이름</h2>
        <MyInput ref={nameRef}></MyInput>
        <h2>학생나이</h2>
        <MyInput ref={ageRef}></MyInput>
        <CenterDiv>
          <MyButton
            onClick={() => {
              dispatch({
                type: 'add-data',
                student: {
                  name: nameRef.current.value,
                  age: ageRef.current.value,
                },
              });
            }}
          >
            등록
          </MyButton>
        </CenterDiv>
      </div>
      <MyStudentDiv>
        {rdata.students &&
          rdata.students.map((student) => (
            <Student
              key={student.key}
              name={student.name}
              age={student.age}
              bo={student.bo}
              dispatch={dispatch}
            />
          ))}
      </MyStudentDiv>
    </div>
  );
};

export default Students;
