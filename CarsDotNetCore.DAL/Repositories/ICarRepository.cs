using CarsDotNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;


namespace CarsDotNetCore.DAL.Repositories
{
    public interface ICarsRepository
    {
        public string SaveCars(CarsDetails CarsDetails);
        public string UpdateCars(CarsDetails CarsDetails);
        public string DeleteCars(int CarId);
        CarsDetails GetCars(int CarId);
        List<CarsDetails> GetAllCars();

    }
}
