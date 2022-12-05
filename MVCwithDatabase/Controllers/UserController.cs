using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace Day_17___MVCwithDatabase.Controllers
{
    public class UserController : Controller
    {
        string sqlConnection = @"Data Source=.;Initial Catalog=MVCwithDatabase;Integrated Security=true;";
        SqlTransaction transaction = null;

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

            //Foriegn Key Table
            ViewBag.edu_name = user.edu_name;
            ViewBag.stu_id = user.stu_id;


            

            conn.Open();
            transaction = conn.BeginTransaction();

            var command = new SqlCommand("sp_insert", conn);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("UserName", user.UserName);
            command.Parameters.AddWithValue("UserEmail", user.UserEmail);
            command.Parameters.AddWithValue("UserCNIC", user.UserCNIC);
            command.Parameters.AddWithValue("UserAddress", user.UserAddress);


            try
            {
                command.ExecuteNonQuery();

                transaction.Commit();

            } catch(Exception)
            {
                transaction.Rollback();
            }
            finally
            {
                conn.Close();
            }

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
