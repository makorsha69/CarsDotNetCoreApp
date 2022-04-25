using CarsDotNetCore.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CarsDotNetCore.UI.Controllers
{
    public class CarsDetailsController : Controller
    {
        private IConfiguration configuration;
        public CarsDetailsController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SaveCars()
        {
            return View();
        }
        public IActionResult GetCar()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> SaveCars(CarsDetails carsDetails)
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(carsDetails), Encoding.UTF8, "application/Json");
                String endpoint = configuration["WebApiBaseUrl"] + "CarsDetails/SaveCars";
                using(var response = await client.PostAsync(endpoint, content))
                {
                    if(response.StatusCode==System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.Status = "OK";
                        ViewBag.Message = "Car Details Saved";
                    }
                    else
                    {
                        ViewBag.Status = "Error";
                        ViewBag.Message = "Wrong Entries";
                    }
                }
            }
            return View();
        }
    }
}
