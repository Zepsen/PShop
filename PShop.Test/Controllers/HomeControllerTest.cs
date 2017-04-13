using Microsoft.AspNetCore.Mvc;
using PShop.Controllers;
using Xunit;

namespace PShop.Test.Controllers
{    
    class HomeControllerTest
    {
        [Fact]
        public void IndexViewNameIndex()
        {
            //arrange
            var ctrl = new HomeController();
            //act
            var res = ctrl.Index() as ViewResult;
            //assert
            Assert.Equal("Index", res?.ViewName);

        }
    }
}
