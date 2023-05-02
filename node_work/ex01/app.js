// const express = require('express');
// const {sequelize} = require('./models');

class A{
    constructor(a,b,c,d){
      console.log(`a ${a}`);
      console.log(`b ${b}`);
      console.log(`c ${c}`);
      console.log(`d ${ JSON.stringify(d) }`);
      this.aa = a;
    }
    doA = ()=>{ console.log('test') }
  }
  const config = {aaa:'aaa',bbb:'bbb',ccc:'ccc'};

  const a = new A(config.aaa,config.bbb,config.ccc, config);
  const a1 = {};
  
  console.log(a);
