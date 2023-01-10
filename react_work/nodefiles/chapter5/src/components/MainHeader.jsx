import React from 'react';

function MainHeader() {
  return (
    <div id="main_header">
      <div id="title">
        <h1>title</h1>
        <h2>mh portpolio</h2>
      </div>
      <div id="gnb_navigation">
        <ul>
          <li>
            <a href="#">web</a>
          </li>
          <li>
            <a href="#">mobile</a>
          </li>
          <li>
            <a href="#">game</a>
          </li>
          <li>
            <a href="#">simulation</a>
          </li>
        </ul>
      </div>
      <div id="lnb_navigation">
        <ul>
          <li>
            <a href="#">one</a>
          </li>
          <li>
            <a href="#">two</a>
          </li>
          <li>
            <a href="#">three</a>
          </li>
          <li>
            <a href="#">four</a>
          </li>
          <li>
            <a href="#">five</a>
          </li>
        </ul>
      </div>
    </div>
  );
}

export default MainHeader;
