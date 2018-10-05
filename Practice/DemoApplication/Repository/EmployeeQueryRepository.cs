using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeQueryRepository
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            SqlDataReader reader = DbClass.ExecuteReader("sp_getAllEmployees", System.Data.CommandType.StoredProcedure);

            while(reader.Read())
            {
                employees.Add(
                    
                    new Employee()
                    {
                        Id = Convert.ToInt32(reader["EmployeeId"]),
                        EmpName = reader["EmpName"].ToString()
                    }
                );
            }

        }
    }
}