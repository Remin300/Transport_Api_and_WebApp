using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using WebApplication1.IntegrationTests.Helpers;
using WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja;
using WebApplication1.Repositories.User.DTO;
using WebApplication1.Repositories.User.Queries;
using WebApplication1.Repositories.Zlecenia.DTO;
using WebApplication1.Repositories.Zlecenia.Queries;

namespace WebApplication1.IntegrationTests
{
    public class ZleceniaControllerIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;
        private readonly HttpClient _client;

        public ZleceniaControllerIntegrationTests(WebApplicationFactory<Program> factory)
        {
            // Tworzymy klienta HTTP, który wysyła żądania
            // do aplikacji uruchomionej w środowisku testowym.
            _client = factory.CreateClient();
            _factory = factory;
        }


        [Fact]
        public async Task Login_Then_GetListaZlecen_ReturnsOk()
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

            var query = new Get_Zlecenia_List_Query()
            {
                PageNo = 1,
                IdDzial = 4,
                IdDodatkowyFiltr = 0,
                DataOd = DateTime.Now.AddMonths(-3),
                DataDo = DateTime.Now
            };
            var parameters = typeof(Get_Zlecenia_List_Query)
                .GetProperties()
                .Where(p => p.GetValue(query) != null)
                .ToDictionary(
                    p => p.Name,
                    p =>
                    {
                        var value = p.GetValue(query);

                        return value switch
                        {
                            DateTime date => date.ToString("O", CultureInfo.InvariantCulture),
                            IFormattable formattable => formattable.ToString(
                                null, CultureInfo.InvariantCulture),
                            _ => value!.ToString()!
                        };
                    });


            // ==========================================
            // ACT 2 - pobranie listy użytkowników
            // ==========================================

            var url = QueryHelpers.AddQueryString("/api/Zlecenia/GetListaZlecen", parameters);


            var Response = await _client.GetAsync(url);
            // ==========================================
            // ASSERT 2 - odpowiedź API
            // ==========================================

            // Sprawdzamy, czy API zaakceptowało token
            // i zwróciło odpowiedź HTTP 200.
            Assert.Equal(HttpStatusCode.OK, Response.StatusCode);

            // Odczytujemy odpowiedź, aby upewnić się,
            // że serwer zwrócił treść.
            var usersJson = await Response.Content.ReadAsStringAsync();

            Assert.False(string.IsNullOrWhiteSpace(usersJson));
        }

        [Fact]
        public async Task GetListaZlecen_Returns_status500()
        {
            // ==========================================
            // ARRANGE 2 - ustawienie JWT
            // ==========================================
            var configuration = _factory.Services.GetRequiredService<IConfiguration>();
            var jwt = JwtTestHelper.CreateTestJwt(configuration);

            // Ustawiamy nagłówek Bearer dla kolejnych żądań.
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", jwt);

            // w zapytniu mamy nieistniejący dział
            var query = new Get_Zlecenia_List_Query()
            {
                PageNo = 1,
                IdDzial = -14,  // taloegp działu nie ma
              
                DataOd = DateTime.Now.AddMonths(-3),
                DataDo = DateTime.Now
            };
            var parameters = typeof(Get_Zlecenia_List_Query)
                .GetProperties()
                .Where(p => p.GetValue(query) != null)
                .ToDictionary(
                    p => p.Name,
                    p =>
                    {
                        var value = p.GetValue(query);

                        return value switch
                        {
                            DateTime date => date.ToString("O", CultureInfo.InvariantCulture),
                            IFormattable formattable => formattable.ToString(
                                null, CultureInfo.InvariantCulture),
                            _ => value!.ToString()!
                        };
                    });


            // ==========================================
            // ACT 2 - pobranie listy użytkowników
            // ==========================================

            var url = QueryHelpers.AddQueryString("/api/Zlecenia/GetListaZlecen", parameters);


            var Response = await _client.GetAsync(url);
            // ==========================================
            // ASSERT 2 - odpowiedź API
            // ==========================================

            // Sprawdzamy, czy API zaakceptowało token
            Assert.Equal(HttpStatusCode.InternalServerError, Response.StatusCode);

            // Odczytujemy odpowiedź, aby upewnić się,
            // że serwer zwrócił treść.
            var usersJson = await Response.Content.ReadAsStringAsync();

            Assert.False(string.IsNullOrWhiteSpace(usersJson));
        }


        [Fact]
        public async Task CreateZlecenie_Return_201Created()
        {
            // ==========================================
            // ARRANGE 
            // ==========================================
            var configuration = _factory.Services.GetRequiredService<IConfiguration>();
            var jwt = JwtTestHelper.CreateTestJwt(configuration); 

            // Ustawiamy nagłówek Bearer dla kolejnych żądań.
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", jwt);


            Create_Zlecenie_Dto zlecenie_dto = Create_Test_Create_Zlecenie_Dto();


            // ==========================================
            // ACT 
            // ==========================================


            var response = await _client.PostAsJsonAsync(
                 "/api/Zlecenia/CreateZlecenie",
                 zlecenie_dto);


            // ==========================================
            // ASSERT 
            // ==========================================

            Assert.Equal(HttpStatusCode.Created, response.StatusCode);


            var usersJson = await response.Content.ReadAsStringAsync();
            Assert.False(string.IsNullOrWhiteSpace(usersJson));

        }

        [Fact]
        public async Task CreateZlecenie_Return_BadRequest()
        {
            // ==========================================
            // ARRANGE 
            // ==========================================
            var configuration = _factory.Services.GetRequiredService<IConfiguration>();
            var jwt = JwtTestHelper.CreateTestJwt(configuration);

            // Ustawiamy nagłówek Bearer dla kolejnych żądań.
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", jwt);


            Create_Zlecenie_Dto zlecenie_dto = Create_NotCorrect_Test_Create_Zlecenie_Dto();


            // ==========================================
            // ACT 
            // ==========================================


            var response = await _client.PostAsJsonAsync(
                 "/api/Zlecenia/CreateZlecenie",
                 zlecenie_dto);


            // ==========================================
            // ASSERT 
            // ==========================================

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);


            var usersJson = await response.Content.ReadAsStringAsync();
            Assert.False(string.IsNullOrWhiteSpace(usersJson));

        }

        public Create_Zlecenie_Dto Create_Test_Create_Zlecenie_Dto()
        {
            Create_Zlecenie_Dto zlecenie_dto = new Create_Zlecenie_Dto()
            {
                IdZleceniodawcy = 123,
                IdKategoria = 0,
                DataZlecenia = DateTime.Now
            };


            return zlecenie_dto;
        }

        public Create_Zlecenie_Dto Create_NotCorrect_Test_Create_Zlecenie_Dto()
        {
            Create_Zlecenie_Dto zlecenie_dto = new Create_Zlecenie_Dto()
            {
                IdKategoria = 0,
                DataZlecenia = DateTime.Now
            };


            return zlecenie_dto;
        }
    }
}
