using Business.Abstract;
using Core.Utilities.Results;
using MatchBuddy.DataAccess.Abstract;
using MatchBuddy.Entities.Entity;

namespace MatchBuddy.Business.Concrete
{
    public class MessageManager: IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public IDataResult<List<Message>> GetRecipientMessage(int playerId)
        {
            return new SuccessDataResult<List<Message>>(_messageDal.GetAll(x=>x.RecipientPlayerId == playerId));
        }

        public IDataResult<List<Message>> GetSendMessage(int playerId)
        {
            return new SuccessDataResult<List<Message>>(_messageDal.GetAll(x => x.SendPlayerId == playerId));
        }
    }
}
