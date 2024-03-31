using Core.Utilities.Results;
using MatchBuddy.Entities.Entity;

namespace Business.Abstract
{
    public interface IStadiumService
    {
        IDataResult<List<Stadium>> GetAll();
    }
}
