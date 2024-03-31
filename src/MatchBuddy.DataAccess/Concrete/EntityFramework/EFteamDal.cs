using Core.DataAccess.EntityFramework;
using MatchBuddy.DataAccess;
using MatchBuddy.DataAccess.Abstract;
using MatchBuddy.Entities.Entity;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFteamDal : EfEntityRepositoryBase<Team, MatchBuddyContext>, ITeamDal
    {
    }
}
