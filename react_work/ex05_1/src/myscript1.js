const divEl = document.createElement("div");
const pEl = document.createElement("p");
pEl.textContent='p 문단 태그 입니다.'

const $dom = document.querySelector('.dom');

divEl.appendChild(pEl);
$dom.appendChild(divEl);

const $container = document.querySelector('.container');
const button = document.createElement('button');
button.textContent="버튼";

$container.prepend(button);
$container.textContent = "";

const $body = document.querySelector('body');
const $h1 = document.querySelector('#title');

$body.removeChild($h1);
$body.textContent = "";