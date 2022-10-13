using Test_Assignment_3.Context;
using Test_Assignment_3.Models;

namespace Test_Assignment_3.DataAccess
{
    public interface IEmployeeStorage
    {
        public Task<Employee> GetEmployeeById(int employeeId); 
    }

    public class EmployeeStorage : IEmployeeStorage
    {
        private readonly DBApplicationContext _dbContext;

        public EmployeeStorage(DBApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            return await _dbContext.Employee.FindAsync(employeeId);
        }
    }
}
