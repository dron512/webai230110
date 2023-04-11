'use strict';

const express = require('express');
const router = express.Router();

const us = require('../../models/users');

router.get('/users',async (req,res)=>{
    const users = await us.selectUser();
    console.log("test"+users);
    res.json(users);
});

router.get('/users/insert',async(req,res)=>{
    await us.createUser('김씨','라스트','email');
    res.json({"status":"ok"});
})

module.exports = router;