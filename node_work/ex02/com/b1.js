// console.log('b.js');

class Person{
    a = 20;
    b;
    constructor(a,b){
        this.a = a;
        this.b = b;
    }
    doA = ()=>{ console.log(`this.a ${this.a}`)}
}
const person1 = new Person(30,"bbb");
const person2 = new Person(40);

// console.log(person1)
// console.log(person2)

// const aa = {};
// aa.person1 = person1;
// aa.person2 = person2;

// module.exports = aa;

// module.exports = {person1,person2};

const aa = {
    person1,
    person2
};

module.exports = aa;
