using MatchBuddy.Core.DataAccess.EntityFramework;
using MatchBuddy.DataAccess.Abstract;
using MatchBuddy.Entities.DTOs;
using MatchBuddy.Entities.Entity;
using Microsoft.EntityFrameworkCore;

namespace MatchBuddy.DataAccess.Concrete.EntityFramework
{
    public class EFMatchDal : EfEntityRepositoryBase<Match, MatchBuddyContext>, IMatchDal
    {
        public List<MatchComentsDto> GetMatchComents(int matchId)
        {

            using (MatchBuddyContext context = new MatchBuddyContext())
            {
                var result = from p in context.MatchComments
                             where p.MatchId == matchId
                             select new MatchComentsDto
                             {
                                 MatchId = p.MatchId,
                                 PlayerId = p.playerId,
                                 Comment = p.Comment,
                                 // Diğer alanları buraya ekleyin
                             };
                return result.ToList();
            }
            //using (MatchBuddyContext context = new MatchBuddyContext())
            //{
            //    var result = from p in context.MatchComments
            //                 //join c in context.MatchComments
            //                 //on p.MatchId equals c.MatchId
            //                 select new MatchComentsDto
            //                 {
            //                     //MatchId = matchId,
            //                     //MatchId = c.MatchId,
            //                     //PlayerId = c.playerId,
            //                     //Comment = c.Comment,
            //                 } ;
            //    return result.ToList();
            //}
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
