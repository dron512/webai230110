import * as React from "react";
import Avatar from "@mui/material/Avatar";
import Button from "@mui/material/Button";
import CssBaseline from "@mui/material/CssBaseline";
import TextField from "@mui/material/TextField";
import FormControlLabel from "@mui/material/FormControlLabel";
import Checkbox from "@mui/material/Checkbox";
import Link from "@mui/material/Link";
import Paper from "@mui/material/Paper";
import Box from "@mui/material/Box";
import Grid from "@mui/material/Grid";
import LockOutlinedIcon from "@mui/icons-material/LockOutlined";
import Typography from "@mui/material/Typography";
import { createTheme, ThemeProvider } from "@mui/material/styles";

import { useNavigate } from 'react-router-dom';

function Copyright(props) {
  return (
    <Typography
      variant="body2"
      color="text.secondary"
      align="center"
      {...props}
    >
      {"Copyright © "}
      <Link color="inherit" href="https://kb.or.kr/">
        kb.or.kr 홈페이지
      </Link>{" "}
      {new Date().getFullYear()}
      {"."}
    </Typography>
  );
}

const defaultTheme = createTheme();

export default function Main() {

  const naviate = useNavigate();

  const handleSubmit = (event) => {
    const data = new FormData(event.currentTarget);
    console.log({
      email: data.get("email"),
      password: data.get("password"),
    });
    naviate('main');
  };

  return (
    <ThemeProvider theme={defaultTheme}>
      <Grid container component="main" sx={{ height: "100vh" }}>
        <CssBaseline />
        <Grid
          item
          xs={false}
          sm={4}
          md={7}
          sx={{
            backgroundImage: "url(http://kb.or.kr/images/AI_top_back.jpg)",
            backgroundRepeat: "no-repeat",
            backgroundColor: (t) =>
              t.palette.mode === "light"
                ? t.palette.grey[50]
                : t.palette.grey[900],
            backgroundSize: "cover",
            backgroundPosition: "center",
          }}
        />
        <Grid item xs={12} sm={8} md={5} component={Paper} elevation={6} square>
          <Box
            sx={{
              my: 8,
              mx: 4,
              display: "flex",
              flexDirection: "column",
              alignItems: "center",
            }}
          >
            <Avatar sx={{ m: 1, bgcolor: "secondary.main" }}>
              <LockOutlinedIcon />
            </Avatar>
            <Typography component="h1" variant="h5">
              경북산업직업전문학교
            </Typography>
            <Typography component="h1" variant="h5">
              Main
            </Typography>
            <Box noValidate sx={{ mt: 1 }}>
              <Button
                type="button"
                variant="contained"
                sx={{ mt: 3, mb: 2, mr: 3, width: "45%", height: "70px" }}
              >
                휴가계작성
              </Button>
              <Button
                type="button"
                variant="contained"
                sx={{ mt: 3, mb: 2, width: "45%", height: "70px" }}
              >
                휴가계리스트
              </Button>
              <Button
                type="button"
                variant="contained"
                sx={{ mt: 3, mb: 2, mr: 3, width: "45%", height: "70px" }}
              >
                게시판
              </Button>
              <Button
                type="button"
                variant="contained"
                sx={{ mt: 3, mb: 2, width: "45%", height: "70px" }}
              >
                회원관리
              </Button>
              <Copyright sx={{ mt: 5 }} />
            </Box>
          </Box>
        </Grid>
      </Grid>
    </ThemeProvider>
  );
}
