using _1zajecia.Services.Lab4;
using Microsoft.AspNetCore.Mvc;

namespace _1zajecia.Controllers.LAB4
{
    [ApiController]
    [Route("lab4")]
    public class LanguageController : ControllerBase
    {
        [HttpGet]
        [Route("GetLang")]
        public string getLang()
        {
            var lang = new Polish("PL");
            return lang.getLang();
        }
    }
}
