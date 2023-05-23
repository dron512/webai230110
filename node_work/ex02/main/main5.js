// Promise 객체를 생성하여 비동기 작업을 처리하는 함수
function fetchData() {
    return new Promise((resolve, reject) => {
      // 비동기 작업 수행
      setTimeout(() => {
        const data = 'Fetched data'; // 가정한 데이터
  
        if (data) {
          resolve(data); // 비동기 작업이 성공한 경우 resolve 호출
        } else {
          reject('Error occurred'); // 비동기 작업이 실패한 경우 reject 호출
        }
      }, 2000); // 2초 후에 작업 완료
    });
  }
  
  // Promise 사용 예제
  fetchData()
    .then((result) => {
      console.log('Success:', result);
    })
    .catch((error) => {
      console.log('Error:', error);
    })
    .finally(() => {
      console.log('Completed');
    });