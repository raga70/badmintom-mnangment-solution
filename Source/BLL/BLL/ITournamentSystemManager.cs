namespace BLL;
using Entities;
public interface ITournamentSystemManager
{
    void Initializer();
    List<Round> CreteSchedule();
}