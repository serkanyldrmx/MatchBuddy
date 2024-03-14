using Core.Utilities.Results;
using System.Text.RegularExpressions;

namespace Business.Abstract
{
    public interface IMatchService
    {
        IDataResult<List<Match>> GetAll();
        //Tüm maçları getir
        IDataResult<List<Match>> GetAllByMatchId(int id);
        //seçili maç bilgilerini getir
        IDataResult<Match> GetById(int matchId);
        IResult Add(Match match);
        //Maç ekle - oluştur

        //RESTFUL --> HTTP --> TCP
    }
}
