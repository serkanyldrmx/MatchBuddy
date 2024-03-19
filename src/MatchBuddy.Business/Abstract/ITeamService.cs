using Core.Utilities.Results;
using MatchBuddy.Entities;

namespace Business.Abstract
{
    public interface ITeamService
    {
        IDataResult<List<Team>> GetAll();
        //Tüm Takımları getirmek için
        IResult Update(Team team);
        //Bilgilerimi güncelle
        IResult Add(Team team);
        //Oyuncu ekleme
        IResult Delete(Team team);
        //Maç silme
    }
}
