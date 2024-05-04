﻿using CustomIdentity.Models;
using CustomIdentity.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CustomIdentity.Controllers
{
	public class AccountController : Controller
	{
		private readonly SignInManager<AppUser> _signInManager;
		private readonly UserManager<AppUser> _userManager;
		public AccountController(SignInManager<AppUser> signInManager,UserManager<AppUser> userManager)
		{
			_signInManager = signInManager;
			_userManager = userManager;
		}
		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
			if(ModelState.IsValid)
			{
                //login
                var result = await _signInManager.PasswordSignInAsync(model.UserName!, model.Password!, model.RememberMe, false);
				if(result.Succeeded)
				{
					return RedirectToAction("Index", "Home");
				}
				ModelState.AddModelError("", "Invalid Login Attempt");
				return View(model);
			}
            return View(model);
        }
        public IActionResult Register()
		{
			return View();
		}
		[HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
			if(ModelState.IsValid)
			{
				AppUser user = new()
				{
					Name = model.Name,
					UserName = model.Email,
					Email = model.Email,
					Address=model.Address				
				};
                var result = await _userManager.CreateAsync(user, model.Password!);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);

                    return RedirectToAction("Index", "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
        public async Task<IActionResult> Logout()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
        }
	}
}
