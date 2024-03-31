using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using MatchBuddy.DataAccess.Abstract;
using MatchBuddy.Entities.DTOs;
using MatchBuddy.Entities.Entity;

namespace MatchBuddy.Business.Concrete
{
    public class PlayerManager :IPlayerService
    {
        IPlayerDal _playerDal;
        public PlayerManager(IPlayerDal playerDal)
        {
            _playerDal = playerDal;
        }

        public IResult Add(Player player)
        {
            //business codes
            if (player.PlayerName.Length < 3)
            {
                return new ErrorResult(Messages.PlayerNameInvalid);
            }
            _playerDal.Add(player);
            return new Result(true, Messages.Added);
        }

        public IDataResult<Player> GetPlayerInfo(int playerId)
        {
            return new SuccessDataResult<Player>(_playerDal.Get(p => p.PlayerId == playerId));
        }

        public IDataResult<List<Player>> GetPlayers()
        {
            //iş Kodları
            //yetkisi varmı? 

            //if (DateTime.Now.Hour == 22)
            //{
            //    return new ErrorDataResult<List<Player>>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<List<Player>>(_playerDal.GetAll(), Messages.PlayersListed);

        }

        public IDataResult<Player> GetTeam(int playerId)
        {
            return new SuccessDataResult<Player>(_playerDal.Get(p => p.PlayerId == playerId));
        }

        public IResult Update(Player player)
        {
            if (player.PlayerName.Length < 2)
            {
                return new ErrorResult(Messages.PlayerNameInvalid);
            }
            _playerDal.Update(player);
            return new Result(true, Messages.Update);
        }

        
    }
}
