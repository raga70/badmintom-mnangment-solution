using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing;





[TestClass]
public class RoundRobinTests
{
    
    User user1 = new User()
    {
        username = "toni1",
        password = "xHhClrLu2fMgO9sTV8da9HuGhLQrULDEWhNBX9SjqSYzLrwR", //hashed+salted 1234
        email = "abc@ads.com",
        firstName = "toni",
        lastName = "kalapati",
        gender = 0,
        accType = AccTypes.Athlete,
        birthdayDate = DateTime.Now,
        phoneNumber = "078540432"
    };
    User user2 = new User()
    {
        username = "toni2",
        password = "xHhClrLu2fMgO9sTV8da9HuGhLQrULDEWhNBX9SjqSYzLrwR", //hashed+salted 1234
        email = "abc@ads.com",
        firstName = "toni",
        lastName = "kalapati",
        gender = 0,
        accType = AccTypes.Athlete,
        birthdayDate = DateTime.Now,
        phoneNumber = "078540432"
    };
    User user3 = new User()
    {
        username = "toni3",
        password = "xHhClrLu2fMgO9sTV8da9HuGhLQrULDEWhNBX9SjqSYzLrwR", //hashed+salted 1234
        email = "abc@ads.com",
        firstName = "toni",
        lastName = "kalapati",
        gender = 0,
        accType = AccTypes.Athlete,
        birthdayDate = DateTime.Now,
        phoneNumber = "078540432"
    };

    User user4 = new User()
    {
        username = "toni4",
        password = "xHhClrLu2fMgO9sTV8da9HuGhLQrULDEWhNBX9SjqSYzLrwR", //hashed+salted 1234
        email = "abc@ads.com",
        firstName = "toni",
        lastName = "kalapati",
        gender = 0,
        accType = AccTypes.Athlete,
        birthdayDate = DateTime.Now,
        phoneNumber = "078540432"
    };
    
    private static List<User> players = new();

   

     static Tournament sampleTournament = new Tournament()
    {
        Description = "TournamentDescription",
        Gender = 0,
        Location = "some address 43",
        EndDate = DateTime.Now.AddDays(3),
        MaxPlayers = 7,
        MinPlayers = 3,
        SportType = sportTypes.Badminton,
        StartDate = DateTime.Now,
        TournamentSystem = TournamentSystems.RoundRobin,
        Tournamnet_id = 1,
        Players = players
    };


     private TournamentInPlay Tournament = new TournamentRR(sampleTournament);



     [TestMethod]
     public void TestUnevenPlayers()
     {
         players.Add(user1);
         players.Add(user2);
         players.Add(user3);

         List <Fight> fights = new();

         foreach (var r in Tournament.AllRounds)
         {
             fights.AddRange(r.Fights);
         }
         
         var s =  fights.Select( f => f.Player1.Player).Distinct();
         var s2 =  fights.Select( f => f.Player2.Player).Distinct();
         Assert.IsTrue(validate(fights,players));
         
     }
     [TestMethod]
     public void TestEvenPlayers()
     {
         players.Add(user1);
         players.Add(user2);
         players.Add(user3);
         players.Add(user4);

         List <Fight> fights = new();

         foreach (var r in Tournament.AllRounds)
         {
             fights.AddRange(r.Fights);
         }
         
       
         Assert.IsTrue(validate(fights,players));
         
     }

    
     bool validate(List<Fight> fights, List<User> users) 
     {
         foreach (var user in users)
         {
             List<User> allUsersExceptThisOne = new();
             allUsersExceptThisOne.AddRange(users);
             allUsersExceptThisOne.Remove(user);
                foreach (var fight in fights)  //check if all users are in the fights and fight eachother 
                {
                    if (fight.Player1.Player == user)
                    {
                        if (!allUsersExceptThisOne.Contains(fight.Player2.Player))
                        {
                            return false;
                        }
                    }
                    else if (fight.Player2.Player == user)
                    {
                        if (!allUsersExceptThisOne.Contains(fight.Player1.Player))
                        {
                            return false;
                        }
                    }
                    
                    
                }
                    //check that nobody fights himself
                   if(fights.Any(f => f.Player1.Player == user && f.Player2.Player == user))
                   {
                       return false;
                   }
                
                
                
                
                
         }
         return true;
     }
     
     


}