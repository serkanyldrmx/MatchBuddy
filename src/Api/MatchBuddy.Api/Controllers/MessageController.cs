using MatchBuddy.Business.Abstract;
using MatchBuddy.Business.Concrete;
using MatchBuddy.DataAccess.Abstract;
using MatchBuddy.DataAccess.Concrete.EntityFramework;
using MatchBuddy.Entities.Entity;
using Microsoft.AspNetCore.Mvc;

namespace MatchBuddy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        IMessageDal _messageDal;
        public MessageController(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        [HttpPost("getsendmessages")]
        public List<Message> GetSendMessage(int playerId)
        {
            IMessageService messageService = new MessageManager(new EFMessageDal());
            var result = messageService.GetSendMessage(playerId);
            return result.Data;
        }

        [HttpPost("getrecipientmessages")]
        public List<Message> GetRecipientMessage(int playerId)
        {
            IMessageService messageService = new MessageManager(new EFMessageDal());
            var result = messageService.GetRecipientMessage(playerId);
            return result.Data;
        }
    }
}
