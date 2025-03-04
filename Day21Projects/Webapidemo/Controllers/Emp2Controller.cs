using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
namespace Webapidemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Emp2Controller : ControllerBase
    {

        private readonly string connectionString = "Server=LAPTOP-4G8BHPK9\\SQLEXPRESS;Database=EmployeeDataDb;Trusted_Connection=True;TrustServerCertificate=True;";

        // ✅ GET All Employees
        [HttpGet]
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                employees.Add(new Employee
                {
                    Id = reader.GetInt32(0),
                    Name = reader.IsDBNull(1) ? null : reader.GetString(1),
                    Place = reader.GetString(2)
                });
            }

            reader.Close();
            conn.Close();

            return employees;
        }


        // ✅ POST Add Employee
        [HttpPost]
        public void AddEmployee(Employee emp)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Employee (Name, Place) VALUES (@Name, @Place); SELECT SCOPE_IDENTITY();", conn);
            cmd.Parameters.AddWithValue("@Name", emp.Name ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Place", emp.Place);
            cmd.ExecuteNonQuery();

            

            conn.Close();

           
        }


        // ✅ PUT Update Employee
        [HttpPut]
        public void UpdateEmployee(Employee emp)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Employee SET Name = @Name, Place = @Place WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", emp.Id);
            cmd.Parameters.AddWithValue("@Name", emp.Name ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Place", emp.Place);

            cmd.ExecuteNonQuery();

            conn.Close();

           
        }

        // ✅ DELETE Employee
        [HttpDelete("{id}")]
        public void DeleteEmployee(int id)
        {
          
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand deleteCmd = new SqlCommand("DELETE FROM Employee WHERE Id = @Id", conn);
            deleteCmd.Parameters.AddWithValue("@Id", id);
            deleteCmd.ExecuteNonQuery();

           

           
        }

    }
}
