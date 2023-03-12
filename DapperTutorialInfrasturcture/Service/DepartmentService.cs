using DapperTutorialCore.Contract.Service;
using DapperTutorialCore.Entity;
using DapperTutorialInfrasturcture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorialInfrasturcture.Service
{
    public class DepartmentService : IDepartmentService
    {
        DepartmentRepository departmentRepository;
        public DepartmentService()
        {
            departmentRepository = new DepartmentRepository();
        }

        public void AddDepartment()
        {
            var d = new Department();
            Console.WriteLine("Enter the name of the Department: ");
            d.Name = Console.ReadLine();
            Console.WriteLine("Enter the location of the Department: ");
            d.Location = Console.ReadLine();
            if (departmentRepository.Insert(d) > 0)
            {
                Console.WriteLine("Suscessfully inserted");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public void DeleteDepartmentById()
        {
            Console.WriteLine("Enter ID of Department");
            int id = Convert.ToInt32(Console.ReadLine());
            
            departmentRepository.DeleteById(id);
        }

        public void GetAllDepartment()
        {
            IEnumerable<Department> departmentList = departmentRepository.GetAll(); 
            foreach(var department in departmentList)
            {
                Console.WriteLine(department.Id + " " + department.Name + " " + department.Location);
            }
        }

        public void GetDepartmentById()
        {
            Console.WriteLine("Enter Id of Department to get: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Department department = departmentRepository.GetById(id);
            Console.WriteLine(department.Id + " " + department.Name + " " + department.Location);

        }

        public void UpdateDepartment()
        {
            var d = new Department();
            Console.WriteLine("Enter the name of the Department: ");
            d.Name = Console.ReadLine();
            Console.WriteLine("Enter the location of the Department: ");
            d.Name = Console.ReadLine();
            if (departmentRepository.Update(d) > 0)
            {
                Console.WriteLine("Suscessfully updated");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }


        public void Run()
        {
            AddDepartment();
        }
    }
}
