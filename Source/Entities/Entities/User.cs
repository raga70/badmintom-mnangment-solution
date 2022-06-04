using Entities.DTO;

namespace Entities;

public class User
{
    //only used for game 
    private int _points;

    public User()
    {
    }


    public User(Register r)
    {
        //no data validation needed (it`s already validated in Register)
        username = r.username;
        password = r.password;
        firstName = r.firstName;
        lastName = r.lastName;
        birthdayDate = Convert.ToDateTime(r.birthdayDate);
        gender = r.gender;
        email = r.email;
        phoneNumber = r.phoneNumber;
        accType = AccTypes.Athlete;
    }

    public string username { get; init; }
    public string password { get; init; }
    public string firstName { get; init; }
    public string lastName { get; init; }
    public DateTime birthdayDate { get; init; }
    public int gender { get; init; }
    public string email { get; init; }
    public string phoneNumber { get; init; }

    public AccTypes accType { get; init; }


    public int id { get; init; }

    public int points
    {
        get => _points;
        init => _points = value;
    }

    public void IncresePoints()
    {
        _points++;
    }
}