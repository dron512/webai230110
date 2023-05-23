const Sequelize = require('sequelize');
const User = require('./user');
const Comment = require('./comment');
const env = process.env.NODE_ENV || 'development';
console.log(`env ${env}`);
// const config = require('../config/config').development;
const config = require('../config/config')['development'];
const db = {};

const sequelize = new Sequelize(config.database, config.username, config.password, config);

db.sequelize = sequelize;

db.User = User;
db.Comment = Comment;

// 정의 하는 부분
User.initiate(db.sequelize);
Comment.initiate(db.sequelize);

// 관계 형성을 하게 되는 부분
User.associate(db);
Comment.associate(db);

module.exports = db;