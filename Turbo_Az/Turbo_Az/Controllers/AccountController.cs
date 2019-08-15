using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Turbo_Az.DAL;
using Turbo_Az.Models;
using Turbo_Az.ViewModel;
using Turbo_Az.Utilities;

namespace Turbo_Az.Controllers
{
    public class AccountController : Controller
    {
        private readonly Db_Turbo _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signinManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(Db_Turbo context,
                                UserManager<AppUser> userManager,
                                SignInManager<AppUser> signinManager,
                                RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signinManager = signinManager;
            _roleManager = roleManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(registerViewModel);
            }

            AppUser newUser = new AppUser
            {
                Firstname = registerViewModel.Firstname,
                Lastname = registerViewModel.Lastname,
                Email = registerViewModel.Email,
                UserName = registerViewModel.Username
            };

            IdentityResult identityResult = await _userManager.CreateAsync(newUser, registerViewModel.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(registerViewModel);
            }

            //add default member role to user

            await _userManager.AddToRoleAsync(newUser, StaticData.Member);

            await _signinManager.SignInAsync(newUser, true);

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signinManager.SignOutAsync();

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel LoginViewModel)
        {
            if (!ModelState.IsValid) return View(LoginViewModel);
            AppUser user = await _userManager.FindByEmailAsync(LoginViewModel.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Email or password is invalid");
                return View(LoginViewModel);
            }

            Microsoft.AspNetCore.Identity.SignInResult signInResult =
                 await _signinManager.PasswordSignInAsync(user, LoginViewModel.Password, LoginViewModel.RememberMe, true);

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or password is invalid");
                return View(LoginViewModel);
            }

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}