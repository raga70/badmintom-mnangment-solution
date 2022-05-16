namespace DAL;
using Entities;
public interface IUserDB
{
    bool AddUser(User user);
    User GetUser(string username);
    List<User> GetAllUsers();
}