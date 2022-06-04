using System;
using System.Collections.Generic;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing;

[TestClass]
public class TournamentTests
{
    private static readonly List<User> tmp = new();


    private readonly Tournament sampleTournament = new()
    {
        Description = "TournamentDescription",
        Gender = 0,
        Location = "some address 43",
        EndDate = DateTime.Now.AddDays(3),
        MaxPlayers = 7,
        MinPlayers = 3,
        SportType = sportTypes.Badminton,
        StartDate = DateTime.Now.AddDays(1),
        TournamentSystem = TournamentSystems.RoundRobin,
        Tournamnet_id = 1,
        Players = tmp
    };

    private readonly Tournament sampleTournament2 = new()
    {
        Description = "TournamentDescription",
        Gender = 0,
        Location = "some address 43",
        EndDate = DateTime.Now.AddDays(3),
        MaxPlayers = 7,
        MinPlayers = 3,
        SportType = sportTypes.Badminton,
        StartDate = DateTime.Now.AddDays(-3),
        TournamentSystem = TournamentSystems.RoundRobin,
        Tournamnet_id = 1
    };

    private readonly Tournament sampleTournament3 = new()
    {
        Description = "TournamentDescription",
        Gender = 0,
        Location = "some address 43",
        EndDate = DateTime.Now.AddDays(-3),
        MaxPlayers = 7,
        MinPlayers = 3,
        SportType = sportTypes.Badminton,
        StartDate = DateTime.Now.AddDays(-7),
        TournamentSystem = TournamentSystems.RoundRobin,
        Tournamnet_id = 1
    };


    [TestMethod]
    public void IsActiveTest()
    {
        //DateTime.Now > StartDate && DateTime.Now < EndDate
        Assert.IsFalse(sampleTournament.isActive());
        Assert.IsTrue(sampleTournament2.isActive());
    }

    [TestMethod]
    public void IsEndedTest()
    {
        //DateTime.Now < EndDate
        Assert.IsFalse(sampleTournament.isEnded());
        Assert.IsTrue(sampleTournament3.isEnded());
    }

    [TestMethod]
    public void IsGameStartableTest()
    {
        tmp.Add(new User());
        tmp.Add(new User());
        tmp.Add(new User());
        //MinPlayers <= Players.Count
        Assert.IsTrue(sampleTournament.isGameStartable());
        Assert.IsFalse(sampleTournament2.isGameStartable());
    }

    [TestMethod]
    public void TournamentWasCancelledTest()
    {
        //Players.Count < MinPlayers && isEnded() == true
        Assert.IsTrue(sampleTournament3.TournamentWasCancelled());
        Assert.IsFalse(sampleTournament.TournamentWasCancelled());
    }

    [TestMethod]
    public void ScheduleIsAvailableTest()
    {
        tmp.Add(new User());
        tmp.Add(new User());
        tmp.Add(new User());
        //MinPlayers <= Players.Count
        Assert.IsTrue(sampleTournament.ScheduleIsAvailable());
        Assert.IsFalse(sampleTournament2.ScheduleIsAvailable());
    }


    //add player & remove player have been tested in TournamentManagerTests
}