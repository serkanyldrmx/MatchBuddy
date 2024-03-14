using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using MatchBuddy.DataAccess.Abstract;
using MatchBuddy.Entities;

namespace MatchBuddy.Business.Concrete
{
    public class PlayerManager 
    {
        IPlayerDal _playerDal;
        public PlayerManager(IPlayerDal playerDal)
        {
            _playerDal = playerDal;
        }
        public IResult Add(Player player)
        {
            //business codes
            if (player.PlayerName.Length < 2)
            {
                return new ErrorResult(Messages.PlayerNameInvalid);
            }

            _playerDal.Add(player);
            return new Result(true, Messages.PlayerAdded);
        }

        //public Player GetPlayerInfo(int playerId)
        //{
        //    //return new SuccessDataResult<Player>(_playerDal.Get(p => p.PlayerId == playerId));
        //}

        //public IDataResult<Player> GetPlayers()
        //{
        //    //iş Kodları
        //    //yetkisi varmı? 

        //    //if (DateTime.Now.Hour == 22)
        //    //{
        //    //    return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
        //    //}
        //    return new SuccessDataResult<List<Player>>(_playerDal.GetAll(), Messages.PlayersListed);

        //}

        public IDataResult<Player> GetTeam(int matchId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
