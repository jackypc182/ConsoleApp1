using ConsoleApp1.ServiceReference1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("1234");
            //OtherAttend();
            //RdCost rdCost = new RdCost();
            //rdCost.AddRtCost();
            //RdCostClass rdNobrType = new RdCostClass();
            //rdNobrType.EditRtCost();
            //Func<int, int> testForEquality = (x) => x+1;
            //Console.WriteLine(testForEquality(2));
            RequestApi requestApi = new RequestApi();
            string Url = "https://outlook.office.com/webhook/a0161246-4c28-4203-9620-a7224d612654@d813e1be-6d67-43a2-9bf6-60916e68c549/IncomingWebhook/d62130b7b23b44ecaaf57be888c1ad1a/27f7f383-8b4a-43ec-ae40-6fc8648e3f83";

             //List<LOCK_WAGE> a = getSql();

            //string log = "";
            //foreach (var x in a)
            //{
            //    log += ("KEY_DATE：" + x.KEY_DATE);
            //    log += "&ensp;";
            //    log += ("KEY_MAN：" + x.KEY_MAN);
            //    log += "&ensp;";
            //    log += ("Memo：" + x.MENO);
            //    log += "<br>";
            //    //Console.WriteLine(log);
            //}

            var JsonObject = new
            {
                text = "有錯誤訊息，請至記錄檔查看。"
            };
            await requestApi.reqPost(Url, JsonObject, "");

            Console.ReadLine();

        }

        private static void OtherAttend()
        {
            //寫入交接班資料
            OtherAttendChangeInfo otherAttendInfo = new OtherAttendChangeInfo()
            {
                NOBR = "K001017",
                ADATE = "2019-06-02",
                BDATE = "2019-06-02",
                EDATE = "2019-06-02",
                BTIME = "1200",
                ETIME = "1400",
                ATYPE = "HO",
                USEMIN = 60,
                KEY_MAN = "5",
                NOTE = "5"
            };

            IAttendanceService attendanceService = new AttendanceServiceClient();
            Object Introduction = attendanceService.CheckOtherAttendData(otherAttendInfo);

            string json = JsonConvert.SerializeObject(Introduction);
            Console.WriteLine(json.ToString());

            //List<OtherAttendChangeInfo> otherAttendChangeInfosList = new List<OtherAttendChangeInfo>()
            //{
            //    new OtherAttendChangeInfo{
            //        NOBR = "H000001",
            //        ADATE = "2020/07/29",
            //        BDATE = "2020/07/29",
            //        EDATE = "2020/07/29",
            //        BTIME = "1234",
            //        ETIME = "2000",
            //        ATYPE = "交接班",
            //        USEMIN = 1,
            //        KEY_MAN = "1",
            //        NOTE = "1"
            //    },
            //    new OtherAttendChangeInfo{
            //        NOBR = "H000001",
            //        ADATE = "2020/07/29",
            //        BDATE = "2020/07/29",
            //        EDATE = "2020/07/29",
            //        BTIME = "2000",
            //        ETIME = "2100",
            //        ATYPE = "交接班",
            //        USEMIN = 1,
            //        KEY_MAN = "2",
            //        NOTE = "2"
            //    },
            //    new OtherAttendChangeInfo{
            //        NOBR = "H000001",
            //        ADATE = "2020/07/29",
            //        BDATE = "2020/07/29",
            //        EDATE = "2020/07/29",
            //        BTIME = "1000",
            //        ETIME = "1234",
            //        ATYPE = "交接班",
            //        USEMIN = 1,
            //        KEY_MAN = "3",
            //        NOTE = "3"
            //    },
            //    new OtherAttendChangeInfo{
            //        NOBR = "H000001",
            //        ADATE = "2020/07/29",
            //        BDATE = "2020/07/29",
            //        EDATE = "2020/07/29",
            //        BTIME = "2222",
            //        ETIME = "2359",
            //        ATYPE = "交接班",
            //        USEMIN = 1,
            //        KEY_MAN = "4",
            //        NOTE = "4"
            //    },
            //    new OtherAttendChangeInfo{
            //        NOBR = "H000001",
            //        ADATE = "2020/07/29",
            //        BDATE = "2020/07/29",
            //        EDATE = "2020/07/29",
            //        BTIME = "2341",
            //        ETIME = "2359",
            //        ATYPE = "交接班",
            //        USEMIN = 1,
            //        KEY_MAN = "5",
            //        NOTE = "5"
            //    },
            //    new OtherAttendChangeInfo{
            //        NOBR = "H000001",
            //        ADATE = "2020/07/29",
            //        BDATE = "2020/07/29",
            //        EDATE = "2020/07/29",
            //        BTIME = "1000",
            //        ETIME = "1111",
            //        ATYPE = "交接班",
            //        USEMIN = 1,
            //        KEY_MAN = "6",
            //        NOTE = "6"
            //    }
            //};

            //foreach (var o in otherAttendChangeInfosList)
            //{
            //    IAttendanceService attendanceServices = new AttendanceServiceClient();
            //    Object Introduction = attendanceServices.AddOtherAttendChange(o);
            //    string json = JsonConvert.SerializeObject(Introduction);
            //    Console.WriteLine(json.ToString());
            //}
        }

        public static List<LOCK_WAGE> getSql()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var rDCOSTs = from r in db.LOCK_WAGE
                          select r;
            return rDCOSTs.ToList();
        }
    }
}
