using LHHP_COAC_Practical_Task.Helpers;
using LHHP_COAC_Practical_Task.Interfaces;
using LHHP_COAC_Practical_Task.PersonAndEmployee;

namespace LHHP_COAC_Practical_Task.CaffeCompanyFolder
{
    public class MainDepartment : IReportable
    {
        public static int Day {  get; set; }

        public List<Employee> MainDepartmentEmployees { get; set; } = new List<Employee>();

        public ProductionFacility ProductionFacility { get; set; } = new ProductionFacility();

        public List<Caffe> Caffes { get; set; } = new List<Caffe>();

        private List<string> _reports { get; set; } = new List<string>();

        public MainDepartment()
        {
            Day = 1;
        }

        public MainDepartment EndDay(int nextDayDessertsTypeQuantity)
        {
            _reports.Add(this.GenerateReport());
            Day = Day + 1;

            _reports.Add(ProductionFacility.GenerateReport());
            ProductionFacility.Day = Day;
            ProductionFacility.DessertsModelsBank.Clear();
            ProductionFacility.BakeDesserts(nextDayDessertsTypeQuantity);

            foreach (var caffe in Caffes)
            {
                _reports.Add(caffe.GenerateReport());
                caffe.DessertsModelsBank.Clear();
                caffe.DessertsModelsSold.Clear();
            }
            Caffe.Day = Day;

            return this;
        }

        public string GetReportsHistory()
        {
            var result = $"{this.GetType().Name}: REPORTS HISTORY: \n";
            foreach (var report in _reports)
            {
                result += report + "\n";
            }

            return result;
        }

        public string GetReportsHistory(int dayId)
        {
            var result = $"{this.GetType().Name}: REPORTS HISTORY: \n";

            if (dayId <= Day)
            {
                foreach (var report in _reports)
                {
                    if (report.Contains($"Day: {dayId}"))
                    {
                        result += report + "\n";
                    }
                }

                //var reportsTemp = Reports.Select(str => str).Where(str => str.Contains($"Day: {dayId}")); //Another approach using LINQ.
                //foreach (var report in reportsTemp)
                //{
                //    result += report + "\n";
                //}
            }
            else
            {
                throw new ArgumentOutOfRangeException($"The day with id {dayId} is not reported");
            }
            
            return result;
        }

        public string GenerateReport()
        {
            return this.ToString();
        }

        public override string ToString()
        {
            var result = $"{this.GetType().Name}: Day: {Day}," +
                         $" Employee count: {MainDepartmentEmployees.Count}" +
                         $", Employee salary summary: {MainDepartmentEmployees.CountEmployeesSalary()}";

            return result;
        }
    }
}
