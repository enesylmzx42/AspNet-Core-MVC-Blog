using Entity.DTO.User;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Abstractions
{
    public interface IAuthService
    {
        Task<IdentityResult> RegisterAsync(UserRegisterDto userRegisterDto);
    }

}
