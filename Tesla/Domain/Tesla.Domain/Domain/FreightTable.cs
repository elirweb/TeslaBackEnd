using System;
using System.Collections.Generic;
using System.Text;

namespace Tesla.Domain.Domain
{
    public class FreightTable
    {
        public int Id { get; set; }
        public int StartZipCode { get; set; }
        public string EndZipCode { get; set; }
        public int DeliveryTime { get; set; }
        public decimal Value { get; set; }
    }
}
