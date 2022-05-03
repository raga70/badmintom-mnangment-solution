﻿ using BLL;
 using Entities;

 namespace BLL;
 
 
 
 





 public class RoundRobin : ITournamentSystemManager
 {
     private List<User> tournamentPlayers;
     private int round =0;
     private List<GamePlayer> _players = new List<GamePlayer>();

     
     public RoundRobin(Tournament t)
     {
         tournamentPlayers = t.Players;
     }

     public void Initializer()
     {
         for (int i = 0; i < tournamentPlayers.Count; i++)
         {
             if (i == 0 && tournamentPlayers.Count % 2 == 1)
             {
                 _players.Add(new GamePlayer() { id = i, Player = null, Score = 0, isB = true });
             }

             _players.Add(new GamePlayer() { id = i, Player = tournamentPlayers[i], Score = 0, isB = false });
         }
     }


     public List<Round> CreteSchedule()
      {
          List <Round> rounds  = new List<Round>();
         List<GamePlayer> athletes = new List<GamePlayer>();
         
         athletes.AddRange(_players);
         athletes.RemoveAt(0); // i will deal with the first player separately 
        
         //round
         for (int i = 0; i < _players.Count-1; i++)
         {
             Round r = new Round();
             r.RoundNumber = i + 1;
             r.Fights = new List<Fight>();
             //fights with the first athlete , which we skip to add in athletes collection
             int playerIdx = i % athletes.Count;
             bool firstFightIsB;
             if (athletes[playerIdx].isB || _players[0].isB) firstFightIsB = true;
             else firstFightIsB = false; 
             r.Fights.Add(new Fight(){id =0,isB = firstFightIsB,Player1 = athletes[playerIdx],Player2 = _players[0]});
             
             
             //the rest of the fights   
             for (int j = 1; j < _players.Count/2; j++)
             {               
                 int firstFighterIndex = (i + j) % athletes.Count; //round + iteration shifts the positions in increasing direction with one, the integer leftover division loops over to the first one when we go out of range of the collection  
                 int secondFighterIndex = (i  + athletes.Count - j) % athletes.Count; // direction is reversed (decreasing)
                 bool fighthIsB;
                 if (athletes[firstFighterIndex].isB || _players[secondFighterIndex].isB) fighthIsB = true;
                 else fighthIsB = false; 
                 r.Fights.Add(new Fight(){id = j,isB = fighthIsB,Player1 = athletes[firstFighterIndex],Player2 = athletes[secondFighterIndex]});
             }
             rounds.Add(r);
         }

         return rounds;
      }
     
     
     
     
     
     
     
     
     // public List<Round> createRoundSchedule()
     // {
     //     
     //    
     //     
     //     List<GamePlayer> topRow = new List<GamePlayer>();
     //     List<GamePlayer> bottomRow = new List<GamePlayer>();
     //     List<Round> rounds = new List<Round>();
     //     
     //     ///loop
     //     
     //     for (int i = 0; i <= _players.Count /2 ; i++)
     //     {
     //         topRow.Add(_players[i]);
     //     }  
     //     for (int i = _players.Count; i > _players.Count / 2; i--)
     //     {
     //         bottomRow.Add(_players[i]);
     //     }
     //     
     //     
     //     ///crete first round
     //     for (int i = 0; i < _players.Count / 2; i++)
     //     {
     //         Round r = new Round();
     //         r.RoundNumber = i;
     //         r.Fights = new List<Fight>();
     //         for (int j = 0; j < topRow.Count; j++)
     //         {
     //             Fight f = new Fight();
     //             f.id = j;
     //             f.Player1 = topRow[j];
     //             f.Player2 = bottomRow[j];
     //             f.Score1 = 0;
     //             f.Score2 = 0;
     //             f.isB = false;
     //             r.Fights.Add(f);
     //         }
     //         rounds.Add(r);
     //         //rotate players to fight different players, every player needs to fight every other player
     //         
     //         
     //         
     //         
     //     }
     //     
     //     //rotate players
     //         GamePlayer temp = topRow[0]; //dont move this
     //         List<GamePlayer> tempTopRow = new List<GamePlayer>();
     //         List<GamePlayer> tempBottomRow = new List<GamePlayer>();
     //         
     //         for (int i = 0; i < _players.Count -1; i++)
     //     {   
     //         
     //     }
     //     
     //     
     //     
     // }

 }