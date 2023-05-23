import { Box, Button } from "@mui/material";
import { useNavigate } from "react-router-dom";

const Menu = (props) => {
  const navigate = useNavigate();
  return (
    <Box
      align="center"
      {...props}
    >
      <Button
        type="button"
        variant="contained"
        sx={{ mr:1, width: "22%", height: "70px" }}
        onClick={() => {
          navigate("/vaform");
        }}
      >
        휴가계작성
      </Button>
      <Button
        type="button"
        variant="contained"
        sx={{  mr:1, width: "22%", height: "70px" }}
        onClick={() => {
          navigate("/valist");
        }}
      >
        휴가계목록
      </Button>
      <Button
        type="button"
        variant="contained"
        sx={{  mr:1, width: "22%", height: "70px" }}
        onClick={() => {
          navigate("/board");
        }}
      >
        게시판
      </Button>
      <Button
        type="button"
        variant="contained"
        sx={{ width: "22%", height: "70px" }}
        onClick={() => {
          navigate("/member");
        }}
      >
        회원관리
      </Button>
    </Box>
  );
}
 
export default Menu;