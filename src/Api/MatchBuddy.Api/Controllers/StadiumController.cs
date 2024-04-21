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
    public class StadiumController : ControllerBase
    {
        IStadiumService _stadiumService;

        public StadiumController(IStadiumService stadiumService)
        {
            _stadiumService = stadiumService;
        }

        //oyuncu eklemek için 
        [HttpPost("add")]
        public IActionResult Add(StadiumModel stadiumModel)
        {
            var stadium = new Stadium()
            {
                StadiumName = stadiumModel.StadiumName,
                City = stadiumModel.City,
                District = stadiumModel.District,
                Location = stadiumModel.Location,
            };
            var result = _stadiumService.Add(stadium);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public List<Stadium> Get()
        {
            IStadiumService stadiumService = new StadiumManager(new EFStadiumDal());
            var result = _stadiumService.GetAll();
            return result.Data;
        }
    }
}
