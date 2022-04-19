using System;
using System.Collections.Generic;
using System.Text;
using CarsDotNetCore.DAL.Repositories;
using CarsDotNetCore.Entity;

namespace CarsDotNetCore.BAL.Services
{
    public class CarsDetailsServices
    {
        private ICarsRepository _carsRepository;
        public CarsDetailsServices(ICarsRepository carsRepository)
        {
            _carsRepository = carsRepository;
        }
        public string SaveCars(CarsDetails cars)
        {
            return _carsRepository.SaveCars(cars);
        }
        public string DeleteCars(int CarId)
        {
            return _carsRepository.DeleteCars(CarId);
        }
        public CarsDetails GetCars(int CarId)
        {
            return _carsRepository.GetCars(CarId);
        }
        public string UpdateCars(CarsDetails cars)
        {
            return _carsRepository.UpdateCars(cars);
        }
        public List<CarsDetails> GetAllCars()
        {
            return _carsRepository.GetAllCars();
        }
    }
}
