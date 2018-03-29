using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyRental.Dtos
{
    public class MembershipTypeDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public byte DiscountRate { get; set; }
    }
}