using Core.Utilities.Results;
using MatchBuddy.Entities;

namespace Business.Abstract
{
    public interface IPlayerService
    {
        IDataResult<Player> GetPlayerInfo(int playerId);
        //bilgilerimi getir
        IDataResult<List<Player>> GetPlayers();
        //Oyuncuları Listele
        IDataResult<Player> GetTeam(int playerId);
        //Takım arkadaşlarını getir
        IResult Update(Player player);
        //Bilgilerimi güncelle
        IResult Add(Player player);
        //Oyuncu ekleme
    }
}
