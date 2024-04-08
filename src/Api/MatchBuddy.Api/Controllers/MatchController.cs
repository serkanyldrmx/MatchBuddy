using MatchBuddy.Business.Abstract;
using MatchBuddy.Business.Concrete;
using MatchBuddy.Core.Utilities.Results;
using MatchBuddy.DataAccess.Concrete.EntityFramework;
using MatchBuddy.Entities.DTOs;
using MatchBuddy.Entities.Entity;
using Microsoft.AspNetCore.Mvc;

namespace MatchBuddy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        IMatchService _matchService;
        public MatchController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        //Maç eklemek için 
        [HttpPost("add")]
        public IActionResult Add(Match match)
        {
            var result = _matchService.Add(match);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Match match)
        {
            var result = _matchService.Update(match);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Match match)
        {
            var result = _matchService.Delete(match);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("getmatch")]
        public Match GetMatch(int matchId)
        {
            IMatchService matchService = new MatchManager(new EFMatchDal());
            IDataResult<Match> result = matchService.GetById(matchId);
            return result.Data;
        }

        [HttpGet("getall")]
        public List<Match> GetAll()
        {
            IMatchService matchService = new MatchManager(new EFMatchDal());
            var result = matchService.GetAll();
            return result.Data;
        }
                
        [HttpGet("getmatchcomments")]
        public List<MatchComentsDto> GetMatchComments()
        {
            IMatchService matchService = new MatchManager(new EFMatchDal());
            var result = matchService.GetMatchComment();
            return result.Data;
        }
    }
}
