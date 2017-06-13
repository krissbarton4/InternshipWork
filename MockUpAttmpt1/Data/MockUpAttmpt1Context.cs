using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MockUpAttmpt1.Models
{
    public class MockUpAttmpt1Context : DbContext
    {
        public MockUpAttmpt1Context (DbContextOptions<MockUpAttmpt1Context> options)
            : base(options)
        {
        }

        public DbSet<MockUpAttmpt1.Models.Movie> Movie { get; set; }
    }
}
