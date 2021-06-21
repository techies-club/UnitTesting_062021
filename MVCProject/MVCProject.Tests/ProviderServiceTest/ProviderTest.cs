using Microsoft.VisualStudio.TestTools.UnitTesting; //MS test
using MVCProject.Models;
using MVCProject.Repository;
using MVCProject.Service;
//using NUnit.Framework; //NUnit
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Tests.ProviderServiceTest
{
    [TestClass]
    public class ProviderTest
    {
        ProviderService providerService;
        ProviderRepository medflowContext;
        [TestInitialize]
        public void ProviderTestInitialize()
        {
            medflowContext = new ProviderRepository();
        }

        [TestMethod]
        public void ProviderIndex_Returns_allRows() //Postive
        {
            //Arrange
            providerService = new ProviderService();

            //Act
            var actual = providerService.GetProvidersForIndex();

            //Assert
            //Check: If total number of providers count is same to what my repository returns me
            Assert.AreEqual(medflowContext.Providers.Count(), actual.Count,"Not all providers are fetched");
        }

        [TestMethod]
        public void ProviderIndex_Returns_No_Less_No_More() //Negative testing
        {
            //Arrange
            providerService = new ProviderService();

            //Act
            var actual = providerService.GetProvidersForIndex();

            //Assert
            Assert.IsFalse(medflowContext.Providers.Count() < actual.Count);
            Assert.IsFalse(medflowContext.Providers.Count() > actual.Count);
        }

        [TestMethod]
        public void ProviderDetail_GetByID() //Positive & Negative
        {
            //Arrange
            int id = 100;
            providerService = new ProviderService();
            var actualName = "AK";
            //Act
           var provider = providerService.GetProvidersById(id);

            //Assert            
            Assert.AreEqual(actualName, provider.ProviderName);
            Assert.IsNotNull(provider);
            Assert.IsInstanceOfType(provider, typeof(Provider));            
        }

       
    }
}
