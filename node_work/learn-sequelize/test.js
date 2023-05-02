const fs = require('fs');
const path = require('path');

console.log(__filename);
console.log(__dirname);

const test = fs.readdirSync(__dirname)
.filter((f)=>{
    return f === 'b.js';
})
.forEach((f)=>{
    const {aa,bb} = require(f)
    console.log(aa);
    console.log(bb);
});

console.log(test);


