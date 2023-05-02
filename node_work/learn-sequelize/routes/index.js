const exrpess = require("express");
const {User} = require('../models');
const router = exrpess.Router();

router.get("/", async(req, res) => {
  const users = await User.findAll();
  res.render("sequelize", { users });
});

module.exports = router;
