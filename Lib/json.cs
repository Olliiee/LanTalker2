using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LanTalker2.Lib
{
    class json
    {
        public class WRITE
        {
            public IList<string> Offset { get; set; }
            public IList<string> Value { get; set; }
        }

        public class READ
        {
            public IList<string> Offset { get; set; }
            public IList<string> Value { get; set; }
        }

        public class TRAFFIC
        {
            public IList<string> Flight { get; set; }
            public IList<string> ID { get; set; }
            public IList<string> Callsign { get; set; }
            public IList<string> Latitude { get; set; }
            public IList<string> Longitude { get; set; }
            public IList<string> Heading { get; set; }
            public IList<string> Altitude { get; set; }
        }

        public class ACTION
        {
            public IList<string> Req { get; set; }
        }

        public class RootObject
        {
            public WRITE WRITE { get; set; }
            public READ READ { get; set; }
            public TRAFFIC TRAFFIC { get; set; }
            public ACTION ACTION { get; set; }
        }
    }
}
