using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using HomeAutomationTest.Models;

namespace HomeAutomationTest.Data
{
    public static class JsonReader
    {
        public static Home GetSingleHome(string houseId)
        {
            var homes = JsonConvert.DeserializeObject<List<Home>>(ReadFile());

            var home = homes.FirstOrDefault((h) => h.Id.ToUpper() == houseId.ToUpper());

            return home;
        }

        private static string ReadFile()
        {
            var jsonData = File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/DataFile.json"));
            
            return jsonData;
        }
    }
}