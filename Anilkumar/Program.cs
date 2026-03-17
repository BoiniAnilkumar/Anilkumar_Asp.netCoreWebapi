//using BALLib.Repositories.Repository_Implementation;
using Anilkumar.Middleware;
//using BALLib.Repositories.@interface;
//using BALLib.Repositories.Repository_Implementation;
using BALLib.Services.Service_Implementation;
using BALLib.Services.Service_Interface;
using CommonlibDAO;
using CommonlibDAO.Repositories.Implementations;
using CommonlibDAO.Repositories.Interface;
//using BALLib.Services.Service_Interface;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
//using BALLib.Services.Service_Interface;
//using BALLib.Services.Service_Implementation;
//using CommonlibDAO.Repositories.Interface;
//using CommonlibDAO.Repositories.Implementations;
//using Microsoft.IdentityModel.Tokens;
//using System.Text;
//using static BALLib.Repositories.@interface.Interfaces;

var builder = WebApplication.CreateBuilder(args);

//
// =========================
//     ?? CORS (FOR REACT)
// =========================
//
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReact", policy =>
    {
        policy.WithOrigins("http://localhost:3200")   // React app URL
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();                    // Optional
    });
});

//
// =========================
//     ?? DATABASE CONTEXT
// =========================
//
builder.Services.AddDbContext<DBContextEFCore>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly("CommonlibDAO")
    ));

//AnilCode

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = false;
});

//
// =========================
//     ?? DEPENDENCY INJECTION
// =========================
//
//builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
//builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IUserLoginRepository, UserLoginRepository>();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IClientRepositery,ClientRepositery>();
builder.Services.AddScoped<IClientServices,ClientServices>();
//builder.Services.AddScoped<IAnilRepositery, AnilRepositery>();
//builder.Services.AddScoped<IAnilServices, AnilServices>();
//builder.Services.AddScoped<ITblEmployeeRepository, TblEmployeeRepository>();
//builder.Services.AddScoped<ITblEmployeeServices, TblEmployeeServices>();
builder.Services.AddScoped<IAddEmployeeRepository, AddEmployeeRepository>();
builder.Services.AddScoped<IAddEmployeeServices, AddEmployeeServices>();
builder.Services.AddScoped<IMasterRepository, MasterRepository>();
builder.Services.AddScoped<IMasterService, MasterService>();
builder.Services.AddScoped<IClientRepositery, ClientRepositery>();
builder.Services.AddScoped<IClientServices, ClientServices>();



// Test change for GitHub workflow
//builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
//builder.Services.AddScoped<IEmployeeService, EmployeeService>();
//builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
//builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<JwtTokenService>();

//
// =========================
//     ?? JWT Authentication
// =========================
//

var jwtSection = builder.Configuration.GetSection("Jwt");
var keyString = jwtSection["Key"];

if (string.IsNullOrEmpty(keyString))
    throw new Exception("JWT Key missing");

var key = Encoding.UTF8.GetBytes(keyString);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false; // Allow local dev with http
        options.SaveToken = true;

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = jwtSection["Issuer"],

            ValidateAudience = true,
            ValidAudience = jwtSection["Audience"],

            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),

            ValidateLifetime = true
        };
    });

//
// =========================
//     ?? CONTROLLERS & SWAGGER
// =========================
//

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//
// =========================
//     ?? MIDDLEWARE PIPELINE
// =========================
//

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Optional: If HTTPS is causing React issues, comment this line
app.UseHttpsRedirection();

app.UseRouting();

// MUST COME BEFORE Authentication & Authorization
app.UseCors("AllowReact");

app.UseAuthentication();

app.UseAuthorization();

//app.UseMiddleware<ExceptionMiddleware>();

app.MapControllers();

app.Run();
