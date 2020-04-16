using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FInalAssignmentAPI
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    
    public class CoronaDataController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        private List<Data> coronaData = new List<Data>()
        {


new Data {Code = "PE",City = "Prince Edward Island", ConfirmedCases = 25, ProbableCases = 0, Deaths = 0,Year = 2019},
new Data {Code = "NS",City = "Nova Scotia", ConfirmedCases = 474, ProbableCases = 0, Deaths = 0,Year = 2020},
new Data {Code = "NB",City = "New Brunswick", ConfirmedCases = 116, ProbableCases = 0, Deaths = 0,Year = 2020},
new Data {Code = "QC",City = "Quebec", ConfirmedCases = 13557, ProbableCases = 0, Deaths = 360,Year = 2019},
new Data {Code = "ON",City = "Ontario", ConfirmedCases = 7953, ProbableCases = 0, Deaths = 334,Year = 2019},
new Data {Code = "MB",City = "Manitoba", ConfirmedCases = 229, ProbableCases = 17, Deaths = 0,Year = 2019},
new Data {Code = "SK",City = "Saskatchewan", ConfirmedCases = 300, ProbableCases = 0, Deaths = 4,Year = 2019},
new Data {Code = "AB",City = "Alberta", ConfirmedCases = 1732, ProbableCases = 0, Deaths = 46,Year = 2019},
new Data {Code = "BC",City = "British Columbia", ConfirmedCases = 1490, ProbableCases = 0, Deaths = 69,Year = 2019},
new Data {Code = "YT",City = "Yukon", ConfirmedCases = 8, ProbableCases = 0, Deaths = 0,Year = 2019},
new Data {Code = "NT",City = "Northwest Territories", ConfirmedCases = 5, ProbableCases = 0, Deaths = 0,Year = 2019},
new Data {Code = "NU",City = "Nunavut", ConfirmedCases = 0, ProbableCases = 0, Deaths = 0,Year = 2019},
new Data {Code = "RT",City = "Repatriated travellers", ConfirmedCases = 13, ProbableCases = 0, Deaths = 0,Year = 2019}
 };


        //Get Api with secure end point
        [HttpGet]
        public IEnumerable<Data> Get()
        {

            return coronaData;
        }

        //Get one API with secure endpoint and role
        [HttpGet]
        [Route("{Code}")]
        [Authorize(Roles = "Admin")]
        public Data Get(string code)
        {

            return coronaData.Find(a => a.Code == code);
        }
    }



}
