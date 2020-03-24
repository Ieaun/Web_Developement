using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCMovie__.Models;

namespace MVCMovie__.Data
{
    public class MVCMovie__Context : DbContext
    {
        public MVCMovie__Context (DbContextOptions<MVCMovie__Context> options)
            : base(options)
        {
        }

        public DbSet<MVCMovie__.Models.Movie> Movie { get; set; }
    }
}
