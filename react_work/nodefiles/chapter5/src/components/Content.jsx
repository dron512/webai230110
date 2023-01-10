import React, { useEffect, useState } from "react";
import Article from "./Article";
import TabItem from "./TabItem";

function Content() {
  const [tabChecked1, setTabChecked1] = useState(true);
  const checked1 = () => {
    if (tabChecked1 === true) setTabChecked1(false);
    else setTabChecked1(true);
  };
  const [tabChecked2, setTabChecked2] = useState(false);
  const checked2 = () => {
    if (tabChecked2 === false) setTabChecked2(true);
    else setTabChecked2(false);
  };
  useEffect(() => {
    setTabChecked2(true);
    setTabChecked2(false);
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
          checked={tabChecked1}
          onChange={checked1}
        />
        <input
          type="radio"
          name="tab"
          id="second"
          checked={tabChecked2}
          onChange={checked2}
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
