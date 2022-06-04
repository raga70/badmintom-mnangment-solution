using System.Collections.Generic;
using DAL;
using Entities;

namespace Testing;

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