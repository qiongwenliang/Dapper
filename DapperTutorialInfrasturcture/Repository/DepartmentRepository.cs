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
    public class DepartmentRepository : IDepartmentRepository
    {
        DapperDbContext dbConext;

        public DepartmentRepository()
        {
            dbConext = new DapperDbContext();//this will create a connection to sql for us
        }
        public int DeleteById(int id)
        {
            using (var conn = dbConext.GetConnection())
            {
                return conn.Execute("Delete From Department where Id = @Id", new { Id = id });
            }   
        }

        public IEnumerable<Department> GetAll()
        {
            using (var conn = dbConext.GetConnection())
            {
                return conn.Query<Department>("Select Id, Name, Location From Department");
            }
        }

        public Department GetById(int id)
        {
            using (var conn = dbConext.GetConnection())
            {
                return conn.QuerySingleOrDefault<Department>("Select Id, Name, Location From Department where Id = @Id", new {Id=id});
            }
        }

        public int Insert(Department obj)
        {
            using (var conn = dbConext.GetConnection())
            {
                return conn.Execute("Insert into Department values (@Name, @Location)", obj);
            }
        }

        public int Update(Department obj)
        {
            using (var conn = dbConext.GetConnection())
            {
                return conn.Execute("Update Department set Name = @Name, Location = @Location where id = @id", obj);
            }
        }
    }
}
