using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GC_CodeFirstDBLab.Context
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public bool Transmission { get; set; }


    }

    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public CarContext(DbContextOptions options) : base(options) { }
    }
}
