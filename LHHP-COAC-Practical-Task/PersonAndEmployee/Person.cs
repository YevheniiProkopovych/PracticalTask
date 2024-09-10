namespace LHHP_COAC_Practical_Task.PersonAndEmployee
{
    public class Person
    {
        public string FirstName { get; }

        public string Surname { get; }

        public Person(string firstName, string surname)
        {
            FirstName = firstName;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: Name: |{FirstName}|, Surname: |{Surname}|";
        }
    }
}
