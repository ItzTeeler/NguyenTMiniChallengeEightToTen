using Microsoft.AspNetCore.Mvc;
using NguyenTMiniChallengeEightToTen.Services.RestaurantPicker;

namespace NguyenTMiniChallengeEightToTen.Controllers;

[ApiController]
[Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
    private readonly IRestaurantPickerService _restaurantPickerService;

    public RestaurantPickerController(IRestaurantPickerService restaurantPickerService)
        {
        _restaurantPickerService = restaurantPickerService;
    }
        [HttpGet]
        [Route("RestaurantPicker 1.Japanese 2.Korean 3.Chinese/{categoryNumber}")]
        public string RestaurantPicker(string categoryNumber){
            return _restaurantPickerService.RestaurantPicker(categoryNumber);
        }
    }
