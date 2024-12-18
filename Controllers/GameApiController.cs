using Microsoft.AspNetCore.Mvc;
using Tanki_ASP.NET.Game;
using Tanki_ASP.NET.Game.Interfaces;

namespace Tanki_ASP.NET.Controllers
{
    [ApiController]
    [Route("api/Game")]
    public class GameApiController : ControllerBase
    {
        [HttpPost]
        public void Move()
        {

        }

        [HttpPost]
        public void Attack()
        {

        }

        [HttpPost]
        public void Die()
        {

        }
        [HttpPost]
        public void Restore()
        {

        }

        [HttpPost]
        public void Pay()
        {

        }

        [HttpGet]
        public string GetCurrentPosition()
        {
            return string.Empty;
        }
    }

}