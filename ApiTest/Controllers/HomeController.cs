using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<AdminEntry> AdminEntrys()
        {
            return Enumerable.Range(1, 5).Select(index => new AdminEntry
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                Id = 1,
                UserName = "Jimmy",
                PassWord = "1234"
            }) ;
        }

        public class AdminEntry
        {
            public string DateFormatted { get; set; }
            public int Id { get; set; }
            public string UserName { get; set; }
            public string PassWord { get; set; }
        }

    }
}
