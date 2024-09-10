using LHHP_COAC_Practical_Task.Enums;
using LHHP_COAC_Practical_Task.Helpers;
using LHHP_COAC_Practical_Task.Interfaces;
using LHHP_COAC_Practical_Task.PersonAndEmployee;

namespace LHHP_COAC_Practical_Task.CaffeCompanyFolder
{
    public class ProductionFacility : IReportable
    {
        public static int Day { get; set; }

        public List<Employee> ProductionFacilityEmployees { get; set; } = new List<Employee>();

        public List<DessertsModel> DessertsModelsBank { get; set; } = new List<DessertsModel>();

        private static readonly Random _random = new Random();

        public ProductionFacility()
        {
            Day = 1;
        }

        public void BakeDesserts(int countOfDessersToTake)
        {
            var dessertsModels = new List<DessertsModel>();
            var chosenDesserts = new List<Desserts>();

            if (countOfDessersToTake <= Enum.GetValues(typeof(Desserts)).Length)
            {
                while (dessertsModels.Count < countOfDessersToTake)
                {
                    Desserts randomDessert = EnumHelpers.GetRandomEnumValue<Desserts>();

                    if (!chosenDesserts.Contains(randomDessert))
                    {
                        dessertsModels.Add(new DessertsModel(randomDessert, _random.Next(2, 6), Day));
                        chosenDesserts.Add(randomDessert);
                    }
                }
            }

            DessertsModelsBank = dessertsModels;
        }

        public ProductionFacility DeliverDesserts(ref Caffe caffe, int countOfDesserts)
        {
            if (caffe != null)
            {
                if (caffe.DessertsModelsBank == null)
                    caffe.DessertsModelsBank = new List<DessertsModel>();

                for (int i = 0; i < countOfDesserts; i++)
                {
                    var element = DessertsModelsBank[i];
                    caffe.DessertsModelsBank.Add(element);
                    DessertsModelsBank.Remove(element);
                }
            }

            return this;
        }

        public string GenerateReport()
        {
            return this.ToString();
        }

        public override string ToString()
        {
            var result = $"{this.GetType().Name}: Day: {Day}," +
                         $" Employee count: {ProductionFacilityEmployees.Count}," +
                         $" Employee salary summary: {ProductionFacilityEmployees.CountEmployeesSalary()}" +
                         $"\nDesserts baked: ";

            foreach (var item in DessertsModelsBank)
                result += item.ToString();

            return result;
        }
    }
}
