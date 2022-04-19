using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarsDotNetCore.Entity
{
    public class CarsDetails
    {
        [Key] //Creating Primary Key Column
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Creating Identity Column
        public int CarId { get; set; }

        public string Company { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }
    }
}
