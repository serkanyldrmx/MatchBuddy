using Core.Utilities.Results;
using MatchBuddy.Entities.Entity;

namespace Business.Abstract
{
    public interface IMessageService
    {
        IDataResult<List<Message>> GetRecipientMessage(int playerId);
        //Gelen mesajları getir
        IDataResult<List<Message>> GetSendMessage(int playerId);
        //Gönderilen mesajları getir  
    }
}
