using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorialCore.Contract.Service
{
    public interface IEmployeeService
    {
        public void AddEmployee();
        public void UpdateEmployee();
        public void DeleteEmployeeById();
        public void GetEmployeeById();
        public void GetAllEmployee();
    }
}
