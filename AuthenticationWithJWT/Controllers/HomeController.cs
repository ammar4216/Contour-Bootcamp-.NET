using AuthenticationWithJWT.Data;
using AuthenticationWithJWT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthenticationWithJWT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IdentityAuthDB _identityAuthDB;

        public HomeController(ILogger<HomeController> logger, IdentityAuthDB identityAuthDB)
        {
            _identityAuthDB = identityAuthDB;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Submit(Login login)
        {
            var data = _identityAuthDB.identityAuthDBs.Where(obj=>obj.UserName==login.UserName && obj.Password == login.Password).FirstOrDefault();
            


                ViewData["UserName"] = login.UserName;


                var Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("dsagfdsgdsgdsgdsgdsgdagdsgdsfeawfascxzcfaess"));

                var credential = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256);

                var claims = new List<Claim>()
                {
                    new Claim("UserName",data.UserName),
                    new Claim("MyRole",data.MyRole),
                };

                var jwt = new JwtSecurityToken(
                    signingCredentials: credential,
                    claims: claims,
                    expires: DateTime.Now.AddHours(1)
                    );


                var token = new JwtSecurityTokenHandler().WriteToken(jwt);

                ViewData["Token"] = token;
                HttpContext.Response.Cookies.Append("Token", token, new CookieOptions()
                {
                    Secure = true,
                    HttpOnly = true,
                    Expires = DateTime.Now.AddHours(1),
                });

                
            
            return View();
        }

        [Authorize(Policy = "IsAdmin")]
        public IActionResult Privacy()
        {
           return View();
            
        }

        //public ActionResult Logout()
        //{

        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}