import { useState } from 'react';

export const useInput = () => {
  const [uid, setId] = useState();
  const doCheck = (e) => {
    var exp = /^[a-zA-Z0-9]{4,12}$/; //비밀번호 유효성 검사
    // console.log(exp.test(e.target.value));
    if (exp.test(e.target.value)) {
      // console.log("비밀번호 잘 넣었음");
      setId('정상적으로 입력하였습니다.');
    } else {
      if (e.target.dataset.type === 'id')
        setId('아이디는 4자리 이상 12자리이하 입력하세요');
      if (e.target.dataset.type === 'password')
        setId('비밀번호는 4자리 이상 12자리이하 입력하세요');
      // console.log("비밀번호 못 넣었음");
    }
    // console.log(e.target.dataset.type);
    // console.log(e.target.dataset.aa);
  };
  return [uid, doCheck];
};
