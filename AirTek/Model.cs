using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTek
{
    internal class Model
    {

        public class Rootobject
        {
            public FlightSchedule[] FlightSchedule { get; set; }
            //public Day1[] Day1 { get; set; }
            //public Day2[] Day2 { get; set; }
        }

        //public class Flightschedule
        //{
        //    public Day1[] Day1 { get; set; }
        //    public Day2[] Day2 { get; set; }
        //}

        public class FlightSchedule
        {
            public string day { get; set; }
            public string flight { get; set; }
            public string departure { get; set; }
            public string arrival { get; set; }
        }

        //public class Day2
        //{
        //    public string flight { get; set; }
        //    public string departure { get; set; }
        //    public string arrival { get; set; }
        //}

    }
}
