document.addEventListener("DOMContentLoaded", ()=>{
    const $button = document.querySelector("button");
    const $input = document.querySelector("#memo-txt");
    const $ul = document.querySelector("#memo-list");
    $button.addEventListener("click", ()=>{
        const text = $input.value;
        $input.value = "";
        const $li = document.createElement("li");
        const $div = document.createElement("div");
        const $button = document.createElement("button");
        $button.textContent = "삭제";
        $button.addEventListener("click", ()=>{
            const deleteTarget = $button.closest("li");
            $ul.removeChild(deleteTarget);
        });
        const $p = document.createElement("p");
        $p.textContent = text;
        $div.appendChild($p);
        $div.appendChild($button);
        $li.appendChild($div);
        $ul.appendChild($li);
    /*
            <li><div><p>인풋창내용</p><button>삭제</button></div></li>
        */ });
});

//# sourceMappingURL=index.06011e4d.js.map
