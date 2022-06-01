using System;
using System.Collections.Generic;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing;

[TestClass]
public class TournamentExecutionTests
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
     public void UpdateGame()
     {
         players.Add(user1);
         players.Add(user2);
         players.Add(user3);
         var rounds = Tournament.AllRounds; //invoke the creation of the rounds
         
         Tournament.UpdatePlayerScore(rounds[0],rounds[0].Fights[0], 21,5);
         Tournament.UpdatePlayerScore(rounds[1],rounds[1].Fights[0], 30,29);
         Tournament.UpdatePlayerScore(rounds[2],rounds[2].Fights[0], 27,25);

         Exception Ex = null;
         try
         {
             Tournament.UpdateGame();
         }
         catch (Exception ex)
         {
             Ex = ex;
         }
         Assert.IsTrue(Ex is null);
         
         
         Tournament.UpdatePlayerScore(rounds[0],rounds[0].Fights[0], 7,5);
         Tournament.UpdatePlayerScore(rounds[1],rounds[1].Fights[0], 31,29);
         Tournament.UpdatePlayerScore(rounds[2],rounds[2].Fights[0], 97,25);
         try
         {
             Tournament.UpdateGame();
         }
         catch (Exception ex)
         {
             Ex = ex;
         }
         Assert.IsTrue(Ex is not null);
         
     }
     
     [TestMethod]
     public void UpdatePlayerScore()
     {
         players.Add(user1);
         players.Add(user2);
         players.Add(user3);
         var r = Tournament.AllRounds[0]; //invoke the creation of the rounds
         
         Tournament.UpdatePlayerScore(r,r.Fights[0], 21,5);
         Assert.IsTrue(r.Fights[0].Player1.Score == 21 && r.Fights[0].Player2.Score == 5);
     }
     
     
     
     
}