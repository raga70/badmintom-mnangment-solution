using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DataAcess;
using Entities;
namespace BLL
{
    public class UserManager
    {
        private List<User> users  = new List<User>();

        public  IList<User> AllUsers { 
            get
            {
            if(users.Count ==0)UpdateAllUsers();
            return users.AsReadOnly();
            }

        }

        

        private UserDB userDB; 
        public UserManager()
        {
             userDB = new UserDB();
        }


        public void UpdateAllUsers()
        {
            users.Clear();
            users = userDB.GetAllUsers();
        }


        //this method is created to not over-query the database unnecessarily on each OnPost/OnGet
        public User GetUser(string username)
        {
            
            return userDB.GetUser(username);
           
        }

        public bool RegisterUser(User user)
        {
            if(users.Count != 0) foreach (var u in users)
            {
                if(u.username == user.username)
                {
                    return false;
                }
            } 
            ///cannot unit testing without mock data
            if(!userDB.AddUser(user))return false;
            
            users.Add(user);
            return true;
        }

        public bool Login(string username, string pass)
        {
            passwordHashing passwordHashing = new passwordHashing(); //convert ot static maybe
            
            string hashedPass= null;
           
           if(users is not null) foreach (var u in users)
            {
                if(u.username== username)hashedPass = u.password;
            }
             //double check with db
             if (hashedPass is null)
             {
                 User u = userDB.GetUser(username);
                 if (u is null) return false;
                 hashedPass =  u.password;
             }
             
             
            return passwordHashing.Validate(pass, hashedPass);
        }

    }
}
