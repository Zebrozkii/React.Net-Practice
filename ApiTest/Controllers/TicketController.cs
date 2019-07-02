using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiTest.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    public class TicketController : Controller
    {
        // GET: api/values
        [HttpGet("[action]")]
        public List<TicketModel> GetAlls()
        {
            return TicketModel.GetAll();

        }
    }
}
