using Microsoft.AspNetCore.Mvc;
using NguyenTMiniChallengeEightToTen.Services.GuessIt;

namespace NguyenTMiniChallengeEightToTen.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
    private readonly IGuessItService _guessItService;

    public GuessItController(IGuessItService guessItService)
        {
        _guessItService = guessItService;
    }
        [HttpGet]
        [Route("GuessItEasy(1-10)/{input1}")]
        public string GuessItEasy (string input1){
            return _guessItService.GuessItEasy(input1);
        }

        [HttpGet]
        [Route("GuessItMedium(1-50)/{input1}")]
        public string GuessItMedium (string input1){
            return _guessItService.GuessItMedium(input1);
        }

        [HttpGet]
        [Route("GuessItHard(1-100)/{input1}")]
        public string GuessItHard (string input1){
            return _guessItService.GuessItHard(input1);
        }
    }
