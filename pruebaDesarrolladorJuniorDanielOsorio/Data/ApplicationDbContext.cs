using Microsoft.EntityFrameworkCore;
using pruebaDesarrolladorJuniorDanielOsorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaDesarrolladorJuniorDanielOsorio.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Empleado> Empleado { get; set; }
    }
}
