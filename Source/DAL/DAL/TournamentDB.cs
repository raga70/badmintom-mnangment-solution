using MySql.Data.MySqlClient;
using Entities;
using RealizationProvider;

namespace DAL;

public class TournamentDB : ITournamentDB
{
    public void AddTournament(Tournament tournament)
    {
        var mysql = new MySqlConnection(Connection.conString);
        try
        {
            mysql.Open();
            var cmd = new MySqlCommand(
                "INSERT INTO tournaments(sportType, startDate, endDate, minPlayers, maxPlayers, location, tournamentSystem, description, gender) VALUES(@sportType, @startDate, @endDate, @minPlayers, @maxPlayers, @location, @tournamentSystem, @description, @gender)",
                mysql);

            cmd.Parameters.AddWithValue("@sportType", tournament.SportType.ToString());
            cmd.Parameters.AddWithValue("@startDate", tournament.StartDate.ToString("yyyy/MM/dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@endDate", tournament.EndDate.ToString("yyyy/MM/dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@minPlayers", tournament.MinPlayers);
            cmd.Parameters.AddWithValue("@maxPlayers", tournament.MaxPlayers);
            cmd.Parameters.AddWithValue("@location", tournament.Location);
            cmd.Parameters.AddWithValue("@tournamentSystem", tournament.TournamentSystem.ToString());
            cmd.Parameters.AddWithValue("@description", tournament.Description);
            cmd.Parameters.AddWithValue("@gender", tournament.Gender);
            cmd.ExecuteNonQuery();
        }
        finally
        {
            mysql.Close();
        }
    }

    public void UpdateTournament(Tournament tournament)
    {
        var mysql = new MySqlConnection(Connection.conString);
        try
        {
            mysql.Open();
            var cmd = new MySqlCommand(
                "UPDATE tournaments SET sportType = @sportType, startDate = @startDate, endDate = @endDate, minPlayers = @minPlayers, maxPlayers = @maxPlayers, location = @location, tournamentSystem = @tournamentSystem, description = @description, gender = @gender WHERE id = @id",
                mysql);
            cmd.Parameters.AddWithValue("@id", tournament.Tournamnet_id);
            cmd.Parameters.AddWithValue("@sportType", tournament.SportType.ToString());
            cmd.Parameters.AddWithValue("@startDate", tournament.StartDate.ToString("yyyy/MM/dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@endDate", tournament.EndDate.ToString("yyyy/MM/dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@minPlayers", tournament.MinPlayers);
            cmd.Parameters.AddWithValue("@maxPlayers", tournament.MaxPlayers);
            cmd.Parameters.AddWithValue("@location", tournament.Location);
            cmd.Parameters.AddWithValue("@tournamentSystem", tournament.TournamentSystem.ToString());
            cmd.Parameters.AddWithValue("@description", tournament.Description);
            cmd.Parameters.AddWithValue("@gender", tournament.Gender);
            cmd.ExecuteNonQuery();
        }
        finally
        {
            mysql.Close();
        }
    }

    public void DeleteTournament(Tournament tournament)
    {
        var mysql = new MySqlConnection(Connection.conString);
        try
        {
            mysql.Open();
            var cmd = new MySqlCommand(
                "DELETE FROM tournaments WHERE id = @id",
                mysql);
            cmd.Parameters.AddWithValue("@id", tournament.Tournamnet_id);
            cmd.ExecuteNonQuery();
        }
        finally
        {
            mysql.Close();
        }
    }

    //with the users
    public List<Tournament> GetAllTournaments()
    {
        var tournaments = new List<Tournament>();
        var Players = new List<User>();
        var mysql = new MySqlConnection(Connection.conString);
        try
        {
            mysql.Open();


            var cmd_getTournament = new MySqlCommand(
                "SELECT * FROM tournaments t",
                mysql);
            var reader_tournaments = cmd_getTournament.ExecuteReader();
            while (reader_tournaments.Read())
            {
                Players = GetAllPlayerPerTournament(reader_tournaments.GetInt32("id"));

                tournaments.Add(new Tournament()
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
                });
            }

            return tournaments;
        }
        finally
        {
            mysql.Close();
        }
    }


    private List<User> GetAllPlayerPerTournament(int tournamentID)
    {
        var Players = new List<User>();
        var mysql_plr = new MySqlConnection(Connection.conString);
        try
        {
            mysql_plr.Open();
            var cmd_getPlayers = new MySqlCommand(
                "SELECT * FROM users u INNER JOIN tournaments_users tu on u.id = tu.users_id WHERE tu.tournaments_id = @tournament_id",
                mysql_plr);
            cmd_getPlayers.Parameters.AddWithValue("@tournament_id", tournamentID);

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
                    id = reader_players.GetInt32("id")
                });
        }
        finally
        {
            mysql_plr.Close();
        }

        return Players;
    }


    public void AddPlayerToTournament(Tournament tournament, User player)
    {
        var mysql = new MySqlConnection(Connection.conString);
        try
        {
            mysql.Open();
            var cmd_addPlayer = new MySqlCommand(
                "INSERT INTO tournaments_users (tournaments_id, users_id) VALUES (@tournament_id, @player_id)",
                mysql);
            cmd_addPlayer.Parameters.AddWithValue("@tournament_id", tournament.Tournamnet_id);
            cmd_addPlayer.Parameters.AddWithValue("@player_id", player.id);
            cmd_addPlayer.ExecuteNonQuery();
        }
        finally
        {
            mysql.Close();
        }
    }

    public void RemovePlayerFromTournament(Tournament tournament, User player)
    {
        var mysql = new MySqlConnection(Connection.conString);
        try
        {
            mysql.Open();
            var cmd_removePlayer = new MySqlCommand(
                "DELETE FROM tournaments_users WHERE tournaments_id = @tournament_id AND users_id = @player_id",
                mysql);
            cmd_removePlayer.Parameters.AddWithValue("@tournament_id", tournament.Tournamnet_id);
            cmd_removePlayer.Parameters.AddWithValue("@player_id", player.id);
            cmd_removePlayer.ExecuteNonQuery();
        }
        finally
        {
            mysql.Close();
        }
    }
}