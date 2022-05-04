using Microsoft.AspNetCore.Mvc;
using pos_core_api.Helpers;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pos_core_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        // GET: ConfigController/Details/5
        [HttpGet()]
        public ActionResult Get(string key = null)
        {
            try
            {
                if(key == null)
                    return Ok(Resources.GetValues());
                else
                    return Ok(Resources.GetValue(key));
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }

        // POST: ConfigController/Create
        [HttpPost()]
        public ActionResult Post(string key, [FromBody] string value)
        {
            try
            {
                Resources.SetValue(key, value);
                return Ok();
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); return StatusCode(500, ex.Message); }
        }
    }
}
