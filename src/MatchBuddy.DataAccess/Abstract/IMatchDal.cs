using Core.DataAccess;
using MatchBuddy.Entities;

namespace MatchBuddy.DataAccess.Abstract
{
    public interface IMatchDal : IEntityRepository<Match>
    {
        void Add(Match match);
    }
}
