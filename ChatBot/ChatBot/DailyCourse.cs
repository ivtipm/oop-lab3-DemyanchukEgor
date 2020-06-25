using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace ChatBot
{
    public class DailyCourse
    {
        public Course Valute { get; set; }
    }
    public class Course
    {
        public ValuteInfo USD { get; set; }
        
        public ValuteInfo EUR { get; set; }

        public ValuteInfo CNY { get; set; }
    }
    public class ValuteInfo
    {
        public string Name { get; set; }

        public float Value { get; set; }
    }
}
