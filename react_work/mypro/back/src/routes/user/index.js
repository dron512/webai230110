'use strict';

const express = require('express');
const router = express.Router();

const us = require('../../models/users');

router.get('/users',async (req,res)=>{
    const users = await us.selectUser();
    console.log("test"+users);
    res.json(users);
});


router.post('/users/insert',async(req,res)=>{
    console.log(req.body);
    await us.createUser(
        req.body.firstName,
        req.body.lastName,
        req.body.email);
    res.json({"status":"ok"});
})

module.exports = router;