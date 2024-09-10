using LHHP_COAC_Practical_Task.PersonAndEmployee;
using static LHHP_COAC_Practical_Task.Enums.EmployeePositions;

namespace LHHP_COAC_Practical_Task.DataSetups
{
    public static class PersonsDataSetups
    {
        public static List<Employee> MainDepartmentEmployee = new()
        {
            new Employee("Name6", "Surname6", MainDepartmentWorker),
            new Employee("Name7", "Surname7", MainDepartmentWorker),
        };

        public static List<Employee> ProductionFacilityEmployee = new()
        {
            new Employee("Name5", "Surname5", ProductFacilityWorker),
            new Employee("Name5", "Surname5", ProductFacilityWorker),
        };

        public static List<Employee> Caffe1Employee = new()
        {
            new Employee("Name1", "Surname1", CaffeWorker),
            new Employee("Name2", "Surname2", CaffeWorker),
        };

        public static List<Employee> Caffe2Employee = new()
        {
            new Employee("Name3", "Surname3", CaffeWorker),
            new Employee("Name4", "Surname4", CaffeWorker),
        };

        public static List<Customer> Customers = new()
        {
            new Customer("Name8", "Surname8", 200),
            new Customer("Name9", "Surname9", 200),
        };
    }
}
