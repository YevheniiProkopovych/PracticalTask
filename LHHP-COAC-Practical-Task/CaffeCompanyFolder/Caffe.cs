using LHHP_COAC_Practical_Task.Enums;
using LHHP_COAC_Practical_Task.Helpers;
using LHHP_COAC_Practical_Task.Interfaces;
using LHHP_COAC_Practical_Task.PersonAndEmployee;

namespace LHHP_COAC_Practical_Task.CaffeCompanyFolder
{
    public class Caffe : IReportable
    {
        public static int Day { get; set; }

        public int CaffeNumber { get; set; }

        private int Income { get; set; }

        public List<Employee> CaffeEmployees { get; set; } = new List<Employee>();

        public List<DessertsModel> DessertsModelsBank { get; set; } = new List<DessertsModel>();

        public List<DessertsModel> DessertsModelsSold { get; set; } = new List<DessertsModel>();

        public Caffe()
        {
            Day = 1;
        }

        public string GenerateReport()
        {
            return this.ToString();
        }

        public void SellDessert(ref Customer customer, Desserts dessert, int quantity)
        {
            var matchingDesserts = DessertsModelsBank.Where(d => d.DessertType == dessert).ToList();

            if (!matchingDesserts.Any())
            {
                throw new Exception($"No elements of this type {typeof(Desserts).Name} are available.");
            }

            var selectedDessert = matchingDesserts.First();

            if (selectedDessert.DessertsQuantity >= quantity)
            {
                selectedDessert.DessertsQuantity -= quantity;
                Income += EnumFieldAttributeHelpers.GetValueFromAttribute(selectedDessert.DessertType) * quantity;

                var soldDessert = new DessertsModel(selectedDessert.DessertType, quantity, Day);

                DessertsModelsSold.Add(soldDessert);
                customer.BuyDessert(soldDessert);
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Elements in {nameof(DessertsModelsBank)} less than provided quanity" +
                                                      $" (Actual was: {selectedDessert.DessertsQuantity} < Expected: {quantity})");
            }
        }

        public override string ToString()
        {
            var result = $"{this.GetType().Name}_{CaffeNumber}: Day: {Day}," +
                         $" Employee count: {CaffeEmployees.Count}," +
                         $" Employee salary summary: {CaffeEmployees.CountEmployeesSalary()}," +
                         $" Income: {Income}" +
                         $"\nDesserts inventory: ";

            foreach (var item in DessertsModelsBank)
            {
                result += item.ToString();
            }

            if(DessertsModelsSold.Count > 0)
            {
                result += "\nDesserts sold:";
                foreach (var item in DessertsModelsSold)
                {
                    result += item.ToString();
                }
            }
            
            return result;
        }
    }
}
