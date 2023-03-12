using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorialCore.Contract.Service
{
    public interface IDepartmentService
    {
        public void AddDepartment();
        public void UpdateDepartment();
        public void DeleteDepartmentById();
        public void GetDepartmentById();
        public void GetAllDepartment();
    }
}
