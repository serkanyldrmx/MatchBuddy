using Core.DataAccess;
using MatchBuddy.Entities;

namespace MatchBuddy.DataAccess.Abstract
{
    public interface IPlayerDal : IEntityRepository<Player>
    {
    }
}
