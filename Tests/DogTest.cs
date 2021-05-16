using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Domain.Exceptions;

namespace Tests
{
    [TestClass]
    public class DogTest
    {
        [TestMethod]
        public void DogHasProperties()
        {
            CreateSharPeiMedium(Dog.BreedSize.Medium);
        }

        private Dog CreateSharPeiMedium(Dog.BreedSize aSize)
        {
            Dog dog = new Dog();
            dog.Name = "Beto";
            dog.Breed = "Shar-Pei";
            dog.Size = aSize;

            return dog;
        }

        [TestMethod]
        [DataRow(Dog.BreedSize.Medium, "Mediano")]
        [DataRow(Dog.BreedSize.Small, "Pequeño")]
        [DataRow(Dog.BreedSize.XSmall, "Miniatura")]
        [DataRow(Dog.BreedSize.Large, "Grande")]
        [DataRow(Dog.BreedSize.XLarge, "Gigante")]
        public void DogToStringFormat(Dog.BreedSize aSize, string expectedSize)
        {
            var dog = CreateSharPeiMedium(aSize);

            Assert.AreEqual(
                "Beto de raza: Shar-Pei y tamaño: " + expectedSize + ".",
                dog.ToString()
            );
        }



        [TestMethod]
        [ExpectedException(typeof(NameTooLongException))]
        public void NameShouldNotExceed10Chars()
        {
            Dog dog = new Dog();
            dog.Name = "BetoBetoBeto";
        }
    }
}
