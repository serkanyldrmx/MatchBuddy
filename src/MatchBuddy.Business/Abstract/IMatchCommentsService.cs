using MatchBuddy.Entities;

namespace Business.Abstract
{
    public interface IMatchCommentsService
    {
        List<Match> GetMatchCommentsAll(int matchId);
        //Maç yorumlarını getir
    }
}
