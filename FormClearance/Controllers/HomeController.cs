using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FormClearance.Models;
using FormClearance.Models.SD;
using FormClearance.Repository.IRepository;
using System.Net.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace FormClearance.Controllers
{
    [Authorize(Roles ="Admin" + "," + "Manager" + "," + "Network Unit")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFormRepo _repo;
        private readonly IHttpClientFactory _clientFactory;
        private RoleManager<IdentityRole> roleManager;
        private UserManager<IdentityUser> userManager;
        public HomeController(ILogger<HomeController> logger, IFormRepo repo, IHttpClientFactory clientFactory, RoleManager<IdentityRole> roleMgr, UserManager<IdentityUser> _userManager)
        {
            roleManager = roleMgr;
            userManager = _userManager;
            _logger = logger;
            _repo = repo;
            _clientFactory = clientFactory;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            //var user = await userManager.FindByEmailAsync(User.Identity.Name);
            //// Get the roles for the user
            //var roles = await userManager.GetRolesAsync(user);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetForms()
        {
            var booksInDb = _repo.GetAllAsync(StaticDetails.ApiBasePath);
            return Json(new { data = booksInDb });
        }
        [HttpGet]
        public IActionResult AdminResponse()
        {
        //    var getDetails = await _repo.AdminResponse(StaticDetails.AdminResponse, "Admin");
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> FormClearance()
        {
            var user = await userManager.FindByEmailAsync(User.Identity.Name);
            // Get the roles for the user
            var roles = await userManager.GetRolesAsync(user);
            TempData["UserType"] = roles[0].ToString();
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> DeleteRequest(int id, string view)
        {
            var createForm = await _repo.DeleteAsync(StaticDetails.DeleteResponse, id);
            switch (view)
            {
                case "AdminResponse": return RedirectToAction(nameof(AdminResponse));
                case "Archives": return RedirectToAction(nameof(Archives));
            }
                
            
            return View(nameof(FormClearance));
        }

        [HttpGet]
        public async Task<IActionResult> Archives()
        {
            var user = await userManager.FindByEmailAsync(User.Identity.Name);
            // Get the roles for the user
            var roles = await userManager.GetRolesAsync(user);
            TempData["UserType"] = roles[0].ToString();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> FormDetails(FormClearance.Models.FormClearance formClearance)
        {
            
            if (ModelState.IsValid)
            {
                var createForm = await _repo.CreateAsync(StaticDetails.CreateForm, formClearance);
                if(createForm == true)
                {
                    TempData["Success"] = "Submitted Successfully";

                }
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Process(int id)
        {
            var getDetails = await _repo.GetAsync(StaticDetails.ProcessForm, id);
            return View(getDetails);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateFormDetails(FormClearance.Models.FormClearance formClearance)
        {
            formClearance.UserTreated = User.Identity.Name;
            formClearance.Date = DateTime.Now;
            formClearance.UserRole = User.IsInRole("Admin") ? "Admin" :  "Network Engineer";
            formClearance.TechnicalPerson = User.IsInRole("Admin") ? "Admin" : "Network Unit";
            var updateDetails = await _repo.UpdateAsync(StaticDetails.UpdateForm, formClearance);
            if (updateDetails == true)
            {
                TempData["Success"] = "Updated Successfully";

            }
            return View(nameof(FormClearance));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
