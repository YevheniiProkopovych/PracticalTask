using LHHP_COAC_Practical_Task.Attributes;

namespace LHHP_COAC_Practical_Task.Enums
{
    public enum EmployeePositions
    {
        [EnumField(50)]
        MainDepartmentWorker,

        [EnumField(30)]
        ProductFacilityWorker,

        [EnumField(15)]
        CaffeWorker,
    }
}
