using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICourseService.Models;

namespace WebAPICourseService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigSampleController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SampleWebSettings _sampleWebSettings;


        public ConfigSampleController(IConfiguration configuration, IOptions<SampleWebSettings> settingOptions)
        {
            _configuration = configuration;


            _sampleWebSettings = settingOptions.Value;
        }
        //https://docs.microsoft.com/de-de/aspnet/core/fundamentals/configuration/?view=aspnetcore-6.0
        [HttpGet("/Sample1")]
        public string Methode()
        {
            PositionOptions positionOptions = new();
            _configuration.GetSection(PositionOptions.StringPosition).Bind(positionOptions);

            return $"{positionOptions.Title} {positionOptions.Name}";
        }

        [HttpGet("/Sample2")]
        public string MethodeB()
        {
            return $"{_sampleWebSettings.Title} {_sampleWebSettings.Update}";
        }


        [HttpGet("/Sample3")]
        public string MethodeC()
        {
            var myKeyValue = _configuration["MyKey"];
            var title = _configuration["Position:Title"];
            var name = _configuration["Position:Name"];
            var defaultLogLevel = _configuration["Logging:LogLevel:Default"];


            return $"MyKey value: {myKeyValue} \n" +
                           $"Title: {title} \n" +
                           $"Name: {name} \n" +
                           $"Default Log Level: {defaultLogLevel}";
        }
    }
}
