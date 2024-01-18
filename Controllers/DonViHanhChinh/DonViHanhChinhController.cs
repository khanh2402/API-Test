
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using API.ILIS.Models.DonViHanhChinh;

namespace API.ILIS.Controllers.khanhdd.pto
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonViHanhChinhController : ControllerBase
    {
        [HttpPost("ThemDonViHanhChinh")]
        public JToken API1(API1 api1)
        {
            return "[\"907F2578630844B3A175AB600944E88E\",\"ABCB1772A74642C0B3F2FF16AA6CD951\",\"D8848CCE88E44E93B83B0B662F3DD952\",\"DBA81E7E7A124B66B4E1D6B07FCC9912\"]";
        }

        [HttpPost("SuaDonViHanhChinh")]
        public JToken API2(API1 api1)
        {
            return "Thành công";
        }
    }
}
