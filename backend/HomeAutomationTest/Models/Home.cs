using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeAutomationTest.Models
{
    public class Home
    {
        public string Id { get; set; }
        public Room[] Rooms { get; set; }
    }
}