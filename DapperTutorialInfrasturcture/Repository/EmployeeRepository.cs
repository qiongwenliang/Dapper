using Dapper;
using DapperTutorialCore.Contract.Repository;
using DapperTutorialCore.Entity;
using DapperTutorialInfrasturcture.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorialInfrasturcture.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        DapperDbContext dbConext;

        public EmployeeRepository()
        {
            dbConext = new DapperDbContext();
        }

        public int DeleteById(int id)
        {
            using (var conn = dbConext.GetConnection())
            {
                return conn.Execute("Delete From Employee where Id = @Id", new { Id = id });
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            using (var conn = dbConext.GetConnection())
            {
                string sql = "Select Id, Name, Age, DeptId From Employee";
                return conn.Query<Employee>(sql);
            }
        }

        public Employee GetById(int id)
        {
            using (var conn = dbConext.GetConnection())
            {
                string sql = "Select Id, Name, Age, DepId from Employee where Id=@Id";
                var parameter = new { Id = id };
                return conn.QuerySingleOrDefault(sql, parameter);
            }
        }

        public int Insert(Employee obj)
        {
            using (var conn = dbConext.GetConnection())
            {
                string sql = "Insert into Employee values (@Name, @Age, @DepId)";
                return conn.Execute(sql, obj);
            }
        }

        public int Update(Employee obj)
        {
            using (var conn = dbConext.GetConnection())
            {
                string sql = "Update Employee set Name=@Name, Age=@Age, DepId=@DepId";
                return conn.Execute(sql, obj);
            }
        }
    }
}
