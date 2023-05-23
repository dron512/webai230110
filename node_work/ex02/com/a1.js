// console.log('a.js');

const car = {
  a: 30,
  doA: () => {
    console.log("원래");
    console.log(`car.a ${car.a}`);
  },
};
car.a = 10;
car.doA = ()=>{
    console.log(`car.a ${car.a}`);
}

module.exports = car;
