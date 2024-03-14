using MatchBuddy.Entities;

namespace Business.Abstract
{
    public interface ITeamService
    {
        List<Team> GetAll(int teamId);
    }
}
