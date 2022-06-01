using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities;

public class Tournament
{
    [Required] public sportTypes SportType { get; init; }
    [Required] public string Description { get; init; }
    [Required] public DateTime StartDate { get; init; }

    [Required] private DateTime _endDate;

    public DateTime EndDate
    {
        get => _endDate;
        init
        {
            if (value <= StartDate)
                throw new ArgumentException("the tournament cannot end before it starts");
            else _endDate = value;
        }
    }

    [Required] [Range(2, 100)] public int MinPlayers { get; init; }

    [Required] [Range(0, 100)] private int _MaxPlayers;

    public int MaxPlayers
    {
        get => _MaxPlayers;
        init
        {
            if (value <= MinPlayers)
                throw new ArgumentException("the number of maxPlayers must be greater than minPlayers");
            else
                _MaxPlayers = value;
        }
    }

    [Required(ErrorMessage = "The Address field is required")]
    public string Location { get; init; }

    [Required] public TournamentSystems TournamentSystem { get; init; }
    [Required] public int Gender { get; init; }


    //available after generation
    public List<User> Players { get; init; } = new List<User>();
    public int Tournamnet_id { get; init; }

    public bool isActive()
    {
        if (DateTime.Now > StartDate && DateTime.Now < EndDate)
            return true;
        else
            return false;
    }

    public bool isEnded()
    {
        if (DateTime.Now < EndDate)
            return false;
        else
            return true;
    }

    public bool isGameStartable()
    {
        if (MinPlayers <= Players.Count) return true;
        else return false;
    }


    public void AddPlayr(User player)
    {
        if (!Players.Contains(player)) Players.Add(player);
    }

    public void RemovePlayer(User player)
    {
        Players.Remove(player);
    }


    //asp tournament displyment options
    public bool TournamentWasCancelled()
    {
        if (Players.Count < MinPlayers && isEnded() == true) return true;
        return false;
    }

    public bool ResultsAreAvailable()
    {
        if (isEnded() == true) return true;
        return false;
    }

    public bool ScheduleIsAvailable()
    {
        if (Players.Count >= MinPlayers) return true;
        return false;
    }
    
    public bool isLocked()
    {
        if (DateTime.Now > StartDate + TimeSpan.FromDays(-7)) return true;
        else
            return false;
           
    }
    
}