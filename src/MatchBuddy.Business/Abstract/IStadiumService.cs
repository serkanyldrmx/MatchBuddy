using Core.Utilities.Results;
using MatchBuddy.Entities;

namespace Business.Abstract
{
    public interface IStadiumService
    {
        IDataResult<List<Stadium>> GetAll();
    }
}
