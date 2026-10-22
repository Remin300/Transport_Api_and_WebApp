using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApplication1.Obiekty_ORM.ObiektyORMLinq2DB.Urzytkownicy;
using WebApplication1.Repositories.User;
using WebApplication1.Repositories.User.DTO;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;

        public AuthController(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }


        [HttpPost("login")]
        [ProducesResponseType(typeof(Login_User_Response_Dto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Login([FromBody] LoginRequest_Dto request)
        {
            var login_response = await _userRepository.LoginAsync(request.Login, request.Password);

            if (login_response == null)
            {
                return Unauthorized(new { message = "Nieprawidłowy login lub hasło." });
            }
               


            var token = GenerateJwtToken(login_response);


            login_response.token = token;

            return Ok(login_response);
        }


        [Authorize]
        [HttpPost("getAppCache")]
        [ProducesResponseType(typeof(GetAppCache_Dto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetAppCache()
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!int.TryParse(userIdString, out int userId))
            {
                return Unauthorized();
            }

            var response = await _userRepository.GetAppCache(userId);

            if (response == null)
            {
                return Unauthorized(new { message = "Nieprawidłowy login lub hasło." });
            }

            return Ok(response);
        }


        private string GenerateJwtToken(Login_User_Response_Dto user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:SecretKey"]);

            var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.username),
                        new Claim(ClaimTypes.NameIdentifier, user.id.ToString())
                        // Można dodać inne: role, nip, firmę itp.
                    };

            // Tworzenie deskryptora tokena zawierającego wszystkie wymagane informacje
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims), // Lista roszczeń (claims), np. ID użytkownika, rola, login — będą zapisane w tokenie

                Expires = DateTime.UtcNow.AddHours(6), // Termin wygaśnięcia tokena — np. 6 godzin od teraz

                // Podpis tokena przy użyciu algorytmu HMAC SHA256 i klucza symetrycznego
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),   // klucz musi być zakodowany jako bajty (np. UTF8.GetBytes)
                    SecurityAlgorithms.HmacSha256Signature
                ),

                Issuer = _configuration["Jwt:Issuer"],  // Nazwa wystawcy tokena (Issuer) — np. nazwa Twojej aplikacji lub domena             
                Audience = _configuration["Jwt:Audience"]  // Odbiorca tokena (Audience) — np. kto powinien akceptować token (frontend, aplikacja mobilna itp.)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);   // Utworzenie tokena JWT na podstawie powyższego deskryptora

            return tokenHandler.WriteToken(token);  // Zwrot tokena w formie tekstowej (ciąg znaków JWT, np. do przesłania w nagłówku Authorization)
        }
    }
}
