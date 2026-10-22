using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApplication1.IntegrationTests.Helpers
{
    public static class JwtTestHelper
    {
        public static string CreateTestJwt(
              IConfiguration configuration,
              string username = "Admin",
              int userId = 1)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var secretKey = configuration["Jwt:SecretKey"]
                ?? throw new InvalidOperationException(
                    "Jwt:SecretKey nie został znaleziony w konfiguracji.");

            var key = Encoding.ASCII.GetBytes(secretKey);

            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, username),
            new Claim(ClaimTypes.NameIdentifier, userId.ToString())
        };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),

                Expires = DateTime.UtcNow.AddHours(1),

                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature),

                Issuer = configuration["Jwt:Issuer"],
                Audience = configuration["Jwt:Audience"]
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
