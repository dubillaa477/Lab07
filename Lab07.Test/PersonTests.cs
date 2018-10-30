using System;
using BusinessLogic;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab07.Test
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void APersonIsCreated()
        {
            //Arrange
            PersonBL logic = new PersonBL();
            Person person = new Person()
            {
                Id = 1,
                Name = "Daniel",
                BirthDay = DateTime.Now

            };
            //Act
            logic.Create(person);
            Person saved = logic.GetbyId(1);

            //Assert
            Assert.IsNotNull(saved, "Person not null");
        }

        [TestMethod]
        public void APersonMustHaveaName()
        {
            //Arrange
            PersonBL logic = new PersonBL();
            Person person = new Person() {
                Id=1,
                Name ="",
                BirthDay=DateTime.Now
            };
            //Act & Assert
            //Aca dice, hacer que la funcion pasada por parametro retorne una excepcion
            Assert.ThrowsException<ArgumentException>(()=>logic.Create(person));
          

        }

        [TestMethod]
        public void TheAgeOfAPersonIsCalculatedCorrectly()
        {
            //Arrange
            Person person = new Person()
            {
                BirthDay = new DateTime(1998, 04, 05)
            };

            //Act & Assert
            Assert.AreEqual(20, person.Age(person.BirthDay));
        }
    }
}
