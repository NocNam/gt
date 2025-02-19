using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gt
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name=StudentDBConnectionString")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
