using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Day_17___MVCwithDatabase.Controllers
{
    public class UserController : Controller
    {
        string sqlConnection = @"Data Source=.;Initial Catalog=MVCwithDatabase;Integrated Security=true;";

        SqlConnection conn;
        public UserController() {
            conn = new SqlConnection(sqlConnection);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult User()
        {
            return View();
        }

        public IActionResult submit(Models.User user)
        {
            ViewBag.UserName = user.UserName;
            ViewBag.UserEmail = user.UserEmail;
            ViewBag.UserCNIC = user.UserCNIC;
            ViewBag.UserAddress = user.UserAddress;


            var command = new SqlCommand(string.Format("insert into RegistrationForm(UserName, UserEmail, UserCNIC, UserAddress) values('{0}','{1}', '{2}', '{3}');", user.UserName, user.UserEmail, user.UserCNIC, user.UserAddress), conn);

            conn.Open();

            command.ExecuteNonQuery();

            conn.Close();


            return View();
        }

        public IActionResult UserList()
        {
            return View();
        }

        public IActionResult showUserList()
        {
            return View();
        }
    }
}
