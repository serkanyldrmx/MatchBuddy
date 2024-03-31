using MatchBuddy.Entities.Entity;

namespace Business.Abstract
{
    public interface IMatchCommentsService
    {
        List<MatchComment> GetMatchCommentsAll(int matchId);
        //Maç yorumlarını getir
    }
}
