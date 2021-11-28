using System.Collections.Generic;
using System.Linq;

namespace DIP
{
    public class EmployeeStatistics
    {
        private readonly IEmployeeSearchable _emp;
        public EmployeeStatistics(IEmployeeSearchable emp)
        {
            _emp = emp;
        }
        public int CountFemaleManagers() =>
        _emp.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
    }
}