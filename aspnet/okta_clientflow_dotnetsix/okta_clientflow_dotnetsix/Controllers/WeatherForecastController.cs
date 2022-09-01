using Microsoft.AspNetCore.Mvc;
using okta_clientflow_dotnetsix.Okta;

namespace okta_clientflow_dotnetsix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IJwtValidator _tokenValidationService;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IJwtValidator tokenValidationService)
        {
            _logger = logger;
            _tokenValidationService = tokenValidationService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IActionResult> Get()
        {
            var authToken = this.HttpContext.Request.Headers["Authorization"].ToString();
            if (string.IsNullOrEmpty(authToken)) return Unauthorized();

            var validatedToken = await _tokenValidationService.ValidateToken(authToken.Split(" ")[1]);
            if (validatedToken == null) return Unauthorized();

            return new JsonResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}