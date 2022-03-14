using WpfApp8.Models;
using WpfApp8.Services.Base;

namespace WpfApp8.Services;

public class SimpleEmployeeLoader : IEmployeesLoader
{
    private readonly List<EmployeeModel> _employees;

    public SimpleEmployeeLoader()
    {
        _employees= new List<EmployeeModel>
        {
            new ()
            {
                FIO = "Иванов Иван Иванович",
                Salary = 30000,
                Post = "Техник",
                Experience = 18
            },
            new()
            {
                FIO = "Сергеев Сергей Сергеевич",
                Salary = 23000,
                Post = "Оператор",
                Experience = 6
            },
            new()
            {
                FIO = "Петров Петр Петрович",
                Salary = 45000,
                Post = "Директор",
                Experience = 34
            }
        };
    }

    public IEnumerable<EmployeeModel> LoadEmployees() => _employees;

}