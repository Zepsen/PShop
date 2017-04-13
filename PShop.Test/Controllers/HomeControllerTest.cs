using Microsoft.AspNetCore.Mvc;
using PShop.Controllers;
using Xunit;
using Xunit.Abstractions;

namespace PShop.Test.Controllers
{    
    
    public class HomeControllerTest
    {
        private readonly ITestOutputHelper _output;

        public HomeControllerTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void IndexViewResult()
        {
            //arrange
            var ctrl = new HomeController();
            //act
            var res = ctrl.Index();
            //assert
            Assert.IsType(typeof(ViewResult), res);
            _output.WriteLine("Done");

        }
    }
}

