using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiTest.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    public class DatabaseController : Controller
    {
        [HttpGet("[action]")]
        public List<DataBaseModel> GetAll()
        {
            return DataBaseModel.GetAll();

        }
    }
}
