using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using MatchBuddy.DataAccess.Abstract;
using MatchBuddy.Entities.Entity;

namespace MatchBuddy.Business.Concrete
{
    public class StadiumManager : IStadiumService
    {
        IStadiumDal _stadiumDal;
        public StadiumManager(IStadiumDal stadiumDal) 
        {
            _stadiumDal = stadiumDal;
        }
        public IDataResult<List<Stadium>> GetAll()
        {
            return new SuccessDataResult<List<Stadium>>(_stadiumDal.GetAll(), Messages.PlayersListed);
        }
    }
}
