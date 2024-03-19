using Core.DataAccess.EntityFramework;
using MatchBuddy.DataAccess;
using MatchBuddy.DataAccess.Abstract;
using MatchBuddy.Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFMatchDal : EfEntityRepositoryBase<Match, MatchBuddyContext>, IMatchDal
    {
        public void Add(Match match)
        {
            throw new NotImplementedException();
        }
    }
}
