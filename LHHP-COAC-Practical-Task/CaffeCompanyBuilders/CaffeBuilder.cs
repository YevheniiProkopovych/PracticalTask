using LHHP_COAC_Practical_Task.CaffeCompanyFolder;
using LHHP_COAC_Practical_Task.Helpers;
using LHHP_COAC_Practical_Task.PersonAndEmployee;

namespace LHHP_COAC_Practical_Task.CaffeCompanyBuilders
{
    public class CaffeBuilder : BaseBuilder<Caffe>
    {
        private static int IdNumber = 0;

        public CaffeBuilder WithDefaultSetup()
        {
            IdNumber = IdNumber + 1;
            Entity.CaffeNumber = IdNumber;

            return this;
        }

        public CaffeBuilder WithWorkers(List<Employee> employees)
        {
            Entity.CaffeEmployees = employees;

            return this;
        }
    }
}
