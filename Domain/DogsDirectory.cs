using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DogsDirectory
    {
        private List<DogOwner> owners;

        public DogsDirectory()
        {
            owners = new List<DogOwner>();
        }

        public void AddOwner(DogOwner aDogOwner)
        {
            owners.Add(aDogOwner);
        }

        public IEnumerable<DogOwner> Owners()
        {
            return owners;
        }

        public void AddDog(DogOwner aDogOwner, Dog aDog)
        {
            DogOwner owner = owners.FirstOrDefault(x => x.Equals(aDogOwner));

            if (owner != null)
            {
                owner.AddDog(aDog);
            }
        }
    }
}
