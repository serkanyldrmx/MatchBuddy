using MatchBuddy.Core.DataAccess.EntityFramework;
using MatchBuddy.DataAccess.Abstract;
using MatchBuddy.Entities.DTOs;
using MatchBuddy.Entities.Entity;
using Microsoft.EntityFrameworkCore;

namespace MatchBuddy.DataAccess.Concrete.EntityFramework
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

        public MatchComment GetMatchComents2()
        {
            using (MatchBuddyContext context = new MatchBuddyContext())
            {
                context.Matchs.Include(x=> x.MatchComments).ToList();
                return context.MatchComments.Include(x => x.Match).ThenInclude(x => x.Stadium).FirstOrDefault();
                
            }
        }
    }
}
