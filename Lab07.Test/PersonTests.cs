﻿using System;
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
            Person person = new Person();
            //Act

            //Assert

        }

        [TestMethod]
        public void APersonMustHaveaName()
        {

        }

        [TestMethod]
        public void TheAgeOfAPersonIsCalculatedCorrectly()
        {

        }
    }
}
