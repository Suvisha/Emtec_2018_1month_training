using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeCommandRepository : IEmployeeCommandRepository
    {
        public void SaveEmployee(Employee emp)
        {
            DbClass.ExecuteNonQuery("sp_SaveEmployee", System.Data.CommandType.StoredProcedure, new SqlParameter("@EmpName", emp.EmpName), new SqlParameter("@EmpName", emp.EmpName), new SqlParameter("@EmpName", emp.EmpName), new SqlParameter("@EmpName", emp.EmpName));
            
            

        }
    }
}
