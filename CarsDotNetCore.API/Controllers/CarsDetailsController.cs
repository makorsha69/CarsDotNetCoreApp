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
        [HttpPost("Save Cars")]
        public IActionResult SaveMovie(CarsDetails carsDetails)
        {
            return Ok(cars.SaveCars(carsDetails));
        }

        [HttpPost("Delete Car")]
        public IActionResult DeleteMovie(int CarId)
        {
            return Ok(cars.DeleteCars(CarId));
        }

        [HttpPost("Update Cars")]
        public IActionResult UpdateMovie(CarsDetails carsDetails)
        {
            return Ok(cars.UpdateCars(carsDetails));
        }

        [HttpGet("Get Cars")]
        public IActionResult GetMovie(int CarsId)
        {
            return Ok(cars.GetCars(CarsId));
        }

        [HttpGet("Get All Cars")]
        public List<CarsDetails> GetAllCars()
        {
            return cars.GetAllCars();
        }
    }
}
