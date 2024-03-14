using Core.Utilities.Results;
using MatchBuddy.Entities;

namespace Business.Abstract
{
    public interface IMessageService
    {
        Message GetRecipientMessage(int playerId);
        //Gelen mesajları getir
        Message GetSendMessage(int playerId);
        //Gönderilen mesajları getir  
    }
}
