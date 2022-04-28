using Entities.DTO;
namespace Entities
{
    public record User
    {
        public string username { get;init; }
        public string password { get;init; }
        public string firstName { get;init; }
        public string lastName { get;init; }
        public DateTime birthdayDate { get;init; }
        public int gender { get; init; }
        public string email { get;init; }
        public string phoneNumber { get; init; }

        public AccTypes accType;

       
        public User(){}
        
        
        public User(Register r)
        {  //no data validation needed (it`s already validated in Register)
            this.username = r.username;
            this.password = r.password;
            this.firstName = r.firstName;
            this.lastName = r.lastName;
            this.birthdayDate =Convert.ToDateTime(r.birthdayDate);
            this.gender = r.gender;
            this.email = r.email;
            this.phoneNumber = r.phoneNumber;
            this.accType = AccTypes.Athlete;
        }
    }
}