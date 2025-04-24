using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrudCLI
{
    public class StudentContext : DbContext
    {
        public DbSet<Model> Students { get; set; }
        public StudentContext() : base("name = StudentDB")
        {

        }
    }
}
