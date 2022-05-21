using Entities;
using MySql.Data.MySqlClient;
using RealizationProvider;

namespace DAL;

public class GameDB : IGameDB
{
    public void PushTournament(Tournament t, List<Round> rounds)
    {
        var mysql = new MySqlConnection(Connection.conString);
        try
        {
            mysql.Open();
            foreach (var p in t.Players)
            {
                var cmd = new MySqlCommand(
                    "INSERT INTO  gameResults(tournament_id, player_id, points) VALUES (@tournament_id, @player_id, @points  ) ON DUPLICATE KEY UPDATE tournament_id = @tournament_id, player_id = @player_id",
                    mysql);
                cmd.Parameters.AddWithValue("@tournament_id", t.Tournamnet_id);
                cmd.Parameters.AddWithValue("@player_id", p.id);
                cmd.Parameters.AddWithValue("@points", p.points);

                cmd.ExecuteNonQuery();
            }

            foreach (var r in rounds)
            foreach (var f in r.Fights)
                if (f.isB == false)
                {
                    var cmd = new MySqlCommand(
                        "INSERT INTO  gameFights(tournament_id, player_id, fightScore, oponent_id) VALUES (@tournament_id, @player_id, @fightScore, @oponent_id  )ON DUPLICATE KEY UPDATE tournament_id = @tournament_id, player_id = @player_id,oponent_id = @oponent_id",
                        mysql);
                    cmd.Parameters.AddWithValue("@tournament_id", t.Tournamnet_id);
                    cmd.Parameters.AddWithValue("@player_id", f.Player1.Player.id);
                    cmd.Parameters.AddWithValue("@fightScore", $"{f.Player1.Score}:{f.Player2.Score}");
                    cmd.Parameters.AddWithValue("@oponent_id", f.Player2.Player.id);
                    cmd.ExecuteNonQuery();

                    var cmd1 = new MySqlCommand(
                        "INSERT INTO  gameFights(tournament_id, player_id, fightScore, oponent_id) VALUES (@tournament_id, @player_id, @fightScore, @oponent_id  )ON DUPLICATE KEY UPDATE tournament_id = @tournament_id, player_id = @player_id,oponent_id = @oponent_id",
                        mysql);
                    cmd1.Parameters.AddWithValue("@tournament_id", t.Tournamnet_id);
                    cmd1.Parameters.AddWithValue("@player_id", f.Player2.Player.id);
                    cmd1.Parameters.AddWithValue("@fightScore", $"{f.Player2.Score}:{f.Player1.Score}");
                    cmd1.Parameters.AddWithValue("@oponent_id", f.Player1.Player.id);
                    cmd1.ExecuteNonQuery();
                }
        }
        finally
        {
            mysql.Close();
        }
    }


    public GameResultData GetGameResults(Tournament tt)
    {
        var tournament = new Tournament();
        var Players = new List<User>();
        var fightData = new List<fightData>();
        var mysql = new MySqlConnection(Connection.conString);
        try
        {
            mysql.Open();


            var cmd_getTournament = new MySqlCommand(
                "SELECT * FROM tournaments t WHERE t.id = @tournament_id",
                mysql);
            cmd_getTournament.Parameters.AddWithValue("@tournament_id", tt.Tournamnet_id);
            var reader_tournaments = cmd_getTournament.ExecuteReader();
            if (reader_tournaments.Read())
            {
                //creating this terrible peace of code and opening a reader inside a reader  just because no methane what circumstance we are not allowed to break the information hiding principal  
                var THISISATERIBLEIDEA = new MySqlConnection(Connection.conString);
                try
                {
                    THISISATERIBLEIDEA.Open();
                    var cmd_getPlayers = new MySqlCommand(
                        "SELECT * FROM users u inner join  gameResults g ON u.id = g.player_id WHERE tournament_id = @tournament_id ORDER BY g.points DESC",
                        THISISATERIBLEIDEA);
                    cmd_getPlayers.Parameters.AddWithValue("@tournament_id", reader_tournaments.GetInt32("id"));

                    var reader_players = cmd_getPlayers.ExecuteReader();
                    Players = new List<User>();
                    while (reader_players.Read())
                        Players.Add(new User
                        {
                            username = reader_players.GetString("username"),
                            password = reader_players.GetString("password"),
                            firstName = reader_players.GetString("firstName"),
                            lastName = reader_players.GetString("lastName"),
                            birthdayDate = reader_players.GetDateTime("birthdayDate"),
                            gender = reader_players.GetInt32("gender"),
                            email = reader_players.GetString("email"),
                            phoneNumber = reader_players.GetString("phoneNumber"),
                            accType = Enum.Parse<AccTypes>(reader_players.GetString("accType")),
                            points = reader_players.GetInt32("points"),
                            id = reader_players.GetInt32("id")
                        });
                }
                finally
                {
                    THISISATERIBLEIDEA.Close();
                }

                tournament = new Tournament()
                {
                    SportType = Enum.Parse<sportTypes>(reader_tournaments.GetString("sportType")),
                    StartDate = reader_tournaments.GetDateTime("startDate"),
                    EndDate = reader_tournaments.GetDateTime("endDate"),
                    MinPlayers = reader_tournaments.GetInt32("minPlayers"),
                    MaxPlayers = reader_tournaments.GetInt32("maxPlayers"),
                    Location = reader_tournaments.GetString("location"),
                    TournamentSystem = Enum.Parse<TournamentSystems>(reader_tournaments.GetString("tournamentSystem")),
                    Tournamnet_id = reader_tournaments.GetInt32("id"),
                    Description = reader_tournaments.GetString("description"),
                    Gender = reader_tournaments.GetInt32("gender"),
                    Players = Players
                };
            }

            reader_tournaments.Close();
        }
        finally
        {
            mysql.Close();
        }


        try
        {
            mysql.Open();
            var cmd_getFightResults = new MySqlCommand(
                "SELECT g.fightScore, u.firstName AS pFname, u.lastName AS pLname,u2.firstName AS oFname, u2.lastName AS oLname  FROM gameFights g inner join users u on g.player_id = u.id left join users u2 on g.oponent_id = u2.id WHERE g.tournament_id = @tournament_id ORDER BY u.firstName ASC ",
                mysql);
            cmd_getFightResults.Parameters.AddWithValue("@tournament_id", tournament.Tournamnet_id);
            var reader_fightResults = cmd_getFightResults.ExecuteReader();
            while (reader_fightResults.Read())
                fightData.Add(new fightData()
                {
                    fightScore = reader_fightResults.GetString("fightScore"),
                    playerFirstName = reader_fightResults.GetString("pFname"),
                    playerLastName = reader_fightResults.GetString("pLname"),
                    oponentFirstName = reader_fightResults.GetString("oFname"),
                    oponentLastName = reader_fightResults.GetString("oLname")
                });


            return new GameResultData() { fightsData = fightData, tournament = tournament };
        }
        finally
        {
            mysql.Close();
        }
    }
    
    
    
    
    
    public List<GameResultData> GetPlayerProfiler(User user)
    {
        List<GameResultData> games = new List<GameResultData>();


        var tournament = new Tournament();
        var Players = new List<User>();
        var fightData = new List<fightData>();
        var mysql = new MySqlConnection(Connection.conString);
        int tid =-1;
        int br = 0;
        try
        {
            mysql.Open();
            var cmd_getFightResults = new MySqlCommand(
                "SELECT gr.points as PlrPoints, t.id as tid, t.sportType as TsportType, t.startDate as TstartDate,t.endDate as TendDate,t.minPlayers as TminPlayers, t.maxPlayers as TmaxPlayers, t.location as Tlocation, t.tournamentSystem as TtournamentSystem, t.description as Tdescription,t.gender as Tgender  , g.fightScore, u.firstName AS pFname, u.lastName AS pLname,u2.firstName AS oFname, u2.lastName AS oLname  FROM gameFights g inner join tournaments t on g.tournament_id = t.id inner join users u on g.player_id = u.id left join users u2 on g.oponent_id = u2.id  LEFT JOIN gameResults gr ON gr.tournament_id = t.id WHERE u.id = @uid AND gr.player_id = u.id ORDER BY t.id ASC ",
                mysql);
            cmd_getFightResults.Parameters.AddWithValue("@uid", user.id);
            var reader_fightResults = cmd_getFightResults.ExecuteReader();
            while (reader_fightResults.Read())
            {
                br++;
                if (tid == reader_fightResults.GetInt32("tid") && br != 1)
                {
                    fightData.Add(new fightData()
                    {
                        fightScore = reader_fightResults.GetString("fightScore"),
                        playerFirstName = reader_fightResults.GetString("pFname"),
                        playerLastName = reader_fightResults.GetString("pLname"),
                        oponentFirstName = reader_fightResults.GetString("oFname"),
                        oponentLastName = reader_fightResults.GetString("oLname")
                    });
                    tid = reader_fightResults.GetInt32("tid");
                }
                else
                {
                    
                    
                     tournament = new Tournament()  
                    {
                        SportType = Enum.Parse<sportTypes>(reader_fightResults.GetString("TsportType")),
                        StartDate = reader_fightResults.GetDateTime("TstartDate"),
                        EndDate = reader_fightResults.GetDateTime("TendDate"),
                        MinPlayers = reader_fightResults.GetInt32("TminPlayers"),
                        MaxPlayers = reader_fightResults.GetInt32("TmaxPlayers"),
                        Location = reader_fightResults.GetString("Tlocation"),
                        TournamentSystem = Enum.Parse<TournamentSystems>(reader_fightResults.GetString("TtournamentSystem")),
                        Tournamnet_id = reader_fightResults.GetInt32("tid"),
                        Description = reader_fightResults.GetString("Tdescription"),
                        Gender = reader_fightResults.GetInt32("Tgender")
                    };
                    
                    if(br != 1){
                    games.Add(new GameResultData(){fightsData = fightData, tournament = tournament, playerPoints = reader_fightResults.GetInt32("PlrPoints")});
                    fightData = new List<fightData>();
                    }
                    fightData.Add(new fightData()
                    {
                        fightScore = reader_fightResults.GetString("fightScore"),
                        playerFirstName = reader_fightResults.GetString("pFname"),
                        playerLastName = reader_fightResults.GetString("pLname"),
                        oponentFirstName = reader_fightResults.GetString("oFname"),
                        oponentLastName = reader_fightResults.GetString("oLname")
                    });
                    tid = reader_fightResults.GetInt32("tid");

                    
                    
                    
                    }
            }
            games.Add(new GameResultData(){fightsData = fightData, tournament = tournament, playerPoints = reader_fightResults.GetInt32("PlrPoints")});
            return games;
        }
        finally
        {
            mysql.Close();
        }
    }
    
    
    
}