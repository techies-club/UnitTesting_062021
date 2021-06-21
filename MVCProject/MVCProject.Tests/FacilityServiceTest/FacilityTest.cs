using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using MVCProject.Interface;
using MVCProject.Tests.Moq;
using MVCProject.Service;
using MVCProject.Models;

namespace MVCProject.Tests
{

    [TestClass]
    public class FacilityTest
    {
        readonly FacilityRepositoryMoq facilityMoq = new FacilityRepositoryMoq();
        Mock<IFacilityRepository> mockFacility;

        [TestInitialize]
        public void Initialize()
        {
            mockFacility = new Mock<IFacilityRepository>();
            mockFacility.Setup(m => m.GetFacilities()).Returns(facilityMoq.GetFacilities());
        }

        [TestMethod]
        public void TestFacilities_Index()
        {
            //Arrange       
            var facilityService = new FacilityService(mockFacility.Object);
            //Act
            var actual = facilityService.GetFacilities().Count;
            //Assert
            Assert.AreEqual(actual, 3);
        }

        [TestMethod]
        public void TestFacilities_ByZipCode()
        {
            //Arrange       
            var facilityService = new FacilityService(mockFacility.Object);
            var zipTotest = "70008";            
            //Act
            var actual = facilityService.GetFacilitiesForZip(zipTotest);           
            //Assert
            Assert.AreEqual(actual.Count, 1);            
        }

        //Negative Tests cases here..............
    }
}
