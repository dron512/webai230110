'use strict';
const { Model } = require('sequelize');
module.exports = (sequelize, DataTypes) => {
  class Text extends Model {
    static associate(models) {
      this.belongsTo(models.User);
    }
  }
  Text.init(
    {
      message: DataTypes.STRING,
    },
    {
      sequelize,
      modelName: 'Text',
    }
  );
  return Text;
};