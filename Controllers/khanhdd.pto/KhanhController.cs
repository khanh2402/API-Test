
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using API.ILIS.Models.khanhpto;

namespace API.ILIS.Controllers.khanhdd.pto
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhanhController : ControllerBase
    {
        [HttpPost("/api-1")]
        public JToken API1(API1 api1)
        {
            return "Thành công";
        }

        [HttpPost("/api-2")]
        public JToken API2(API1 api1)
        {
            return "Thành công";
        }
    }
}
