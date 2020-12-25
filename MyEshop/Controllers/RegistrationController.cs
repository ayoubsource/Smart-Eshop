using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MyEshop.Models.DAO;
using MyEshop.Models.Entities;
using MyEshop.ModelsViews;

namespace MyEshop.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IClientRepository _clientManager;
        public RegistrationController(IClientRepository clientManager)
        {
            _clientManager = clientManager;
        }
        
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string fn, string ln,DateTime bd, string email, string pwd)
        {
            PasswordHasher<Client> passwordHasher = new PasswordHasher<Client>();
           
            var client = new Client(fn, ln, bd);
            var hashedPwd = passwordHasher.HashPassword(client, pwd);
            var isValid = passwordHasher.VerifyHashedPassword(client, hashedPwd, "123456789");
            client.Account = new Account(email, hashedPwd);
            _clientManager.Register(client);
            return Redirect("/Login/Login");



        }
    }
}
