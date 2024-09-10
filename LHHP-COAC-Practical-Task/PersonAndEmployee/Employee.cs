using LHHP_COAC_Practical_Task.Enums;
using LHHP_COAC_Practical_Task.Helpers;

namespace LHHP_COAC_Practical_Task.PersonAndEmployee
{
    public class Employee : Person
    {
        public EmployeePositions Position;

        public int DilySalary;

        public Employee(string firstName, string surname, EmployeePositions position) : base(firstName, surname)
        {
            Position = position;
            DilySalary = Position.GetValueFromAttribute();
        }

        public Employee(Person person, EmployeePositions position) : base(person.FirstName, person.Surname)
        {
            Position = position;
            DilySalary = Position.GetValueFromAttribute();
        }

        public override string ToString()
        {
            return base.ToString() + $" - Position: |{Position.ToString()}|, Salary: |{DilySalary}|";
        }
    }
}
