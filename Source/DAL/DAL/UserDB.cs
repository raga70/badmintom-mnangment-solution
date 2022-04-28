﻿using Entities;
using MySql.Data.MySqlClient;
using RealizationProvider;

namespace DAL
{
    public class UserDB
    {
        public bool AddUser(User user)
        {
            MySqlConnection mysql = new MySqlConnection(Connection.conString);
            try
            {
                mysql.Open();
                MySqlCommand cmd1 = mysql.CreateCommand();
                cmd1.CommandText = "SELECT username FROM users WHERE username = @username";
                cmd1.Parameters.AddWithValue("@username", user.username);
               
               if (cmd1.ExecuteScalar() is not null) return false;
                MySqlCommand command = mysql.CreateCommand();
                command.CommandText =
                    ("INSERT INTO users (username,password,firstName,lastName,birthdayDate,gender,email,phoneNumber,accType) VALUES (@user, @pass, @fname, @lname, @bDate,@gender,@email,@phoneNumber,@accType)");
                command.Parameters.AddWithValue("@user", user.username);
                command.Parameters.AddWithValue("@pass", user.password);
                command.Parameters.AddWithValue("@fname", user.firstName);
                command.Parameters.AddWithValue("@lname", user.lastName);
                command.Parameters.AddWithValue("@bDate", user.birthdayDate.ToString(format:"yyyy-MM-dd"));
                command.Parameters.AddWithValue("@gender", user.gender);
                command.Parameters.AddWithValue("@email", user.email);
                command.Parameters.AddWithValue("@phoneNumber", user.phoneNumber);
                command.Parameters.AddWithValue("accType", user.accType.ToString());

                command.ExecuteNonQuery();
            }
            finally
            {
                mysql.Close();
            }

            return true;
        }


        public User GetUser(string username)
        {
            MySqlConnection mysql = new MySqlConnection(Connection.conString);

            try
            {
                mysql.Open();
                MySqlCommand cmd1 = mysql.CreateCommand();
                MySqlCommand command = mysql.CreateCommand();
                command.CommandText = ("SELECT * FROM users WHERE username = @username");
                command.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        username = reader.GetString("username"),
                        password = reader.GetString("password"),
                        firstName = reader.GetString("firstName"),
                        lastName = reader.GetString("lastName"),
                        birthdayDate = reader.GetDateTime("birthdayDate"),
                        gender = reader.GetInt32("gender"),
                        email = reader.GetString("email"),
                        phoneNumber = reader.GetString("phoneNumber"),
                        accType = Enum.Parse<AccTypes>(reader.GetString("accType"))
                    };
                }

                return null;

            }
            finally
            {
                mysql.Close();
            }
        }





        public List<User> GetAllUsers()
        {
            List<User> uList = new List<User>();
            MySqlConnection mysql = new MySqlConnection(Connection.conString);

            try
            {
                mysql.Open();
                MySqlCommand command = mysql.CreateCommand();
                command.CommandText = ("SELECT * FROM users ");
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    uList.Add( new User
                    {
                        username = reader.GetString("username"),
                        password = reader.GetString("password"),
                        firstName = reader.GetString("firstName"),
                        lastName = reader.GetString("lastName"),
                        birthdayDate = reader.GetDateTime("birthdayDate"),
                        gender = reader.GetInt32("gender"),
                        email = reader.GetString("email"),
                        phoneNumber = reader.GetString("phoneNumber"),
                        accType = Enum.Parse<AccTypes>(reader.GetString("accType"))
                    });
                }


                return uList;
            }
            finally
            {
                mysql.Close();
            }
        }







    }
}