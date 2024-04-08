using MatchBuddy.Entities.Entity;

namespace MatchBuddy.Business.Abstract
{
    public interface IMatchCommentsService
    {
        List<MatchComment> GetMatchCommentsAll(int matchId);
        //Maç yorumlarını getir
    }
}
