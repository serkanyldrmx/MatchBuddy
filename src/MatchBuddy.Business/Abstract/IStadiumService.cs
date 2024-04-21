using MatchBuddy.Core.Utilities.Results;
using MatchBuddy.Entities.Entity;

namespace MatchBuddy.Business.Abstract
{
    public interface IStadiumService
    {
        IDataResult<List<Stadium>> GetAll();

        IResult Add(Stadium stadium);
    }
}
