using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class EmployeeManager
    {
        private readonly IEmployeeCommandRepository commandRepository;

        public EmployeeManager()
        {
            commandRepository = new EmployeeCommandRepository();
        }

        public void SaveEmployee(Employee emp)
        {
            commandRepository.SaveEmployee(emp);
        }
    }
}