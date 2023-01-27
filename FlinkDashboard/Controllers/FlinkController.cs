using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlinkDashboard.Controllers
{
    public class FlinkController : Controller
    {
        string className = "FlinkController";

        public static string Temp1 = "Empty";
        public static string Temp2 = "Empty";
        public static string Temp3 = "Empty";

        public static string Hum1 = "-";
        public static string Hum2 = "-";
        public static string Hum3 = "-";

        public static int Max1 = 0;
        public static int Max2 = 0;
        public static int Max3 = 0;

        public static int Min1 = 0;
        public static int Min2 = 0;
        public static int Min3 = 0;

        static int temp1Count = 0;
        static int temp2Count = 0;
        static int temp3Count = 0;

        static int tempIteration = 4;
        // GET: Flink
        public ActionResult Index()
        {
            return View();
        }

        // GET: Flink/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        public string SendDataToServer(string deviceName, string temp, string hum)
        {
            string metodName = "SendDataToServer";

            if (deviceName=="C01A")
            {
                Hum1 = hum;
                if (temp1Count==tempIteration)
                {
                    Temp1 = FlinkDashboard.Models.ProcessLayer.findAverageTemp1(temp);
                    Logger.Instance().LogWrite($"{className} > {metodName} : Received data from {deviceName} , Temp:{temp} , Hum:{hum} | Average Temp: {Temp1} | List1 Count:{FlinkDashboard.Models.ProcessLayer.temperatureList1.Count()} | List1 Last Item:{FlinkDashboard.Models.ProcessLayer.temperatureList1.Last()} | List1 First Item:{FlinkDashboard.Models.ProcessLayer.temperatureList1.First()}", Logger.LogType.Info);
                    temp1Count = 0;

                    if (Max1< double.Parse(Temp1, System.Globalization.CultureInfo.InvariantCulture))
                    {
                        //Max1=Temp1
                    }
                }
                else
                {
                    Logger.Instance().LogWrite($"{className} > {metodName} : (WILL NOT BE CALCULATED) Received data from {deviceName} , Temp:{temp} , Hum:{hum}", Logger.LogType.Warning);
                }
                temp1Count++;
            }
            if (deviceName == "C01B")
            {
                Hum2 = hum;
                if (temp2Count == tempIteration)
                {
                    Temp2 = FlinkDashboard.Models.ProcessLayer.findAverageTemp2(temp); ;
                    Logger.Instance().LogWrite($"{className} > {metodName} : Received data from {deviceName} , Temp:{temp} , Hum:{hum} | Average Temp: {Temp2} | List2 Count:{FlinkDashboard.Models.ProcessLayer.temperatureList2.Count()} | List2 Last Item:{FlinkDashboard.Models.ProcessLayer.temperatureList2.Last()} | List2 First Item:{FlinkDashboard.Models.ProcessLayer.temperatureList2.First()}", Logger.LogType.Info);
                    temp2Count = 0;
                }
                else
                {
                    Logger.Instance().LogWrite($"{className} > {metodName} : (WILL NOT BE CALCULATED) Received data from {deviceName} , Temp:{temp} , Hum:{hum}", Logger.LogType.Warning);
                }
                temp2Count++;
            }
            if (deviceName == "C01C")
            {
                Hum3 = hum;
                if (temp3Count == tempIteration)
                {
                    Temp3 = FlinkDashboard.Models.ProcessLayer.findAverageTemp3(temp);
                    Logger.Instance().LogWrite($"{className} > {metodName} : Received data from {deviceName} , Temp:{temp} , Hum:{hum} | Average Temp: {Temp3} | List3 Count:{FlinkDashboard.Models.ProcessLayer.temperatureList3.Count()} | List3 Last Item:{FlinkDashboard.Models.ProcessLayer.temperatureList3.Last()} | List3 First Item:{FlinkDashboard.Models.ProcessLayer.temperatureList3.First()}", Logger.LogType.Info);
                    temp3Count = 0;
                }
                else
                {
                    Logger.Instance().LogWrite($"{className} > {metodName} : (WILL NOT BE CALCULATED) Received data from {deviceName} , Temp:{temp} , Hum:{hum}", Logger.LogType.Warning);
                }
                temp3Count++;
            }
            return "Bismillahirrahmanirrahim";
        }
        // GET: Flink/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Flink/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Flink/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Flink/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Flink/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Flink/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
