using Entity.DTO.User;
using Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Concretes
{
   

    public class AuthService : IAuthService
    {
        private readonly UserManager<AppUser> userManager;

        public AuthService(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IdentityResult> RegisterAsync(UserRegisterDto userRegisterDto)
        {
            var user = new AppUser
            {
                FirstName = userRegisterDto.FirstName,
                LastName = userRegisterDto.LastName,
                UserName = userRegisterDto.Email,
                Email = userRegisterDto.Email
            };

            return await userManager.CreateAsync(user, userRegisterDto.Password);
        }
    }
}
