using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace RedisPoC.Controllers
{
    [Route("api/[controller]/[action]")]
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
            _database.StringSet(KeyValue.Key, KeyValue.Value);

            //sample data
            //    {
            //        "Key":"test",
            //        "Value":"test1"
            //    }

        }

        // POST api/Redis
        [HttpPost]
        public List<RedisValue> PostList1([FromBody] List<KeyValuePair<string, string>> ListValues)
        {

            foreach (var item in ListValues)
            {
                _database.ListRightPush(item.Key, item.Value);
            }

            var values = _database.ListRange("test1", 0, 10);
            return values.ToList();

            //ListLeftPush son eklenen ilk indexe sahip olur
            //ListRightPush ilk eklenen ilk indexe sahip olur

            //sample data
            //[{"Key":"test1","Value":"test1"},
            //{"Key":"test1","Value":"test2"},
            //{"Key":"test1","Value":"test3"}]

        }

        // POST api/Redis
        [HttpPost]
        public string PostList2([FromBody] List<string> ListValues)
        {
            var list = JsonConvert.SerializeObject(ListValues);
            _database.StringSet("list5", list);

            var values = _database.StringGet("list5");
            return values;

            //sample data
            //["bugra","anil","furkan"]
        }

        // DEL api/Redis
        [HttpDelete]
        public void Delete([FromQuery] string key)
        {
            _database.KeyDelete(key);
        }

        

        // DEL api/Redis
        [HttpDelete]
        public void DeleteAll()
        {
            var _connectionMultiplexer = ConnectionMultiplexer.Connect("localhost,allowAdmin=true");
            var endpoints = _connectionMultiplexer.GetEndPoints(true);
            foreach (var endpoint in endpoints)
            {
                var server = _connectionMultiplexer.GetServer(endpoint);
                server.FlushAllDatabases();
            }
        }
    }
}
