//using System;
//using System.Collections.Generic;
//using Microsoft.AspNetCore.Mvc;
//using ApiTest.Models;

//namespace ApiTest.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ValuesController : Controller
//    {
//        // GET: api/values
//        [HttpGet]
//        public IEnumerable<List<string>> Get()
//        {

//            var list = DataBaseModel.GetAll();
//            return IEnumerable<List>list;
//        }

//        // GET api/values/5
//        [HttpGet("{id}")]
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST api/values
//        [HttpPost]
//        public void Post([FromBody]string value)
//        {
//        }

//        // PUT api/values/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody]string value)
//        {
//        }

//        // DELETE api/values/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}
