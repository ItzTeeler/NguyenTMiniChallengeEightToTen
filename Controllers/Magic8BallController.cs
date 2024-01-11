using Microsoft.AspNetCore.Mvc;
using NguyenTMiniChallengeEightToTen.Services.Magic8Ball;

namespace NguyenTMiniChallengeEightToTen.Controllers;
[ApiController]
[Route("[controller]")]
    public class Magic8BallController : ControllerBase
    {
    private readonly IMagic8BallService _magic8BallService;

    public Magic8BallController(IMagic8BallService magic8BallService)
        {
        _magic8BallService = magic8BallService;
    }
        [HttpGet]
        [Route("Magic8Ball")]
        public string Magic8Ball (){
            return _magic8BallService.Magic8Ball();
        }
    }
