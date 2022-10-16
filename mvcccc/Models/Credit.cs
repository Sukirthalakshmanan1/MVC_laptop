using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcccc.Models
{
    public class Credit
    {
        [Required]
        public int Cardno { get; set; }
        public string name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public int CVV { get; set; }
    }
}