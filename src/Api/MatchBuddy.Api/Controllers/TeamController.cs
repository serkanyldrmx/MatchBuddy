using MatchBuddy.Api.Model;
using MatchBuddy.Business.Abstract;
using MatchBuddy.Business.Concrete;
using MatchBuddy.DataAccess.Concrete.EntityFramework;
using MatchBuddy.Entities.Entity;
using Microsoft.AspNetCore.Mvc;

namespace MatchBuddy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpPost("SaveTeam")]
        public IActionResult SaveTeam(TeamModel teamModel)
        {
            var team = new Team
            {
                TeamName = teamModel.TeamName,
                PlayerTeams = teamModel.PlayerId.Select(playerId => new PlayerTeam
                {
                    PlayerId = playerId
                }).ToList()
            };
            var result = _teamService.Add(team);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetTeamList")]
        public List<Team> GetTeamList()
        {
            ITeamService teamService = new TeamManager(new EFteamDal());
            var result = _teamService.GetAll();
            return result.Data;
        }
    }
}
