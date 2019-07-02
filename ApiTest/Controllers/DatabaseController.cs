﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiTest.Models;


namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    public class DatabaseController : Controller
    {
        [HttpGet("[action]")]
        public List<DataBaseModel> GetAlls()
        {
            return DataBaseModel.GetAll();

        }
    }
}
