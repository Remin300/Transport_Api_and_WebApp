using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using WebApplication1.IntegrationTests.Helpers;
using WebApplication1.Repositories.User.DTO;
using WebApplication1.Repositories.User.Queries;
using WebApplication1.Tools;

namespace WebApplication1.IntegrationTests
{
    public class UsersControllerIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;
        private readonly HttpClient _client;

        public UsersControllerIntegrationTests(WebApplicationFactory<Program> factory)
        {
            // Tworzymy klienta HTTP, który wysyła żądania
            // do aplikacji uruchomionej w środowisku testowym.
            _client = factory.CreateClient();
            _factory = factory;
        }

        [Fact]
        public async Task Login_ReturnsOk()
        {
            // ==========================================
            // ARRANGE - dane logowania
            // ==========================================

            // TODO: Podaj dane testowego użytkownika,
            // który istnieje w testowej bazie danych.
            var loginRequest = new
            {
                login = "Admin",
                password = "123"
            };

            // ==========================================
            // ACT 1 - logowanie
            // ==========================================

            // Wysyłamy żądanie POST do endpointu logowania.
            // TODO: Zmień "/Login", jeśli Twoja trasa jest inna.
            var loginResponse = await _client.PostAsJsonAsync(
                "/api/Auth/Login",
                loginRequest
            );

            // ASSERT 1 - logowanie zakończone sukcesem

            Assert.Equal(
                HttpStatusCode.OK,
                loginResponse.StatusCode
            );

            // Odczytujemy treść odpowiedzi logowania jako JSON.
            using var loginJson = JsonDocument.Parse(
                await loginResponse.Content.ReadAsStringAsync()
            );

            // Pobieramy JWT z odpowiedzi.
            // TODO: Zmień "token", jeśli API zwraca go
            // pod inną nazwą, np. "accessToken".
            var jwt = loginJson.RootElement
                .GetProperty("token")
                .GetString();

            Assert.False(string.IsNullOrWhiteSpace(jwt));





        }

        [Fact]
        public async Task Login_ReturnsUnauthorized()
        {
            // ==========================================
            // ARRANGE - dane logowania
            // ==========================================

            // TODO: Podaj dane testowego użytkownika,
            // który istnieje w testowej bazie danych.
            var loginRequest = new
            {
                login = "Admin",
                password = "zle_haslo"
            };

            // ==========================================
            // ACT 1 - logowanie
            // ==========================================

            // Wysyłamy żądanie POST do endpointu logowania.
            // TODO: Zmień "/Login", jeśli Twoja trasa jest inna.
            var loginResponse = await _client.PostAsJsonAsync(
                "/api/Auth/Login",
                loginRequest
            );

            // ASSERT 1 - logowanie zakończone sukcesem

            Assert.Equal(HttpStatusCode.Unauthorized, loginResponse.StatusCode);


        }

        [Fact]
        public async Task Login_Then_GetUserList_ReturnsOk()
        {
            // ==========================================
            // ARRANGE - dane logowania
            // ==========================================

            // TODO: Podaj dane testowego użytkownika,
            // który istnieje w testowej bazie danych.
            var loginRequest = new
            {
                login = "Admin",
                password = "123"
            };

            // ==========================================
            // ACT 1 - logowanie
            // ==========================================

            // Wysyłamy żądanie POST do endpointu logowania.
            // TODO: Zmień "/Login", jeśli Twoja trasa jest inna.
            var loginResponse = await _client.PostAsJsonAsync(
                "/api/Auth/Login",
                loginRequest
            );

            // ASSERT 1 - logowanie zakończone sukcesem

            Assert.Equal(
                HttpStatusCode.OK,
                loginResponse.StatusCode
            );

            // Odczytujemy treść odpowiedzi logowania jako JSON.
            using var loginJson = JsonDocument.Parse(
                await loginResponse.Content.ReadAsStringAsync()
            );

            // Pobieramy JWT z odpowiedzi.
            // TODO: Zmień "token", jeśli API zwraca go
            // pod inną nazwą, np. "accessToken".
            var jwt = loginJson.RootElement
                .GetProperty("token")
                .GetString();

            Assert.False(string.IsNullOrWhiteSpace(jwt));




            // ==========================================
            // ARRANGE 2 - ustawienie JWT
            // ==========================================

            // Ustawiamy nagłówek Bearer dla kolejnych żądań.
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", jwt);

            var query = new Get_User_List_Query()
            {
                PageNo = 1
            };

            var parameters = typeof(Get_User_List_Query)
                .GetProperties()
                .Where(p => p.GetValue(query) != null)
                .ToDictionary(
                    p => p.Name,
                    p => p.GetValue(query)!.ToString()
                );


            // ==========================================
            // ACT 2 - pobranie listy użytkowników
            // ==========================================

            // Wysyłamy żądanie do chronionego endpointu.
            // Bez parametrów query - dopasuj je, jeśli są wymagane.
            var url = QueryHelpers.AddQueryString("/api/Users/GetUserList", parameters);


            var usersResponse = await _client.GetAsync(url);
            // ==========================================
            // ASSERT 2 - odpowiedź API
            // ==========================================

            // Sprawdzamy, czy API zaakceptowało token
            // i zwróciło odpowiedź HTTP 200.
            Assert.Equal(HttpStatusCode.OK, usersResponse.StatusCode);

            // Odczytujemy odpowiedź, aby upewnić się,
            // że serwer zwrócił treść.
            var usersJson = await usersResponse.Content.ReadAsStringAsync();

            Assert.False(string.IsNullOrWhiteSpace(usersJson));
        }

        [Fact]
        public async Task UpdateUser_ReturnsOK()
        {
            //=====================
            // Arrange
            //=====================
            var configuration = _factory.Services.GetRequiredService<IConfiguration>();
            var jwt = JwtTestHelper.CreateTestJwt(configuration);

            // Ustawiamy nagłówek Bearer dla kolejnych żądań.
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", jwt);

            int id = 179;


            Update_User_AllInfo_DTO update_dto = Create_Test_Update_User_AllInfo_DTO();
            //=====================
            // Act
            //=====================


            var response = await _client.PostAsJsonAsync(
                 $"/api/Users/UpdateUser/{id}",
                 update_dto);

            //=====================
            // Assert
            //=====================

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task UpdateUser_ReturnsBadRequest()
        {
            //=====================
            // Arrange
            //=====================
            var configuration = _factory.Services.GetRequiredService<IConfiguration>();
            var jwt = JwtTestHelper.CreateTestJwt(configuration);

            // Ustawiamy nagłówek Bearer dla kolejnych żądań.
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", jwt);

            int id = 179;


            Update_User_AllInfo_DTO update_dto = Create_Test_NotCorrect_Update_User_AllInfo_DTO();
            //=====================
            // Act
            //=====================


            var response = await _client.PostAsJsonAsync(
                 $"/api/Users/UpdateUser/{id}",
                 update_dto);

            //=====================
            // Assert
            //=====================

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        private Update_User_AllInfo_DTO Create_Test_Update_User_AllInfo_DTO()
        {
            Update_User_AllInfo_DTO user_dto = new Update_User_AllInfo_DTO()
            {
                LOGIN = "Login",
                IMIE = "Imie",
                NAZWISKO = "Nazwisko",
                ADRES = "Adres",
                MIASTO = "Miasto",

                listaIdDodatkoweFiltry = new List<int>(),
                listaIdOddzialy = new List<int>()
            };

            user_dto.listaIdDodatkoweFiltry.Add(1);
            user_dto.listaIdOddzialy.Add(1);

            return user_dto;
        }

        private Update_User_AllInfo_DTO Create_Test_NotCorrect_Update_User_AllInfo_DTO()
        {
            Update_User_AllInfo_DTO user_dto = new Update_User_AllInfo_DTO()
            {
                LOGIN = "",
                IMIE = "",
                NAZWISKO = "Nazwisko",
                ADRES = "Adres",
                MIASTO = "Miasto",

                listaIdDodatkoweFiltry = new List<int>(),
                listaIdOddzialy = new List<int>()
            };

            user_dto.listaIdDodatkoweFiltry.Add(1);
            user_dto.listaIdOddzialy.Add(1);

            return user_dto;
        }
    }
}