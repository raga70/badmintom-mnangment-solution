using DAL;
using Entities;

namespace BLL;

public class UserManager
{
    private readonly IGameDB gameDB;


    private readonly IUserDB userDB;
    private List<User> users = new();

    public UserManager(IUserDB passed)
    {
        userDB = passed;
    }

    public UserManager(IUserDB passed, IGameDB passeGameDb)
    {
        userDB = passed;
        gameDB = passeGameDb;
    }

    public IList<User> AllUsers
    {
        get
        {
            if (users.Count == 0) UpdateAllUsers();
            return users.AsReadOnly();
        }
    }


    public void UpdateAllUsers()
    {
        users.Clear();
        users = userDB.GetAllUsers();
    }


    //this method is created to not over-query the database unnecessarily on each OnPost/OnGet
    public User GetUser(string username)
    {
        if(users.FirstOrDefault(x => x.username == username) is { } user)
        {
            return user;
        }
        else
        {
            return userDB.GetUser(username);
        }
    }

    public bool RegisterUser(User user)
    {
        if (users.Count != 0)
            foreach (var u in users)
                if (u.username == user.username)
                    return false;
        ///cannot unit testing without mock data
        if (!userDB.AddUser(user)) return false;

        users.Add(user);
        return true;
    }

    public bool Login(string username, string pass)
    {
        string hashedPass = null;

        if (users is not null)
            foreach (var u in users)
                if (u.username == username)
                    hashedPass = u.password;
        //double check with db
        if (hashedPass is null)
        {
            var u = userDB.GetUser(username);
            if (u is null) return false;
            hashedPass = u.password;
        }


        return passwordHashing.Validate(pass, hashedPass);
    }


    public List<GameResultData> GetPlayerProfiler(User user)
    {
        return gameDB.GetPlayerProfiler(user);
    }
}