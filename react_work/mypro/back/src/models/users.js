const { Sequelize, DataTypes } = require('sequelize');
const { Op } = require('sequelize');

class UserSequlize {
  sequelize;
  User;
  constructor() {
    this.sequelize = new Sequelize('mhpark', 'student', 'student123', {
      host: 'localhost',
      dialect: 'mysql',
    });
    this.User = this.sequelize.define('User', {
      firstName: {
        type: DataTypes.STRING,
        allowNull: false,
      },
      lastName: {
        type: DataTypes.STRING,
        allowNull: false,
      },
      email: {
        type: DataTypes.STRING,
        allowNull: false,
        unique: true,
      },
      password: {
        type: DataTypes.STRING,
        allowNull: false,
      },
    });
    this.User.sync()
      // this.User.sync({force:true})
      .then(() => {
        console.log('User 모델이 데이터베이스와 동기화되었습니다.');
      })
      .catch((err) => {
        console.error('동기화 오류:', err);
      });
  }
  createUser = async (firstName, lastName, email, password) => {
    try {
      const user = await this.User.create({
        firstName,
        lastName,
        email,
        password,
      });
      console.log('행을 삽입했습니다', user);
    } catch (e) {
      console.log(e);
    }
  };
  selectUser = async (pagenum) => {
    try {
      let offset = 1;
      const pageSize = 3;
      if (pagenum !== undefined) {
        offset = (pagenum - 1) * pageSize;
      }
      const users = await this.User.findAll({
        offset: offset,
        limit: pageSize,
        order: [['id', 'DESC']],
      });
      return users;
    } catch (e) {
      console.log(e);
    }
  };

  selectUserId = async (id) => {
    try {
      const users = await this.User.findAll({
        where: { id },
      });
      // console.log('조회한내용', users);
      return users;
    } catch (e) {
      console.log(e);
    }
  };

  updateUser = async (firstName, lastName, email, password, id) => {
    try {
      const users = await this.User.update(
        { firstName, lastName, email, password },
        { where: { id: id } }
      );
      return users;
    } catch (e) {
      console.log(e);
    }
  };

  findByEmail = async(email) =>{
    try{
      //select * from email = 'qwer';
      const user = await this.User.findOne({
        where : {email}
      })
      return user;
    }catch(e){
      console.log(e);
    }
  }
}
const us = new UserSequlize();
module.exports = us;

// 모델 동기화 (데이터베이스에 테이블 생성)
