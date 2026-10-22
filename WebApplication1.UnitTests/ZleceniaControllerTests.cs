using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Security.Claims;
using WebApplication1.Controllers;
using WebApplication1.Repositories.User;
using WebApplication1.Repositories.User.DTO;
using WebApplication1.Repositories.Zlecenia;
using WebApplication1.Tools;

namespace WebApplication1.UnitTests
{
    public class ZleceniaControllerTests
    {
        // Mock repozytorium użytkowników.
        private readonly Mock<IZlecenia_Repository> _zleceniaRepositoryMock;

        // Kontroler, którego metodę będziemy testować.
        private readonly ZleceniaController _zlecenia_controller;


        public ZleceniaControllerTests()
        {
            // Tworzymy atrapę repozytorium
            _zleceniaRepositoryMock = new Mock<IZlecenia_Repository>();

            // Tworzymy kontroler i przekazujemy mu mock
            _zlecenia_controller = new ZleceniaController(_zleceniaRepositoryMock.Object);
        }



        [Fact]
        public async Task DeleteZlecenie_WhenUserIsAdmin_NoContentResult()
        {
            // ARRANGE

            // Przygotowujemy użytkownika z poprawnym ID w claims.
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, "123")
                };


            // Tworzymy tożsamość użytkownika. "TestAuthentication" to nazwa schematu uwierzytelniania używana w tym teście.
            var identity = new ClaimsIdentity(
                claims,
                "TestAuthentication"
               );

            _zlecenia_controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext
                {
                    User = new ClaimsPrincipal(identity)
                }
            };


            // Symulujemy sytuację, w której repozytorium nie znajduje użytkownika o ID 123.
            _zleceniaRepositoryMock
                .Setup(x => x.Delete_Zlecenia_Async(1, 123))
                .ReturnsAsync(
                    Result.Ok()
                );

            // ACT

            // Wywołujemy metodę kontrolera.
            var result = await _zlecenia_controller.DeleteZlecenie(1);





            // ASSERT

            // Sprawdzamy, czy kontroler zwrócił HTTP NoContent.
            Assert.IsType<NoContentResult>(result);


        }

        [Fact]
        public async Task DeleteZlecenie_WhenUserIsAdmin_BadRequestResult()
        {
            // ARRANGE

            // Przygotowujemy użytkownika z poprawnym ID w claims.
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, "123")
                };


            // Tworzymy tożsamość użytkownika. "TestAuthentication" to nazwa schematu uwierzytelniania używana w tym teście.
            var identity = new ClaimsIdentity(
                claims,
                "TestAuthentication"
               );

            _zlecenia_controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext
                {
                    User = new ClaimsPrincipal(identity)
                }
            };


            // Symulujemy sytuację, w której repozytorium nie znajduje użytkownika o ID 123.
            _zleceniaRepositoryMock
                .Setup(x => x.Delete_Zlecenia_Async(1, 123))
                .ReturnsAsync(
                    Result<int>.Fail("Test Error", ErrorType.Validation)
                );

            // ACT

            // Wywołujemy metodę kontrolera.
            var result = await _zlecenia_controller.DeleteZlecenie(1);





            // ASSERT

            // Sprawdzamy, czy kontroler zwrócił HTTP BadRequestObjectResult.
            Assert.IsType<BadRequestObjectResult>(result);


        }

    }
}
