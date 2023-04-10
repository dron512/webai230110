/*
    getElementById()
    getElementsByClassName()
    querySelector(),querySelectorAll()
*/
const $title = document.getElementById('title');
console.log($title);
const $title2 = document.querySelector('#title');
console.log($title2);

const containers = document.getElementsByClassName('container');
console.log(containers);
for (const mydiv of containers) {
    console.log(mydiv);
}

const containers2 = document.querySelectorAll('.container');
console.log(containers2);
for (const mydiv of containers2) {
    console.log(mydiv);
}