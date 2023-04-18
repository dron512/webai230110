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
    });
    this.User.sync()
      .then(() => {
        console.log('User 모델이 데이터베이스와 동기화되었습니다.');
      })
      .catch((err) => {
        console.error('동기화 오류:', err);
      });
  }
  createUser = async (firstName, lastName, email) => {
    try {
      //insert into users values (firstname,lastname,email)
      const user = await this.User.create({ firstName, lastName, email });
      console.log('행을 삽입했습니다', user);
    } catch (e) {
      console.log(e);
    }
  };
  selectUser = async () => {
    try {
      // select * from uesrs
      const users = await this.User.findAll({
        order: [['id', 'DESC']],
      });
      console.log('조회한내용', users);
      return users;
    } catch (e) {
      console.log(e);
    }
  };
}
const us = new UserSequlize();
module.exports = us;

// 모델 동기화 (데이터베이스에 테이블 생성)
