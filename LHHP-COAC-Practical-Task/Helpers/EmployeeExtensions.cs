using LHHP_COAC_Practical_Task.PersonAndEmployee;

namespace LHHP_COAC_Practical_Task.Helpers
{
    public static class EmployeeExtensions
    {
        public static int CountEmployeesSalary(this List<Employee> employees)
        {
            var result = 0;

            for (int i = 0; i < employees.Count; i++)
            {
                result += employees[i].DilySalary;
            }

            return result;
        }
    }
}
