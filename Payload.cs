using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Text;
using System.Globalization;
using System.Runtime.Serialization;

namespace ProjectForIgentics
{

    [DataContract]
    public class Payload
    {     
        public string Id { get; set; }
        [DataMember(Order = 1)]
        public string FirstName { get; set; }
        [DataMember(Order = 2)]
        public string LastName { get; set; }
        [DataMember(Order = 3)]
        public int Age { get; set; }
        [DataMember(Order = 4)]
        public string Gender { get; set; }
        [DataMember(Order =5)]
        public string Email { get; set; }
        [DataMember(Order = 6)]
        public DateTime Registered { get; set; }
    }
}