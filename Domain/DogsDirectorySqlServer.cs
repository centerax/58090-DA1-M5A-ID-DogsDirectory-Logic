using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DogsDirectorySqlServer
    {
        public void AddOwner(DogOwner aDogOwner)
        {
            using (DogsDirectoryContext dbContext = new DogsDirectoryContext())
            {
                dbContext.Owners.Add(aDogOwner);

                dbContext.SaveChanges();
            }
        }

        public IEnumerable<DogOwner> Owners()
        {
            using (DogsDirectoryContext dbContext = new DogsDirectoryContext())
            {
                return dbContext.Owners.ToList();
            }
        }

        public void AddDog(DogOwner aDogOwner, Dog aDog)
        {
            using (DogsDirectoryContext dbContext = new DogsDirectoryContext())
            {
                aDog.Owner = dbContext.Owners.First(owner => owner.Id == aDogOwner.Id);

                dbContext.Dogs.Add(aDog);

                dbContext.SaveChanges();
            }
        }

        public IEnumerable<Dog> DogsForOwner(DogOwner aDogOwner)
        {
            using (DogsDirectoryContext dbContext = new DogsDirectoryContext())
            {
                var dogs = dbContext.Dogs
                     .Where(dog => dog.Owner.Id == aDogOwner.Id)
                     .ToList();

                return dogs;
            }
        }
    }
}
