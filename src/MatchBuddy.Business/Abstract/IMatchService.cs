using Core.Utilities.Results;
using System.Text.RegularExpressions;

namespace Business.Abstract
{
    public interface IMatchService
    {
        IDataResult<List<Match>> GetAll();
        //Tüm maçları getir       
        IDataResult<Match> GetById(int matchId);
        //seçili maç bilgilerini getir
        IResult Add(Match match);
        //Maç ekle - oluştur
        IResult Delete(Match match);
        //Maç silme
        IResult Update(Match match);
        //Maç ekle - oluştur
    }
}
