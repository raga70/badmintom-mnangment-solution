// using Entities;
//
// namespace BLL;
//
// public class SingleEliminationGenerator : TournamentSystemGenerator
// {
//     public SingleEliminationGenerator(Tournament t) : base(t)
//     {
//     }
//
//     private Round CreteFirstRound()
//     {
//         var players = new List<GamePlayer>();
//         players.AddRange(_players);
//
//         var _isB = false;
//         var fights = new List<Fight>();
//         for (var i = 0; i < _players.Count / 2; i++)
//         {
//             if (players[players.Count - 1].isB == true || players[players.Count - 2].isB == true) _isB = true;
//             else
//                 _isB = false;
//
//             var f = new Fight()
//                 { Player1 = players[players.Count - 2], Player2 = players[players.Count - 1], isB = _isB, id = i };
//             players.RemoveAt(players.Count - 1);
//             players.RemoveAt(players.Count - 1);
//             fights.Add(f);
//         }
//
//         return new Round() { Fights = fights, RoundNumber = 1 };
//     }
//
//     public override List<Round> CreteSchedule(List<Round> rounds)
//     {
//         if (rounds is null)
//         {
//             rounds = new List<Round>();
//             rounds.Add(CreteFirstRound());
//         }
//         else
//         {
//             //if there is only one player dont generate a new round 
//
//             var players = new List<GamePlayer>();
//
//             foreach (var f in rounds[rounds.Count - 1].Fights)
//                 //bogus player fight auto win 
//                 if (f.Player1.isB == true)
//                     players.Add(f.Player2);
//                 else if (f.Player2.isB == true)
//                     players.Add(f.Player1);
//
//                 else if (f.Player1.Score > f.Player2.Score)
//                     players.Add(f.Player1);
//                 else
//                     players.Add(f.Player2);
//
//             if (players.Count > 1)
//             {
//                 var _isB = false;
//                 var fights = new List<Fight>();
//                 for (var i = 0; i < players.Count / 2; i++)
//                 {
//                     if (players[players.Count - 1].isB == true || players[players.Count - 2].isB == true) _isB = true;
//                     else
//                         _isB = false;
//                     var f = new Fight()
//                     {
//                         Player1 = players[players.Count - 2], Player2 = players[players.Count - 1], isB = _isB, id = i
//                     };
//                     players.RemoveAt(players.Count - 1);
//                     players.RemoveAt(players.Count - 1);
//                     fights.Add(f);
//                 }
//
//                 rounds.Add(new Round() { Fights = fights, RoundNumber = rounds.Count + 1 });
//             }
//         }
//
//         return rounds;
//     }
// }