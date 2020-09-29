using ConsoleApp1.JbhrServiceCNReference46;
using ConsoleApp1.SalaryService46;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RdNobrTypeClass
    {
        public void GetRdNobrType()
        {
            ISalaryService salaryService = new SalaryServiceClient();
            var Introduction = salaryService.GetRdNobrType();
            string json = JsonConvert.SerializeObject(Introduction);
            Console.WriteLine(json.ToString());
        }
    }
}
