using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public  class ApDBContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=GULCHOHRA\\SQLEXPRESS;Database=StudentApp;Trusted_Connection=true;Integrated Security=true;Encrypt=false;TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
