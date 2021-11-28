using System.Linq;

namespace DIP
{
    public class EmployeeStatistics
    {
        private readonly EmployeeManager _empManager;
        public EmployeeStatistics(EmployeeManager empManager)
        {
            _empManager = empManager;
        }

        public int CountFemaleManagers() =>
          _empManager.Employees.Count(emp => emp.Gender == Gender.Female && emp.Position == Position.Manager);
    }
}