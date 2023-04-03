// const A = () => {
//   return { aa: 10, bb: 20 };
// };

// export default A;

// export const B = () => {
//     return { aa: 10, bb: 20 };
// };

import { useParams } from 'react-router-dom';

const MyUse = () => {
  let { idx } = useParams();
  return (
    <>
      <h1>MyUse</h1>
      <p> 현재 페이지의 param 은 {idx}</p>
    </>
  );
};

export default MyUse;
