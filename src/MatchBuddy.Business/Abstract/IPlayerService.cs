using Core.Utilities.Results;
using MatchBuddy.Entities;

namespace Business.Abstract
{
    public interface IPlayerService
    {
        Player GetPlayerInfo(int playerId);
        //bilgilerimi getir
        IDataResult<Player> GetPlayers();
        //Oyuncuları Listele
        IDataResult<Player> GetTeam(int matchId);
        //Takım arkadaşlarını getir
        IResult Update(Player player);
        //Bilgilerimi güncelle
        IResult Add(Player player);
        //Oyuncu ekleme
    }
}
