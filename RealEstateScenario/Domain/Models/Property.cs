using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Locality { get; set; }
        public string PropertyType { get; set; }
        public string ReferenceNumber { get; set; }
        public string ContractType { get; set; }
        public decimal FloorArea { get; set; }
        public byte Beds { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}