using Core.DataAccess.EntityFramework;
using MatchBuddy.DataAccess;
using MatchBuddy.DataAccess.Abstract;
using MatchBuddy.Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFPlayerDal : EfEntityRepositoryBase<Player, MatchBuddyContext>, IPlayerDal
    {
    }
}
