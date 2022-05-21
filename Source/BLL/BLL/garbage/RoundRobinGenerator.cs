// using BLL;
// using Entities;
//
// namespace BLL;
//
// public class RoundRobinGenerator : TournamentSystemGenerator
// {
//     public RoundRobinGenerator(Tournament t) : base(t)
//     {
//     }
//
//
//     public override List<Round> CreteSchedule(List<Round> nu)
//     {
//         if (_players.Count() <= 1) return null;
//         var rounds = new List<Round>();
//         var athletes = new List<GamePlayer>();
//
//         athletes.AddRange(_players);
//         athletes.RemoveAt(0); // i will deal with the first player separately 
//         //round
//         for (var i = 0; i < _players.Count - 1; i++)
//         {
//             var r = new Round()
//             {
//                 RoundNumber = i + 1,
//                 Fights = new List<Fight>()
//             };
//             //fights with the first athlete , which we skip to add in athletes collection
//             var playerIdx = i % athletes.Count;
//             bool firstFightIsB;
//             if (athletes[playerIdx].isB || _players[0].isB)
//             {
//                 firstFightIsB = true;
//             }
//             else
//             {
//                 firstFightIsB = false;
//                 r.Fights.Add(new Fight()
//                 {
//                     id = 0, isB = firstFightIsB, Player1 = new GamePlayer(athletes[playerIdx]),
//                     Player2 = new GamePlayer(_players[0])
//                 });
//             }
//
//             //the rest of the fights   
//             for (var j = 1; j < _players.Count / 2; j++)
//             {
//                 var
//                     firstFighterIndex =
//                         (i + j) % athletes
//                             .Count; //round + iteration shifts the positions in increasing direction with one, the integer leftover division loops over to the first one when we go out of range of the collection  
//                 var secondFighterIndex =
//                     (i + athletes.Count - j) % athletes.Count; // direction is reversed (decreasing)
//                 bool fighthIsB;
//                 if (athletes[firstFighterIndex].isB || athletes[secondFighterIndex].isB)
//                 {
//                     fighthIsB = true;
//                 }
//                 else
//                 {
//                     fighthIsB = false;
//                     r.Fights.Add(new Fight()
//                     {
//                         id = j, isB = fighthIsB, Player1 = athletes[firstFighterIndex],
//                         Player2 = athletes[secondFighterIndex]
//                     });
//                 }
//             }
//
//             rounds.Add(r);
//         }
//
//         return rounds;
//     }
// }