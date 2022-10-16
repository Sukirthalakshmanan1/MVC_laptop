using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class login
    {
       // public int admin_id { get; set; }
        public string Email { get; set; }

        public string pass { get; set; }

    }
    public class sign
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string pass { get; set; }
        public string cpass { get; set; }
    }
    public class Laptop
    {
        public int laptop_id { get; set; }
        public string laptop_name { get; set; }

        public int Cost { get; set; }

        public string Descr { get; set; }

    }
    public class Credit
    {
        public int Cardno { get; set; }
        public string name { get; set; }
        public int CVV { get; set; }
    }
}
