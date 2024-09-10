using LHHP_COAC_Practical_Task.CaffeCompanyFolder;
using LHHP_COAC_Practical_Task.Helpers;
using LHHP_COAC_Practical_Task.PersonAndEmployee;

namespace LHHP_COAC_Practical_Task.CaffeCompanyBuilders
{
    public class ProductionFacilityBuilder : BaseBuilder<ProductionFacility>
    {
        public ProductionFacilityBuilder WithWorkers(List<Employee> employee)
        {
            Entity.ProductionFacilityEmployees = employee;

            return this;
        }

        public ProductionFacilityBuilder WirhDessertsAssortement(int countOfDessertsToTake)
        {
            Entity.BakeDesserts(countOfDessertsToTake);

            return this;
        }
    }
}
