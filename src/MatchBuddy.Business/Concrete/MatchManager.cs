using MatchBuddy.Business.Abstract;
using MatchBuddy.Business.Constants;
using MatchBuddy.Core.Utilities.Results;
using MatchBuddy.DataAccess.Abstract;
using MatchBuddy.DataAccess.Concrete.EntityFramework;
using MatchBuddy.Entities.DTOs;
using MatchBuddy.Entities.Entity;

namespace MatchBuddy.Business.Concrete
{
    public class MatchManager: IMatchService
    {
        IMatchDal _matchDal;
        IMatchTeamDal _matchTeamDal;

        public MatchManager(IMatchDal matchDal, IMatchTeamDal matchTeamDal)
        {
            _matchDal = matchDal;
            _matchTeamDal = matchTeamDal;
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

        public IDataResult<List<MatchComentsDto>> GetMatchComents(int matchId)
        {
            return new SuccessDataResult<List<MatchComentsDto>>(_matchDal.GetMatchComents(matchId));
        }
        public IDataResult<List<MatchTeamDto>> GetMatchTeam(int matchId)
        {
            return new SuccessDataResult<List<MatchTeamDto>>(_matchDal.GetMatchTeam(matchId));
        }

        public IResult AddMatchTeam(MatchTeam matchTeam)
        {
            _matchTeamDal.Add(matchTeam);
            return new Result(true, Messages.Added);
        }
    }
}
