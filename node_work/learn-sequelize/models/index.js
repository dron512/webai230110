const Sequelize = require('sequelize');
const User = require('./user');
const Comment = require('./comment');

const env = process.env.NODE_ENV || 'development';
const config = require('../config/config')[env];
const db = {};

const sequelize = new Sequelize(config.database, config.username, config.password, config);

db.sequelize = sequelize;

db.User = User;
db.Comment = Comment;

// fs *.js model -> associate

// 정의 하는 부분
User.initiate(sequelize);
Comment.initiate(sequelize);

// 관계 형성을 하게 되는 부분
User.associate(db);
Comment.associate(db);

module.exports = db;