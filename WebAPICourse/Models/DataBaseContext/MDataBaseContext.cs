using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICourse.Models.DatabaseContext
{
    public class MDataBaseContext : DbContext
    {
        public MDataBaseContext(DbContextOptions<MDataBaseContext> options)
            : base(options)
        {

        }

        public DbSet<Messages> Messages { get; set; }
    }
}
