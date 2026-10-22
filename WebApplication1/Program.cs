using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using Serilog.Events;
using System.Text;
using WebApplication1.Background_Service;
using WebApplication1.Repositories.Kontrahenci;
using WebApplication1.Repositories.User;
using WebApplication1.Repositories.Zlecenia;

var builder = WebApplication.CreateBuilder(args);
// https://localhost:44345/swagger/v1/swagger.json

// Rejestracja providerów starych kodowań
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);


// inicjalizacja Serialog 
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override(
        "Microsoft.AspNetCore",
        LogEventLevel.Warning) // to ograniczenie do minimum.

    .WriteTo.Console()
    .WriteTo.File(
        "logs/api-.log",
        rollingInterval: RollingInterval.Day,
        retainedFileCountLimit: 30)
    .CreateLogger();

builder.Host.UseSerilog();

builder.Services.AddControllers();

// Dodanie Background serwisu. Na razie zakomentowane
//builder.Services.AddHostedService<Worker>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("Angular", policy =>
    {
        policy
            .WithOrigins("http://localhost:51128")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// Add services to the container.
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IZlecenia_Repository, Zlecenia_Repository>();
builder.Services.AddScoped<IKontrahenciRepository, KontrahenciRepository>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
var key = Encoding.ASCII.GetBytes(builder.Configuration["Jwt:SecretKey"]);
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})



.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false; // zmień na true na produkcji
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ClockSkew = TimeSpan.Zero
    };
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "TwojaAPI", Version = "v1" });

    // Dodaj definicję zabezpieczeń (nagłówek z JWT)
    c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = Microsoft.OpenApi.SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = Microsoft.OpenApi.ParameterLocation.Header,
        Description = "Wprowadź token w formacie: Bearer {token}"
    });

    // Wymuś użycie tego zabezpieczenia w metodach
    c.AddSecurityRequirement(document =>
    new Microsoft.OpenApi.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.OpenApiSecuritySchemeReference(
                "Bearer",
                document
            ),
            new List<string>()
        }
    });

});


var app = builder.Build();


app.UseCors("Angular");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
