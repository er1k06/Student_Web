namespace StudentWeb.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using StudentWeb.Data.Models;

    [Authorize]
    public class UserController(
        UserManager<ApplicationUser> userManager,
        RoleManager<ApplicationRole> roleManager,
        SignInManager<ApplicationUser> signInManager) : Controller
    {
        public async Task<IActionResult> CreateRole(string roleName, string label)
        {
            if (!await roleManager.RoleExistsAsync(roleName))
            {
                var role = new ApplicationRole { Name = roleName, Label = label };
                var result = await roleManager.CreateAsync(role);
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> AddUserToRole(string roleName)
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                if (!await userManager.IsInRoleAsync(user,roleName))
                {
                    var result =await userManager.AddToRoleAsync(user,roleName);
                    await signInManager.RefreshSignInAsync(user);
                }
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
