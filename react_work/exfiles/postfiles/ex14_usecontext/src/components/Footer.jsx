import { useContext } from 'react';
import { MyCss } from '../context/MyCssContext';
const Footer = () => {
  const css = useContext(MyCss);
  return (
    <div style={css}>
      <h1>Footer</h1>
    </div>
  );
};

export default Footer;
