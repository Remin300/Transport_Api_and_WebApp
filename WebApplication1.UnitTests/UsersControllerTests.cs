using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Security.Claims;
using WebApplication1.Controllers;
using WebApplication1.Repositories.User;
using WebApplication1.Repositories.User.DTO;
using WebApplication1.Tools;

namespace WebApplication1.UnitTests
{
    public class UsersControllerTests
    {
        // Mock repozytorium użytkowników.
        private readonly Mock<IUserRepository> _usersRepositoryMock;

        // Kontroler, którego metodę będziemy testować.
        private readonly UsersController _controller;

        public UsersControllerTests()
        {
            // Tworzymy atrapę repozytorium
            _usersRepositoryMock = new Mock<IUserRepository>();

            // Tworzymy kontroler i przekazujemy mu mock
            _controller = new UsersController(
                _usersRepositoryMock.Object
            );
        }

        [Fact]
        public async Task GetMyProfile_WhenUserIdIsMissing_ReturnsUnauthorized()
        {
            // ==========================================
            // ARRANGE - przygotowanie testu
            // ==========================================

            // Tworzymy pustą listę claims. Nie ma w niej ClaimTypes.NameIdentifier, czyli identyfikatora zalogowanego użytkownika.
            var claims = new List<Claim>();

            // Tworzymy tożsamość użytkownika. "TestAuthentication" to nazwa schematu uwierzytelniania używana w tym teście.
            var identity = new ClaimsIdentity(
                claims,
                "TestAuthentication"
            );

            // Tworzymy obiekt reprezentujący użytkownika.
            var principal = new ClaimsPrincipal(identity);

            // Przypisujemy użytkownika do kontekstu kontrolera.W normalnym żądaniu HTTP framework ustawia User na podstawie uwierzytelnienia.
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext
                {
                    User = principal
                }
            };

            // ==========================================
            // ACT - wykonanie testowanej metody
            // ==========================================

            // Wywołujemy metodę pobierającą profil. Ponieważ użytkownik nie ma claimu z ID, metoda powinna zwrócić Unauthorized().
            var result = await _controller.GetMyProfile();



            // ==========================================
            // ASSERT - sprawdzenie wyniku
            // ==========================================

            // Sprawdzamy, czy wynik jest typu  UnauthorizedResult, czyli odpowiedzi HTTP 401.
            Assert.IsType<UnauthorizedResult>(result);

            // Sprawdzamy, czy repozytorium nie zostało wywołane ani razu z jakimkolwiek ID.
            // To potwierdza, że kontroler zakończył działanie przed próbą pobrania danych z repozytorium.
            _usersRepositoryMock.Verify(
                x => x.GetByIdAsync(It.IsAny<int>()),
                Times.Never
            );
        }

        [Fact]
        public async Task GetMyProfile_WhenUserIsNotFound_ReturnsNotFound()
        {
            // ARRANGE

            // Przygotowujemy użytkownika z poprawnym ID w claims.
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, "123")
                };

            var identity = new ClaimsIdentity(
                claims,
                "TestAuthentication"
               );

            _controller.ControllerContext = new ControllerContext
                {
                    HttpContext = new DefaultHttpContext
                    {
                        User = new ClaimsPrincipal(identity)
                    }
                };

            // Symulujemy sytuację, w której repozytorium nie znajduje użytkownika o ID 123.
            _usersRepositoryMock
                .Setup(x => x.GetByIdAsync(123))
                .ReturnsAsync(
                    Result<Update_User_DTO>.Fail(
                        "Nie znaleziono użytkownika.",
                        ErrorType.NotFound
                    )
                );

            // ACT

            // Wywołujemy metodę kontrolera.
            var result = await _controller.GetMyProfile();





            // ASSERT

            // Sprawdzamy, czy kontroler zwrócił HTTP 404.
            Assert.IsType<NotFoundObjectResult>(result);

            // Weryfikujemy, czy repozytorium zostało
            // wywołane dokładnie jeden raz z ID 123.
            _usersRepositoryMock.Verify(
                x => x.GetByIdAsync(123),
                Times.Once
            );
        }


        [Fact]
        public async Task GetMyProfile_WhenUserIdIsValid_ReturnsOk()
        {
            // ARRANGE

            // Zwykły obiekt DTO z przykładowymi danymi.
            var dto = new Update_User_DTO
            {
                LOGIN = "testuser",
                IMIE = "Jan",
                NAZWISKO = "Kowalski"
            };

            // Przygotowujemy użytkownika z poprawnym ID w claims.
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, "123")
                };

            var identity = new ClaimsIdentity(
                claims,
                "TestAuthentication"
               );

            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext
                {
                    User = new ClaimsPrincipal(identity)
                }
            };

            // Symulujemy sytuację, w której repozytorium nie znajduje użytkownika o ID 123.
            _usersRepositoryMock
                .Setup(x => x.GetByIdAsync(123))
                .ReturnsAsync(
                    Result<Update_User_DTO>.Ok(dto)
                );

            // ACT

            // Wywołujemy metodę kontrolera.
            var result = await _controller.GetMyProfile();





            // ASSERT

            // Sprawdzamy, czy kontroler zwrócił HTTP 404.
            Assert.IsType<OkObjectResult>(result);

          
        }



        [Fact]
        public async Task GetMyProfile_WhenUser_ReturnsOk()
        {
            // ==========================================
            // ARRANGE - przygotowanie testu
            // ==========================================

            // Tworzymy pustą listę claims. Nie ma w niej ClaimTypes.NameIdentifier, czyli identyfikatora zalogowanego użytkownika.
            var claims = new List<Claim>();

            // Tworzymy tożsamość użytkownika. "TestAuthentication" to nazwa schematu uwierzytelniania używana w tym teście.
            var identity = new ClaimsIdentity(
                claims,
                "TestAuthentication"
            );

            // Tworzymy obiekt reprezentujący użytkownika.
            var principal = new ClaimsPrincipal(identity);

            // Przypisujemy użytkownika do kontekstu kontrolera.W normalnym żądaniu HTTP framework ustawia User na podstawie uwierzytelnienia.
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext
                {
                    User = principal
                }
            };

            // ==========================================
            // ACT - wykonanie testowanej metody
            // ==========================================

            // Wywołujemy metodę pobierającą profil. Ponieważ użytkownik nie ma claimu z ID, metoda powinna zwrócić Unauthorized().
            var result = await _controller.GetMyProfile();



            // ==========================================
            // ASSERT - sprawdzenie wyniku
            // ==========================================

            // Sprawdzamy, czy wynik jest typu  UnauthorizedResult, czyli odpowiedzi HTTP 401.
            Assert.IsType<UnauthorizedResult>(result);

            // Sprawdzamy, czy repozytorium nie zostało wywołane ani razu z jakimkolwiek ID.
            // To potwierdza, że kontroler zakończył działanie przed próbą pobrania danych z repozytorium.
            _usersRepositoryMock.Verify(
                x => x.GetByIdAsync(It.IsAny<int>()),
                Times.Never
            );
        }

        [Fact]
        public async Task HashPassword_Then_VerifyPassword_Return_True()
        {
            // ARRANGE 
            string password = "HASLO_TEST";

            // ACT 1
            string hashed_password = PasswordHasher.HashPassword(password);

            // ASSERT
            bool password_approved = PasswordHasher.VerifyPassword(password, hashed_password);

            Assert.True(password_approved);
        }
    }
}