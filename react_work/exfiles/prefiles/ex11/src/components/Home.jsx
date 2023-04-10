import { Container } from "react-bootstrap";
import MyCarousel from "./MyCarousel";

const Home = () => {
  return (
    <>
      <Container>
      <h1>Home</h1>
      <p>리액트 부트스트랩을 사용하여 만들었습니다</p>
      <MyCarousel/>
      </Container>
    </>
  );
};

export default Home;
