const c = require('../com/c.js');

console.log(c.MyC.aa);
c.MyC.doA();
c.myc.doB();

c.MyC.aa = 40;
console.log(c.MyC.aa);