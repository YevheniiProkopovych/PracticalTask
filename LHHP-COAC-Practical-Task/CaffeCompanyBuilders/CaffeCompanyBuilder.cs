using LHHP_COAC_Practical_Task.CaffeCompanyFolder;
using LHHP_COAC_Practical_Task.PersonAndEmployee;

namespace LHHP_COAC_Practical_Task.CaffeCompanyBuilders
{
    public static class CaffeCompanyBuilder
    {
        public static Caffe CaffeEntity(List<Employee> employee) => new CaffeBuilder()
            .WithDefaultSetup()
            .WithWorkers(employee)
            .Build();

        public static ProductionFacility ProductionFacilityEntity(List<Employee> employees, int countOfDessertsToBake) => new ProductionFacilityBuilder()
            .WithWorkers(employees)
            .WirhDessertsAssortement(countOfDessertsToBake)
            .Build();

        public static MainDepartment MainDepartmentEntity(List<Employee> employees, ProductionFacility production, List<Caffe> caffes) => new MainDepartmentBuilder()
            .WithWorkers(employees)
            .WithProductionFacility(production)
            .WithCaffes(caffes)
            .Build();
    }
}
