using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using StudentManager.Models;
using System.Collections.Generic;

namespace StudentManager.Controllers
{
    public class StudentController : Controller
    {
        private readonly string _connStr =
            "Server=xxx.mssql.somee.com;Database=xxx;User Id=xxx;Password=xxx;";

        public IActionResult Index()
        {
            var students = new List<Student>();

            using (var conn = new SqlConnection(_connStr))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM Students", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    students.Add(new Student
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Email = reader["Email"].ToString()
                    });
                }
            }

            return View(students);
        }
    }
}
