using CarsDotNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using CarsDotNetCore.DAL.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CarsDotNetCore.DAL.Repositories
{
    public class CarsRepository : ICarsRepository
    {
        private CarsDbContext carsDb;
        public CarsRepository(CarsDbContext carsDbContext)
        {
            carsDb = carsDbContext;
        }
        public string DeleteCars(int CarId) //For Deleting 
        {
            string msg = "";
            CarsDetails deletecars = carsDb.CarsDetails.Find(CarId);//storing the details of the movie in the obj 
            if (deletecars != null)
            {
                carsDb.CarsDetails.Remove(deletecars);
                carsDb.SaveChanges();
                msg = "Deleted";
            }
            return msg;
        }
         public List<CarsDetails> GetAllCars() //For getting list of all cars
        {
            List<CarsDetails> _alldetails = carsDb.CarsDetails.ToList();
            return _alldetails;
        }

        public CarsDetails GetCars(int CarId) //For getting details of a single car with ID
        {
            CarsDetails carsobj = carsDb.CarsDetails.Find(CarId);
            return carsobj;
        }

        public string SaveCars(CarsDetails CarsDetails)
        {
            carsDb.CarsDetails.Add(CarsDetails);
            carsDb.SaveChanges();
            return "SAVED";
        }

        public string UpdateCars(CarsDetails CarsDetails)
        {
            carsDb.Entry(CarsDetails).State = EntityState.Modified;
            carsDb.SaveChanges();
            return "UPDATED";
        }
    }
}
