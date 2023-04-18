'use strict';

const express = require('express');
const router = express.Router();

const us = require('../../models/users');

router.get('/users/:pagenum',async (req,res)=>{
    const pagenum = req.params.pagenum;
    const users = await us.selectUser(pagenum);
    res.json(users);
});


router.get('/user/:id',async (req,res)=>{
    const id = req.params.id;
    const users = await us.selectUserId(id);
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

router.put("/users/update",async(req,res)=>{
    console.log(req.body);
    await us.updateUser(
        req.body.firstName,
        req.body.lastName,
        req.body.email,
        req.body.id);
    res.json({"status":"ok"});
})

module.exports = router;