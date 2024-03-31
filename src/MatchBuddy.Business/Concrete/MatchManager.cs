using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using MatchBuddy.DataAccess.Abstract;
using MatchBuddy.Entities.DTOs;
using MatchBuddy.Entities.Entity;

namespace MatchBuddy.Business.Concrete
{
    public class MatchManager: IMatchService
    {
        IMatchDal _matchDal;
        public MatchManager(IMatchDal matchDal)
        {
            _matchDal = matchDal;
        }

        public IResult Add(Match match)
        {
            if (match.MatchName.Length < 5)
            {
                return new ErrorResult(Messages.MatchNameInvalid);
            }
            _matchDal.Add(match);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(Match match)
        {
            _matchDal.Delete(match);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<List<Match>> GetAll()
        {
            return new SuccessDataResult<List<Match>>(_matchDal.GetAll(), Messages.PlayersListed);
        }

        public IDataResult<Match> GetById(int matchId)
        {
            return new SuccessDataResult<Match>(_matchDal.Get(p => p.MatchId == matchId));
        }

        public IResult Update(Match match)
        {
            _matchDal.Update(match);
            return new Result(true, Messages.Update);
        }

        public IDataResult<List<MatchComentsDto>> GetMatchComment()
        {
            return new SuccessDataResult<List<MatchComentsDto>>(_matchDal.GetMatchComents());
        }
    }
}
