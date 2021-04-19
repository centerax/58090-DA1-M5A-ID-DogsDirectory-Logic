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
            CreateSharPeiDog();
        }

        private Dog CreateSharPeiDog()
        {
            Dog dog = new Dog();
            dog.Name = "Beto";
            dog.Breed = "Shar-Pei";
            dog.Size = Dog.BreedSize.Medium;

            return dog;
        }

        [TestMethod]
        public void DogToStringFormat()
        {
            var dog = CreateSharPeiDog();

            Assert.AreEqual("Beto de raza: Shar-Pei y tamaño: Mediano.", dog.ToString());
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
