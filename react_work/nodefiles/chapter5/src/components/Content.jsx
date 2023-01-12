import React, { useEffect, useState } from "react";
import { useRef } from "react";
import Article from "./Article";
import TabItem from "./TabItem";


function Content() {
  useEffect(() => {
    const $inputFirst = document.getElementById('first')
    $inputFirst.checked = true;
  }, []);
  return (
    <div id="content">
      <div id="section">
        <Article></Article>
        <Article></Article>
        <Article></Article>
        <Article></Article>
      </div>
      <div id="aside">
        <input
          type="radio"
          name="tab"
          id="first"
          onChange={()=>{}}
        />
        <input
          type="radio"
          name="tab"
          id="second"
        />
        <section className="buttons">
          <label htmlFor="first">First</label>
          <label htmlFor="second">Second</label>
        </section>
        <div className="tab_item">
          <ul>
            <TabItem name="HTML5 ONE" date="2023.01.08"></TabItem>
            <TabItem name="HTML5 Two" date="2023.01.08"></TabItem>
            <TabItem name="HTML5 Three" date="2023.01.08"></TabItem>
            <TabItem name="HTML5 Fours" date="2023.01.08"></TabItem>
          </ul>
        </div>
        <div className="tab_item">
          <ul>
            <TabItem name="Css3 One" date="2023.01.08"></TabItem>
            <TabItem name="Css3 Two" date="2023.01.08"></TabItem>
            <TabItem name="Css3 Three" date="2023.01.08"></TabItem>
            <TabItem name="Css3 Four" date="2023.01.08"></TabItem>
          </ul>
        </div>
      </div>
    </div>
  );
}

export default Content;
