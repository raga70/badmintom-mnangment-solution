using System;
using System.Collections.Generic;
using BLL;
using DAL;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing;

public class tournamentDBMock : ITournamentDB
{
    public void AddTournament(Tournament tournament)
    {
        
    }

    public void UpdateTournament(Tournament tournament)
    {
        
    }

    public void DeleteTournament(Tournament tournament)
    {
        
    }

    public List<Tournament> GetAllTournaments()
    {
        return new List<Tournament>();
    }

    public void AddPlayerToTournament(Tournament tournament, User player)
    {
        
    }

    public void RemovePlayerFromTournament(Tournament tournament, User player)
    {
        
    }
}



[TestClass]
public class TornamentManagerTests
{
    private TournamentManager tm = new TournamentManager(new tournamentDBMock());
    
    Tournament sampleTournament = new Tournament()
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
    Tournament nonValidTournament = new Tournament()
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
    
    User sampleUser = new User()
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
    
    [TestMethod]
    public void AddTournamentTest()
    {
        
        tm.AddTournament(sampleTournament);
        Assert.AreEqual(sampleTournament, tm.AllTournaments[0]);
        tm.AddTournament(nonValidTournament); 
        Assert.IsTrue(tm.AllTournaments.Count == 1); //check the the second row of protection works and the tournament doesnt get added
        
    }    
    
    [TestMethod]
    public void DeleteTournamentTest()
    {
        tm.AddTournament(sampleTournament);
        tm.DeleteTournament(sampleTournament);
        Assert.IsTrue(tm.AllTournaments.Count == 0);
    }
    
    [TestMethod]
    public  void UpdateTournamentTest()
    {
        tm.AddTournament(sampleTournament);
        Tournament secTournament = new Tournament()
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
        Assert.AreEqual(tm.AllTournaments[0].Players[0],sampleUser);
        tm.AddPlayerToTournament(sampleTournament, sampleUser);//try to add the same user twice
        Assert.IsTrue(sampleTournament.Players.Count == 1);
    }
    [TestMethod]
    public void RemovePlayerFromTournamentTest()
    {
        tm.AddTournament(sampleTournament);
        tm.AddPlayerToTournament(sampleTournament, sampleUser);
        tm.RemovePlayerFromTournament(sampleTournament,sampleUser);
        Assert.IsTrue(sampleTournament.Players.Count == 0);
    }

    [TestMethod]
    public void GetTournamentByIDTest()
    {
        tm.AddTournament(sampleTournament);
        Assert.AreEqual(tm.GetTournamentByID(1), sampleTournament);
    }



}