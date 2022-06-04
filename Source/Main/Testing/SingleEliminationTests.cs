using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing;

[TestClass]
public class SingleEliminationTests
{
    private static readonly List<User> players = new();


    private static readonly Tournament sampleTournament = new()
    {
        Description = "TournamentDescription",
        Gender = 0,
        Location = "some address 43",
        EndDate = DateTime.Now.AddDays(3),
        MaxPlayers = 7,
        MinPlayers = 3,
        SportType = sportTypes.Badminton,
        StartDate = DateTime.Now,
        TournamentSystem = TournamentSystems.SingleElimination,
        Tournamnet_id = 1,
        Players = players
    };


    private readonly TournamentInPlay Tournament = new TournamentSE(sampleTournament);

    private readonly User user1 = new()
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

    private readonly User user2 = new()
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

    private readonly User user3 = new()
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

    private readonly User user4 = new()
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


    [TestMethod]
    public void testPlayersOnThePowerOf2_firstRound()
    {
        players.Add(user1);
        players.Add(user2);
        players.Add(user3);
        players.Add(user4);

        List<Fight> fights = new();

        foreach (var r in Tournament.AllRounds) fights.AddRange(r.Fights);


        Assert.IsTrue(validate(fights, players));
    }


    [TestMethod]
    public void testPlayersOnThePowerOf2_secondRound()
    {
        players.Add(user1);
        players.Add(user2);
        players.Add(user3);
        players.Add(user4);

        var method = Tournament.GetType().GetMethod("CreteSchedule", BindingFlags.NonPublic | BindingFlags.Instance);

        var Round1n2 = method.Invoke(Tournament, new object[] { Tournament.AllRounds.ToList() });

        List<Fight> fights = new();


        Assert.IsTrue(((List<Round>)Round1n2).Last().Fights.Count == 1);
    }


    private bool validate(List<Fight> fights, List<User> users)
    {
        foreach (var user in users)
        {
            List<User> allUsersExceptThisOne = new();
            allUsersExceptThisOne.AddRange(users);
            allUsersExceptThisOne.Remove(user);

            //check that nobody fights himself
            if (fights.Any(f => f.Player1.Player == user && f.Player2.Player == user)) return false;

            //check that everybody fights only once 
            if (fights.Count(f => f.Player1.Player == user || f.Player2.Player == user) > 1) return false;
        }

        return true;
    }
}