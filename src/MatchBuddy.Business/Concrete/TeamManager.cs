using MatchBuddy.Business.Abstract;
using MatchBuddy.Business.Constants;
using MatchBuddy.Core.Utilities.Results;
using MatchBuddy.DataAccess.Abstract;
using MatchBuddy.Entities.Entity;

namespace MatchBuddy.Business.Concrete
{
    public class TeamManager : ITeamService
    {
        ITeamDal _teamDal;
        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public IResult Add(Team team)
        {
            if (team.TeamName.Length < 3)
            {
                return new ErrorResult(Messages.TeamNameInvalid);
            }
            _teamDal.Add(team);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(Team team)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Team>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Team team)
        {
            throw new NotImplementedException();
        }
    }
}
