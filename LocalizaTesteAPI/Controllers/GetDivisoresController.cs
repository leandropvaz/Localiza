using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace LocalizaTesteAPI.Controllers
{


    public class GetDivisoresController : ControllerBase
    {
        private readonly ILogger<GetDivisoresController> _logger;

        public GetDivisoresController(ILogger<GetDivisoresController> logger)
        {
            _logger = logger;
        }

        [Route("GetDivisores/{valor}")]
        [HttpGet]
        public JsonResult GetDivisores(int valor)
        {
                UtilsMath.Math math = new UtilsMath.Math();
                string json = JsonConvert.SerializeObject(math.GetDivisores(valor), Formatting.None);
                return new JsonResult(json);
        }

        [Route("GetDivisoresPrimo/{valor}")]
        [HttpGet]
        public JsonResult GetDivisoresPrimo(int valor)
        {
            UtilsMath.Math math = new UtilsMath.Math();

            string json = JsonConvert.SerializeObject(math.GetDivisoresPrimo(valor), Formatting.None);

            return new JsonResult(json);
        }
    }
}
