using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Mvc;
using TestSommee.Models;

namespace TestSommee.Controllers
{
    public class StudentController : Controller
    {
        private string connStr =
            "Server=xxx.mssql.somee.com;Database=xxx;User Id=xxx;Password=xxx;";

        public ActionResult Index()
        {
            List<Student> list = new List<Student>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT Id, Name, Email FROM Students", conn);

                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(new Student
                    {
                        Id = (int)rd["Id"],
                        Name = rd["Name"].ToString(),
                        Email = rd["Email"].ToString()
                    });
                }
            }

            return View(list);
        }
    }
}
