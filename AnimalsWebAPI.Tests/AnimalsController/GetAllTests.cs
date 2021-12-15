using AnimalsWebAPI.Controllers;
using AnimalsWebAPI.Data.Entities;
using AnimalsWebAPI.DTOs;
using AnimalsWebAPI.Repos;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWebAPI.Tests.AnimalsController
{
    [TestFixture]
    public class GetAllTests
    {
        private AnimalController _controller;
        private Mock<IAnimalRepo> _animalRepoMock;
        private AnimalsControllerTestData _testData;

        [SetUp]
        public void SetUp()
        {
            _animalRepoMock = new Mock<IAnimalRepo>();
            _testData = new AnimalsControllerTestData();
        }

        //[Test]
        //public void ReturnsCorrectAmountOfAnimals()
        //{
        //    // Arrange
        //    _animalRepoMock.Setup(x => x.GetAll())
        //        .Returns(_testData.threeAnimals);
        //    _controller = new AnimalController(_animalRepoMock.Object);

        //    IActionResult result = _controller.GetAll();
            
        //    OkObjectResult okResult = result as OkObjectResult;
        //    Assert.IsNotNull(okResult);
            
        //    List<AnimalDTO> animalsFromMock = okResult.Value as List<AnimalDTO>;
        //    Assert.IsNotNull(animalsFromMock);
        //    Assert.That(animalsFromMock.Count, Is.EqualTo(3));
        //}

        //[Test]
        //public void ReturnsCorrectObjectAtIndexZero()
        //{

        //}


    }
}
