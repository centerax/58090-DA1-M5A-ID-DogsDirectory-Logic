using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace Domain
{
    public class DogsDirectoryContext : DbContext
    {
        public DbSet<DogOwner> Owners { get; set; }
        public DbSet<Dog> Dogs { get; set; }
    }
}
