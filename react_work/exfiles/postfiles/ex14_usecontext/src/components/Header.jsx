import React, { useContext } from 'react';
import { MyCss } from '../context/MyCssContext';
import { MyName } from '../context/MyNameContext';

const Header = () => {
  const {name, setName} = useContext(MyName);
  const css = useContext(MyCss);
  return (
    <div style={css}>
      <h1>header</h1>
      <h2>name = {name}</h2>
    </div>
  );
};

export default Header;
