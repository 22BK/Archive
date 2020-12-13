using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using StackExchange.Redis;

namespace RedisPoC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedisController : ControllerBase
    {
        private readonly IDatabase _database;

        public RedisController(IDatabase database)
        {
            _database = database;
        }

        

        // GET api/Redis
        [HttpGet]
        public string Get([FromQuery]string key)


        {
            var value = _database.StringGet(key);
            return value;
        }

       

        // POST api/Redis
        [HttpPost]
        public void Post([FromBody] KeyValuePair<string, string> KeyValue)
        {
            _database.StringSet(KeyValue.Key,KeyValue.Value);
        }
        
    }
}
