using Core.DataAccess.EntityFramework;
using MatchBuddy.DataAccess;
using MatchBuddy.DataAccess.Abstract;
using MatchBuddy.Entities.DTOs;
using MatchBuddy.Entities.Entity;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFMatchDal : EfEntityRepositoryBase<Match, MatchBuddyContext>, IMatchDal
    {
        public List<MatchComentsDto> GetMatchComents()
        {
            using (MatchBuddyContext context = new MatchBuddyContext())
            {
                var result = from p in context.Matchs
                             join c in context.MatchComments
                             on p.MatchId equals c.MatchId
                             select new MatchComentsDto
                             {
                                 MatchId = c.MatchId,
                                 PlayerId = c.playerId,
                                 Comment = c.Comment,
                             };
                return result.ToList();
            }
        }
    }
}
