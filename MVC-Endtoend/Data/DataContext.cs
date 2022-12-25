
using Microsoft.EntityFrameworkCore;
using MVC_Endtoend.Models;

namespace MVC_Endtoend.Data
{
    public class DataContext: DbContext 
    {

        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }


        public DbSet<Course> Course { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Payment> Payment { get; set; }

        public DbSet<Users> Users { get; set; }

    }
}
