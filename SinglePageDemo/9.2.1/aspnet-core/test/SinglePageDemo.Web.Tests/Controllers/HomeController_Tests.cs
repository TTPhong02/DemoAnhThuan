using System.Threading.Tasks;
using SinglePageDemo.Models.TokenAuth;
using SinglePageDemo.Web.Controllers;
using Shouldly;
using Xunit;

namespace SinglePageDemo.Web.Tests.Controllers
{
    public class HomeController_Tests: SinglePageDemoWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}