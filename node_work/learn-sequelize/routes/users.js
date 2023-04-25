const exrpess = require('express');

const router = exrpess.Router();

router.get("/",(req,res)=>{
    const user = "아임 유저";
    res.render("users",{user});
})

router.get("/aaa",(req,res)=>{
    const user = "aaaaa아임 유저";
    res.render("users",{user});
})


router.get("/bbb",(req,res)=>{
    const user = "bbbbb 유저";
    res.render("users",{user});
})

module.exports = router;