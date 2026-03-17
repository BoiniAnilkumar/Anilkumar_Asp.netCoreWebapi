using BALLib.Common;
using BALLib.DTOs.LoginDTO;
using BALLib.Services.Service_Interface;
using CommonlibDAO.Modles.User_Security;
using CommonlibDAO.Repositories.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BALLib.Services.Service_Implementation
{
    public class LoginService : ILoginService
    {
        private readonly IUserLoginRepository _repo;
        private readonly IConfiguration _config;

        public LoginService(IUserLoginRepository repo, IConfiguration config)
        {
            _repo = repo;
            _config = config;
        }

        public async Task<ApiResponse<LoginResponse>> LoginAsync(LoginRequestDTO request)
        {
            var user = await _repo.GetByUsernameAsync(request.Username);

            if (user == null || user.PasswordHash != request.Password)
            {
                return ApiResponse<LoginResponse>
                    .FailureResponse("Invalid username or password");
            }

            var token = GenerateJwtToken(user);

            var response = new LoginResponse
            {
                Token = token,
                Username = user.UserName,
                UserId = user.UserId
            };

            return ApiResponse<LoginResponse>
                .SuccessResponse(response, "Login successful");
        }

        private string GenerateJwtToken(tbl_UserLogin user)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim("UserId", user.UserId.ToString())
            };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_config["Jwt:Key"]!)
            );

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
