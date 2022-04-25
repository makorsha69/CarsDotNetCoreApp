using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsDotNetCore.BAL.Services;
using CarsDotNetCore.Entity;

namespace CarsDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsDetailsController : ControllerBase
    {
        private CarsDetailsServices cars;
        public CarsDetailsController(CarsDetailsServices carsDetails)
        {
            cars = carsDetails;
        }
        [HttpPost("SaveCar")]
        public IActionResult SaveCars(CarsDetails carsDetails)
        {
            return Ok(cars.SaveCars(carsDetails));
        }

        [HttpPost("DeleteCar")]
        public IActionResult DeleteCars(int CarId)
        {
            return Ok(cars.DeleteCars(CarId));
        }

        [HttpPost("UpdateCar")]
        public IActionResult UpdateCars(CarsDetails carsDetails)
        {
            return Ok(cars.UpdateCars(carsDetails));
        }

        [HttpGet("GetCar")]
        public IActionResult GetCars(int CarsId)
        {
            return Ok(cars.GetCars(CarsId));
        }

        [HttpGet("GetAllCars")]
        public List<CarsDetails> GetAllCars()
        {
            return cars.GetAllCars();
        }
    }
}
