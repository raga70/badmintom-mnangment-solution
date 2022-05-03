using Entities;
using MySql.Data.MySqlClient;
using RealizationProvider;

namespace DAL;

public class GameDB
{

    public void PushTournament(Tournament t, List<Round> rounds)
    {
        MySqlConnection mysql = new MySqlConnection(Connection.conString);
        try
        {
            mysql.Open();
            foreach (var p in t.Players)
            {
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO  gameResults(tournament_id, playerUsername, points) VALUES (@tournament_id, @username, @points  ) ON DUPLICATE KEY UPDATE tournament_id = @tournament_id, playerUsername = @username",
                    mysql);
                cmd.Parameters.AddWithValue("@tournament_id", t.Tournamnet_id);
                cmd.Parameters.AddWithValue("@username", p.username);
                cmd.Parameters.AddWithValue("@points", p.points);

                cmd.ExecuteNonQuery();
            }

            foreach (var r in rounds)
            {
                foreach (var f in r.Fights)
                {
                    MySqlCommand cmd = new MySqlCommand(
                        "INSERT INTO  gameFights(tournament_id, playerUsername, fightScore, oponent) VALUES (@tournament_id, @username, @fightScore, @oponent  )ON DUPLICATE KEY UPDATE tournament_id = @tournament_id, playerUsername = @username,oponent = @oponent",
                        mysql); 
                    cmd.Parameters.AddWithValue("@tournament_id", t.Tournamnet_id);
                    cmd.Parameters.AddWithValue("@username", f.Player1.Player.username);
                    cmd.Parameters.AddWithValue("@fightScore", $"{f.Player1.Score}:{f.Player2.Score}");
                    cmd.Parameters.AddWithValue("@oponent", f.Player2.Player.username);
                    cmd.ExecuteNonQuery();
                    
                    MySqlCommand cmd1 = new MySqlCommand(
                        "INSERT INTO  gameFights(tournament_id, playerUsername, fightScore, oponent) VALUES (@tournament_id, @username, @fightScore, @oponent  )ON DUPLICATE KEY UPDATE tournament_id = @tournament_id, playerUsername = @username,oponent = @oponent",
                        mysql); 
                    cmd1.Parameters.AddWithValue("@tournament_id", t.Tournamnet_id);
                    cmd1.Parameters.AddWithValue("@username", f.Player2.Player.username);
                    cmd1.Parameters.AddWithValue("@fightScore", $"{f.Player2.Score}:{f.Player1.Score}");
                    cmd1.Parameters.AddWithValue("@oponent", f.Player1.Player.username);
                    cmd1.ExecuteNonQuery();
                }
                
            }
            
        }
        finally
        {
            mysql.Close();
        }
    }





    public GameResultData GetGameResults(Tournament tt)
    {
       
           Tournament tournament = new Tournament();
            List<User> Players = new List<User>();
            List<fightData> fightData = new List<fightData>();
            MySqlConnection mysql = new MySqlConnection(Connection.conString);
            try
            {
                mysql.Open();
                
                
                MySqlCommand cmd_getTournament = new MySqlCommand(
                    "SELECT * FROM tournaments t WHERE t.id = @tournament_id",
                    mysql);
                cmd_getTournament.Parameters.AddWithValue("@tournament_id", tt.Tournamnet_id);
                MySqlDataReader reader_tournaments = cmd_getTournament.ExecuteReader();
                if (reader_tournaments.Read())
                {
                    //creating this terrible peace of code and opening a reader inside a reader  just because no methane what circumstance we are not allowed to break the information hiding principal  
                    MySqlConnection THISISATERIBLEIDEA = new MySqlConnection(Connection.conString);
                    try
                    {
                        THISISATERIBLEIDEA.Open();
                        MySqlCommand cmd_getPlayers = new MySqlCommand(
                            "SELECT * FROM users u inner join  gameResults g ON u.username = g.playerUsername WHERE tournament_id = @tournament_id ORDER BY g.points DESC",
                            THISISATERIBLEIDEA);
                        cmd_getPlayers.Parameters.AddWithValue("@tournament_id", reader_tournaments.GetInt32("id"));

                        MySqlDataReader reader_players = cmd_getPlayers.ExecuteReader();
                          Players  = new List<User>();
                        while (reader_players.Read())
                        {
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
                                
                            });
                        }
                    }
                    finally
                    {
                        THISISATERIBLEIDEA.Close();
                    }

                    tournament=new Tournament()
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
                MySqlCommand cmd_getFightResults = new MySqlCommand(
                    "SELECT g.fightScore, u.firstName AS pFname, u.lastName AS oLname,u2.firstName AS oFname, u2.lastName AS pLname  FROM gameFights g inner join users u on g.playerUsername = u.username left join users u2 on g.oponent = u2.username WHERE g.tournament_id = @tournament_id ORDER BY u.firstName ASC ",
                    mysql);
                cmd_getFightResults.Parameters.AddWithValue("@tournament_id", tournament.Tournamnet_id);
                MySqlDataReader reader_fightResults = cmd_getFightResults.ExecuteReader();
                while (reader_fightResults.Read())
                {
                    fightData.Add(new fightData()
                    {
                        fightScore = reader_fightResults.GetString("fightScore"),
                        playerFirstName = reader_fightResults.GetString("pFname"),
                        playerLastName = reader_fightResults.GetString("pLname"),
                        oponentFirstName = reader_fightResults.GetString("oFname"),
                        oponentLastName = reader_fightResults.GetString("oLname")

                    });
                }


            return  new GameResultData(){fightsData = fightData,tournament = tournament};
            }
            finally
            {
            mysql.Close();
            }
    }












}