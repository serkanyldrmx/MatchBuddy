using Core.DataAccess;
using MatchBuddy.Entities.Entity;

namespace MatchBuddy.DataAccess.Abstract
{
    public interface IPlayerDal : IEntityRepository<Player>
    {
    }
}
