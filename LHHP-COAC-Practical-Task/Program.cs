using LHHP_COAC_Practical_Task.CaffeCompanyBuilders;
using LHHP_COAC_Practical_Task.CaffeCompanyFolder;
using LHHP_COAC_Practical_Task.PersonAndEmployee;
using static LHHP_COAC_Practical_Task.DataSetups.PersonsDataSetups;

namespace LHHP_COAC_Practical_Task
{
    internal class Program
    {
        private const string DELIMETER = "*************************************************";

        static void Main(string[] args)
        {
            int innitialDessersCount = 5;
            var caffeList = new List<Caffe>();
            var firstCaffe = CaffeCompanyBuilder.CaffeEntity(Caffe1Employee);
            var secondCaffe = CaffeCompanyBuilder.CaffeEntity(Caffe2Employee);
            caffeList.Add(firstCaffe);
            caffeList.Add(secondCaffe);
            Customer Customer = Customers[0];
            var productionFacility = CaffeCompanyBuilder.ProductionFacilityEntity(ProductionFacilityEmployee, innitialDessersCount);
            var mainDepartment = CaffeCompanyBuilder.MainDepartmentEntity(MainDepartmentEmployee, productionFacility, caffeList);

            Console.WriteLine(mainDepartment.ProductionFacility.ToString());
            Console.WriteLine(DELIMETER);

            FromFacilityToCaffeDelivery(mainDepartment, caffeId: 0, countOfDesserts: 2);
            Console.WriteLine(mainDepartment.Caffes[0].ToString());
            Console.WriteLine(DELIMETER);

            Console.WriteLine(mainDepartment.ProductionFacility.ToString());
            Console.WriteLine(DELIMETER);

            FromFacilityToCaffeDelivery(mainDepartment, caffeId: 1, countOfDesserts: 2);
            Console.WriteLine(DELIMETER);

            Console.WriteLine(mainDepartment.Caffes[1].ToString());
            Console.WriteLine(DELIMETER);

            Console.WriteLine(mainDepartment.ProductionFacility.ToString());
            Console.WriteLine(DELIMETER);

            Console.WriteLine(Customer.ToString());
            mainDepartment.Caffes[0].SellDessert(ref Customer, mainDepartment.Caffes[0].DessertsModelsBank[0].DessertType, quantity: 2);
            Console.WriteLine(DELIMETER);

            Console.WriteLine(Customer.ToString());
            Console.WriteLine(DELIMETER);

            Console.WriteLine(mainDepartment.Caffes[0].ToString());
            Console.WriteLine(DELIMETER);

            int dailyDessersCount = 5;
            mainDepartment.EndDay(dailyDessersCount);
            Console.WriteLine(mainDepartment.GetReportsHistory(1));
            Console.WriteLine(DELIMETER);

        }

        private static void FromFacilityToCaffeDelivery(MainDepartment department, int caffeId, int countOfDesserts)
        {
            var tempCaffe = department.Caffes[caffeId];

            department.ProductionFacility.DeliverDesserts(ref tempCaffe, countOfDesserts);

            department.Caffes[caffeId] = tempCaffe;
        }
    }
}
