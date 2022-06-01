using System;
using System.Collections.Generic;
using System.Linq;
using BLL;
using DAL;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{

    public class mocUserDB : IUserDB
    {
        public bool AddUser(User user)
        {
            return true;
        }

        public User GetUser(string username)
        {
            return null;
        }

        public List<User> GetAllUsers()
        {
            return null;
        }
    }

    [TestClass]
    public class UserManagerTests
    {
        private UserManager um = new UserManager(new mocUserDB());

        User sampleUser = new User()
        {
            username = "toni",
            password = "xHhClrLu2fMgO9sTV8da9HuGhLQrULDEWhNBX9SjqSYzLrwR", //hashed+salted 1234
            email = "abc@ads.com",
            firstName = "toni",
            lastName = "kalapati",
            gender = 0,
            accType = AccTypes.Athlete,
            birthdayDate = DateTime.Now,
            phoneNumber = "078540432"
        };



        [TestMethod]
        public void RegisterUser()
        {

            um.RegisterUser(sampleUser); //check if the user is added to the collection
            Assert.AreEqual(um.AllUsers.ToList()[0], sampleUser);
            Assert.IsFalse(um.RegisterUser(sampleUser)); //check if registering the same user twice returns false
            Assert.IsTrue(um.AllUsers.Count ==
                          1); // double check that the same user actually does not get added to the collection 
        }

        [TestMethod]
        public void LoginUser()
        {
            um.RegisterUser(sampleUser);
            Assert.IsTrue(um.Login(sampleUser.username, "1234")); //test the login method with the right pass
            Assert.IsFalse(um.Login(sampleUser.username, "123")); //test the login method with the wrong pass
        }




    }
}