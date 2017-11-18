using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyRental.Models
{
    public class MembershipType
    {

        public int ID { get; set; }
        public string  Name { get; set; }
        public byte DurationInmonths { get; set; }

        public byte SignUpFee { get; set; }

        public byte DiscountRate { get; set; }

    }
}