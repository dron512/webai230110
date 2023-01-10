import React from "react";

function TabItem({name,date}) {
  return (
    <li className="item">
      <a href="#">
        <div className="thumbnail">
          <img src="https://via.placeholder.com/70" />
        </div>
        <div className="description">
          <strong>{name}</strong>
          <p>{date}</p>
        </div>
      </a>
    </li>
  );
}

export default TabItem;
