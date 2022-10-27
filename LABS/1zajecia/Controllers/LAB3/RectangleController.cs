using _1zajecia.Services.Lab3;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace _1zajecia.Controllers.LAB3
{

    [ApiController]
    [Route("lab3")]
    public class RectangleController : ControllerBase
    {
        [HttpGet]
        [Route("getArea")]
        public int GetArea() //endpoint
        {
            var rec = new Rectangle(20, 10);
            return rec.GetArea();
        }

        [HttpGet]
        [Route("getArea2")]
        public int GetArea(int x)
        {
            var rec = new Rectangle(20, 10);
            return rec.GetArea(x);
        }

        [HttpGet]
        [Route("getSumArea")]
        public int GetSumArea()
        {
            var rec = new Rectangle(20, 10);
            var rec2 = new Rectangle(10, 10);
            var result = rec + rec2;
            return result.GetArea();
        }
    }
}
