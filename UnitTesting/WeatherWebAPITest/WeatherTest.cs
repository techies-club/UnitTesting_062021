using BusinessLibrary.Abstract;
using BusinessLibrary.Implementation;
using CoreWebAPI_UnitTesting;
using CoreWebAPI_UnitTesting.Controllers;
using Ninject;
using NUnit.Framework;
using System.Collections.Generic;
using WeatherWebAPITest.Mock;

namespace WeatherWebAPITest
{
    public class WeatherTest
    {
        ILogin login;
        StandardKernel kernel = new StandardKernel();
        [SetUp]
        public void Setup()
        {
            login = new SQLLogin(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = RNDDB2; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

            kernel.Bind<ILogin>().To<LoginMock>();
        }

        [Test]
        public void Test_WeatherService_WithoutMock() //Tightly coupled test case
        {
            //Arrange            
            var controller = new WeatherForecastController(login);// new Logger<TestMethod>);
            //Act
            var result = controller.Get("ks","shukla");
            //Assert          
            Assert.IsTrue(result.Count > 0);
            Assert.IsTrue(result[0].GetType() == typeof(WeatherForecast));         
        }

        [Test]
        public void Test_WeatherService_WithMock()
        {
            //Arrange          
            var controller = new WeatherForecastController(kernel.Get<ILogin>());
            //Act
            var result = controller.Get("xxx", "xxxx");
            //Assert          
            Assert.IsTrue(result.Count > 0);
            Assert.IsTrue(result[0].GetType() == typeof(WeatherForecast));
        }
    }
}