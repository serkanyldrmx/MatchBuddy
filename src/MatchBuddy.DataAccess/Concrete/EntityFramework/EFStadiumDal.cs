using Core.DataAccess.EntityFramework;
using MatchBuddy.DataAccess;
using MatchBuddy.DataAccess.Abstract;
using MatchBuddy.Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFStadiumDal : EfEntityRepositoryBase<Stadium, MatchBuddyContext>, IStadiumDal
    {
    }
}
