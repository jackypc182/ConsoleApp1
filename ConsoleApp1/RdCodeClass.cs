using ConsoleApp1.SalaryService46;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RdCodeClass
    {
        public void GetRtCode()
        { 
            ISalaryService salaryService = new SalaryServiceClient();
            var Introduction = salaryService.GetRdCode();
            string json = JsonConvert.SerializeObject(Introduction);
            Console.WriteLine(json.ToString());
        }

        public void AddRtCode()
        {
            ISalaryService salaryService = new SalaryServiceClient();
            RdCodeInfo rdCodeInfo = new RdCodeInfo()
            {
                Code = "app",
                Name = "app研究",
                DateB = new DateTime(2020, 10 ,1),
                DateE = new DateTime(2020, 8, 10),
                Note = "Note",
                Key_Date = DateTime.Now,
                Key_Man = "Key_Man"
            };
            var Introduction = salaryService.AddRdCode(rdCodeInfo);
            string json = JsonConvert.SerializeObject(Introduction);
            Console.WriteLine(json.ToString());
        }

        public void EditRtCode()
        {
            ISalaryService salaryService = new SalaryServiceClient();
            RdCodeInfo rdCodeInfo = new RdCodeInfo()
            {
                Code = "app",
                Name = "app研究",
                DateB = new DateTime(2020, 8, 1),
                DateE = new DateTime(2020, 8, 10),
                Note = "",
                Key_Date = DateTime.Now,
                Key_Man = ""
            };
            var Introduction = salaryService.EditRdCode(rdCodeInfo);
            string json = JsonConvert.SerializeObject(Introduction);
            Console.WriteLine(json.ToString()); 
        }

        public void DeleteRtCode()
        {
            ISalaryService salaryService = new SalaryServiceClient();
            var Introduction = salaryService.DelRdCode("app");
            string json = JsonConvert.SerializeObject(Introduction);
            Console.WriteLine(json.ToString());
        }
    }
}
