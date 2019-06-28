using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTest.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace ApiTest.Controllers
{
    public class DataBaseAPIController : Controller
    {
            public List<DataBaseModel> GetAll()
            {
                return DataBaseModel.GetAll();

            }
        }
 }
