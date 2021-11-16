using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_SQLite_WPF
{
    public class DataDBContext : DbContext
    {
        public DbSet<Person> PersonData { get; set; }
        public DataDBContext(DbContextOptions<DataDBContext> options) : base(options) { }

    }
}
