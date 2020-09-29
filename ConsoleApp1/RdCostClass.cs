using ConsoleApp1.SalaryService;
//using ConsoleApp1.SalaryService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RdCostClass
    {
        public void GetRtCost(string Code,string Nobr)
        {
            ISalaryService salaryService = new SalaryServiceClient();
            var Introduction = salaryService.GetRdCost(Code,Nobr);
            string json = JsonConvert.SerializeObject(Introduction);
            Console.WriteLine(json.ToString()); 
        }

        public void AddRtCost()
        {
            ISalaryService salaryService = new SalaryServiceClient(); 
            RdCostInfo rdCostInfo = new RdCostInfo()
            {
                EmployeeId = "H000001",
                DateB  = new DateTime(2020, 09, 11),
                DateE = new DateTime(2020, 09, 11),
                UseRatio = 0.5M,
                RdNobrType = "001",
                RdCode = "RD02",
                Note = "",
                Key_Date = DateTime.Now,
                Key_Man = "qwe"
            };
            var Introduction = salaryService.AddRdCost(rdCostInfo);
            string json = JsonConvert.SerializeObject(Introduction);
            Console.WriteLine(json.ToString());
        }

        public void EditRtCost()
        {
            ISalaryService salaryService = new SalaryServiceClient();
            EditRdCostInfo rdCostInfo = new EditRdCostInfo()
            {
                AutoKey = 8,
                EmployeeId = "H000006",
                DateB = new DateTime(2020, 09, 12),
                DateE = new DateTime(2020, 10, 10),
                UseRatio = 0.5M,
                RdNobrType = "002",
                RdCode = "RD02",
                Note = "",
                Key_Date = DateTime.Now,
                Key_Man = "qwe"
            };
            var Introduction = salaryService.EditRdCost(rdCostInfo);
            string json = JsonConvert.SerializeObject(Introduction);
            Console.WriteLine(json.ToString());
        }

        public void DeleteRtCost()
        {
            ISalaryService salaryService = new SalaryServiceClient();
            var Introduction = salaryService.DelRdCost(5);
            string json = JsonConvert.SerializeObject(Introduction);
            Console.WriteLine(json.ToString());
        }
    }
}
