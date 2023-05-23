const a = require('../com/a.js');
const b = require('../com/b.js');

console.log(`a ${a}`);
console.log(`b ${b}`);

a();
b();

const c = ()=>{ console.log('c함수') };
console.log(c);
console.log(`c ${c}`);
c();

// console.log(`a ${JSON.stringify(a)}`);
// console.log(`b ${JSON.stringify(b)}`);

console.log('main.js');