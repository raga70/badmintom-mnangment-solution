using System;
using BLL;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing;

[TestClass]
public class TornamentManagerTests
{
    private readonly Tournament nonValidTournament = new()
    {
        Description = "TournamentDescription",
        Gender = 0,
        Location = "",
        EndDate = DateTime.Now.AddDays(3),
        MaxPlayers = 7,
        MinPlayers = 3,
        SportType = sportTypes.Badminton,
        StartDate = DateTime.Now,
        TournamentSystem = TournamentSystems.RoundRobin
    };

    private readonly Tournament sampleTournament = new()
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
        Tournamnet_id = 1
    };

    private readonly User sampleUser = new()
    {
        username = "toni",
        password = "xHhClrLu2fMgO9sTV8da9HuGhLQrULDEWhNBX9SjqSYzLrwR", //hashed+salted 1234
        email = "abc@ads.com",
        firstName = "toni",
        lastName = "kalapati",
        gender = 0,
        accType = AccTypes.Athlete,
        birthdayDate = DateTime.Now,
        phoneNumber = "078540432"
    };

    private readonly TournamentManager tm = new(new tournamentDBMock());

    [TestMethod]
    public void AddTournamentTest()
    {
        tm.AddTournament(sampleTournament);
        Assert.AreEqual(sampleTournament, tm.AllTournaments[0]);
        tm.AddTournament(nonValidTournament);
        Assert.IsTrue(tm.AllTournaments.Count ==
                      1); //check the the second row of protection works and the tournament doesnt get added
    }

    [TestMethod]
    public void DeleteTournamentTest()
    {
        tm.AddTournament(sampleTournament);
        tm.DeleteTournament(sampleTournament);
        Assert.IsTrue(tm.AllTournaments.Count == 0);
    }

    [TestMethod]
    public void UpdateTournamentTest()
    {
        tm.AddTournament(sampleTournament);
        var secTournament = new Tournament
        {
            Description = "hello",
            Gender = 1,
            Location = "some other address 43",
            EndDate = DateTime.Now.AddDays(4),
            MaxPlayers = 8,
            MinPlayers = 3,
            SportType = sportTypes.Badminton,
            StartDate = DateTime.Now,
            TournamentSystem = TournamentSystems.RoundRobin,
            Tournamnet_id = 1
        };

        tm.UpdateTournament(secTournament);
        Assert.AreEqual(secTournament, tm.AllTournaments[0]);
    }

    [TestMethod]
    public void AddPlayerToTournamentTest()
    {
        tm.AddTournament(sampleTournament);
        tm.AddPlayerToTournament(sampleTournament, sampleUser);
        Assert.AreEqual(tm.AllTournaments[0].Players[0], sampleUser);
        tm.AddPlayerToTournament(sampleTournament, sampleUser); //try to add the same user twice
        Assert.IsTrue(sampleTournament.Players.Count == 1);
    }

    [TestMethod]
    public void RemovePlayerFromTournamentTest()
    {
        tm.AddTournament(sampleTournament);
        tm.AddPlayerToTournament(sampleTournament, sampleUser);
        tm.RemovePlayerFromTournament(sampleTournament, sampleUser);
        Assert.IsTrue(sampleTournament.Players.Count == 0);
    }

    [TestMethod]
    public void GetTournamentByIDTest()
    {
        tm.AddTournament(sampleTournament);
        Assert.AreEqual(tm.GetTournamentByID(1), sampleTournament);
    }
}