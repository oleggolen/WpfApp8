using WpfApp8.Models;

namespace WpfApp8.Services.Base;

public interface IEmployeesLoader
{
    IEnumerable<EmployeeModel> LoadEmployees();
}