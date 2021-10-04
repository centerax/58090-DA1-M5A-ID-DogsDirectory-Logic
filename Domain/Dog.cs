using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Exceptions;

namespace Domain
{
    public class Dog
    {
        public DogOwner Owner { get; set; }

        public int Id { get; set; }

        public enum BreedSize { XSmall, Small, Medium, Large, XLarge };

        private const int MaxNameLength = 10;

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                ValidateNameLength(value);
                name = value;
            }
        }

        private static void ValidateNameLength(string aName)
        {
            if (aName.Length > MaxNameLength)
                throw new NameTooLongException("El nombre de la mascota es demasiado largo.");
        }

        public BreedSize Size { get; set; }
        public string Breed { get; set; }

        public override string ToString()
        {
            string size = TranslateDogSize();

            return $"{this.Name} de raza: {this.Breed} y tamaño: {size}.";
        }

        private string TranslateDogSize()
        {
            var size = string.Empty;

            if (IsDogMedium())
            {
                size = "Mediano";
            }

            if (IsDogSuperSmall())
            {
                size = "Miniatura";
            }

            if (IsDogSMall())
            {
                size = "Pequeño";
            }

            if (IsDogLarge())
            {
                size = "Grande";
            }

            if (IsDogEnormous())
            {
                size = "Gigante";
            }

            return size;
        }

        private bool IsDogEnormous()
        {
            return this.Size == Dog.BreedSize.XLarge;
        }

        private bool IsDogLarge()
        {
            return this.Size == Dog.BreedSize.Large;
        }

        private bool IsDogSMall()
        {
            return this.Size == Dog.BreedSize.Small;
        }

        private bool IsDogSuperSmall()
        {
            return this.Size == Dog.BreedSize.XSmall;
        }

        private bool IsDogMedium()
        {
            return this.Size == Dog.BreedSize.Medium;
        }
    }
}
