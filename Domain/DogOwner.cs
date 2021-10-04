using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DogOwner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }

        private List<Dog> dogs;

        public DogOwner()
        {
            dogs = new List<Dog>();
        }

        public IEnumerable<Dog> Dogs()
        {
            return dogs;
        }

        public void AddDog(Dog aDog)
        {
            dogs.Add(aDog);
        }

        public override bool Equals(object obj)
        {
            return this.Name == ((DogOwner)obj).Name;
        }

        public override string ToString()
        {
            return $"{this.Name} ({this.Mobile})";
        }
    }
}
