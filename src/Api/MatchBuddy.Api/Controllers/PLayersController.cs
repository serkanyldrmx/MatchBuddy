using MatchBuddy.Business.Abstract;
using MatchBuddy.Business.Concrete;
using MatchBuddy.DataAccess.Concrete.EntityFramework;
using MatchBuddy.Entities.Entity;
using Microsoft.AspNetCore.Mvc;

namespace MatchBuddy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PLayersController : ControllerBase
    {
        //Loosely coupled
        //nameing convention 
        //IoC Container -- Inversion of Controler

        IPlayerService _playerService;

        public PLayersController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet("getall")] //alyans (isim) verdik
        public List<Player> Get()
        {
            IPlayerService playerService = new PlayerManager(new EFPlayerDal());
            var result = playerService.GetPlayers();
            return result.Data;
        }

        [HttpPost("getplayer")] //alyans (isim) verdik
        public Player GetPlayerInfo(int playerId)
        {
            IPlayerService playerService = new PlayerManager(new EFPlayerDal());
            var result = playerService.GetPlayerInfo(playerId);
            return result.Data;
        }

        //oyuncu eklemek için 
        [HttpPost("add")]
        public IActionResult Add(Player player)
        {
            var result = _playerService.Add(player);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //oyuncu güncellemek için 
        [HttpPost("update")]
        public IActionResult Update(Player player)
        {
            var result = _playerService.Update(player);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
