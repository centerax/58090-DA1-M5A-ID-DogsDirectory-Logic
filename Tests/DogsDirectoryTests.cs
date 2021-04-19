using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class DogsDirectoryTests
    {
        [TestMethod]
        public void AddOwner()
        {
            DogOwner owner = new DogOwner();
            owner.Name = "John";

            DogsDirectory directory = new DogsDirectory();
            directory.AddOwner(owner);

            Assert.AreEqual(1, directory.Owners().Count());

            DogOwner ownerJohn = directory.Owners().First(x => x.Name == "John");
            Assert.AreEqual("John", ownerJohn.Name);
        }

        [TestMethod]
        public void AddDogWithOwner()
        {
            DogOwner owner = new DogOwner() { Name = "John" };
            Dog dog = new Dog() { Name = "Beethoven" };

            DogsDirectory directory = new DogsDirectory();
            directory.AddOwner(owner);
            directory.AddDog(owner, dog);

            Assert.AreEqual(1, directory.Owners().First(x => x.Name == "John").Dogs().Count());
        }
    }
}
