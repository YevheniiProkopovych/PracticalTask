using LHHP_COAC_Practical_Task.CaffeCompanyFolder;
using LHHP_COAC_Practical_Task.Helpers;
using LHHP_COAC_Practical_Task.PersonAndEmployee;

namespace LHHP_COAC_Practical_Task.CaffeCompanyBuilders
{
    public class MainDepartmentBuilder : BaseBuilder<MainDepartment>
    {
        public MainDepartmentBuilder WithWorkers(List<Employee> employees)
        {
            Entity.MainDepartmentEmployees = employees;

            return this;
        }

        public MainDepartmentBuilder WithProductionFacility(ProductionFacility productionFacility)
        {
            Entity.ProductionFacility = productionFacility;

            return this;
        }

        public MainDepartmentBuilder WithCaffes(List<Caffe> caffes)
        {
            Entity.Caffes = caffes;

            return this;
        }
    }
}
