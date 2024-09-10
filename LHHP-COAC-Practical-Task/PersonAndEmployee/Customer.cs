using LHHP_COAC_Practical_Task.CaffeCompanyFolder;
using LHHP_COAC_Practical_Task.Helpers;

namespace LHHP_COAC_Practical_Task.PersonAndEmployee
{
    public class Customer : Person
    {
        public int Balance;

        public List<DessertsModel> DessertsInventory {  get; set; } = new List<DessertsModel>();

        public Customer(string firstName, string surname, int balance) : base(firstName, surname)
        {
            Balance = balance;
        }

        public Customer(Person person, int balance) : base(person.FirstName, person.Surname)
        {
            Balance = balance;
        }

        public void BuyDessert(DessertsModel dessert)
        {
            DessertsInventory.Add(dessert);
            Balance -= dessert.DessertsQuantity * EnumFieldAttributeHelpers.GetValueFromAttribute(dessert.DessertType);
        }

        public override string ToString()
        {
            return base.ToString() + $" - Balance: |{Balance}|";
        }

    }
}
