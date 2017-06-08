using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyChet.Models
{
 public   enum Stat{

        NotOnLine,
        OnLine
    };

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IP { get; set; }
        public string Port { get; set; }
        public  Stat Status { get; set; }
    }
}