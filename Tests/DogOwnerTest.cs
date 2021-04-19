using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Tests
{
    [TestClass]
    public class DogOwnerTest
    {
        private const string DogOwnerName = "John";
        private const string DogOwnerMobile = "+598951234567";

        [TestMethod]
        public void OwnerHasProperties()
        {
            MakeDummyOwner();
        }

        private DogOwner MakeDummyOwner()
        {
            DogOwner owner = new DogOwner();
            owner.Name = DogOwnerName;
            owner.Mobile = DogOwnerMobile;
            owner.Address = "Rambla 0123";

            return owner;
        }

        [TestMethod]
        public void VerifyTwoOwnersAreTheSameByName()
        {
            var ownerFoo = new DogOwner { Name = DogOwnerName };
            var ownerBar = new DogOwner { Name = DogOwnerName };

            Assert.AreEqual(ownerFoo, ownerBar);
        }

        [TestMethod]
        public void AddOneDogTest()
        {
            var dog = new Dog();

            var owner = new DogOwner { Name = DogOwnerName };

            owner.AddDog(dog);

            Assert.AreEqual(1, owner.Dogs().Count());
        }

        [TestMethod]
        public void OwnerToStringTest()
        {
            var owner = MakeDummyOwner();

            Assert.AreEqual("John (+598951234567)", owner.ToString());
        }
    }
}
