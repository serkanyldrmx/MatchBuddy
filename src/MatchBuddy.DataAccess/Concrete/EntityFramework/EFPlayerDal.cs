using Core.DataAccess.EntityFramework;
using MatchBuddy.DataAccess;
using MatchBuddy.DataAccess.Abstract;
using MatchBuddy.Entities.DTOs;
using MatchBuddy.Entities.Entity;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFPlayerDal : EfEntityRepositoryBase<Player, MatchBuddyContext>, IPlayerDal
    {
       
    }
}
