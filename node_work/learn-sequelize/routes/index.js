const exrpess = require('express');

const router = exrpess.Router();

router.get("/",(req,res)=>{
    const aa = "aaa";
    const test = [{aa:"a값"},{bb:"b값"}]
    res.render("index",{aa,test});
})

module.exports = router;