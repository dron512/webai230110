const exrpess = require('express');

const router = exrpess.Router();

router.get("/",(req,res)=>{
    const user = "comments 유저";
    res.render("users",{user});
})

module.exports = router;