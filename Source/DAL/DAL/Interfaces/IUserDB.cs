using Entities;

namespace DAL;

public interface IUserDB
{
    bool AddUser(User user);
    User GetUser(string username);
    List<User> GetAllUsers();
}