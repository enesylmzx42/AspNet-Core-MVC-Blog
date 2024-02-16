using AutoMapper;
using Entity.DTO.User;
using Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;
using Presentation.ResultMessages;



namespace Presentation.Areas.Admin.ViewComponents
{
    public class DashboardHeaderViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IMapper mapper;

        public DashboardHeaderViewComponent(UserManager<AppUser> userManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.mapper = mapper;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            try
            {
                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    var loggedInUser = await userManager.GetUserAsync(HttpContext.User);
                    var map = mapper.Map<UserDto>(loggedInUser);

                    var roles = await userManager.GetRolesAsync(loggedInUser);
                    map.Role = string.Join(", ", roles);

                    return View(map);
                }
                else
                {
                    // Handle non-authenticated user case (e.g., redirect to login)
                }
            }
            catch (Exception ex)
            {
                // Log the error and handle it appropriately
                return View("Error", new ErrorViewModel { Message = ex.Message });
            }
            return View();
        }

    }
}
