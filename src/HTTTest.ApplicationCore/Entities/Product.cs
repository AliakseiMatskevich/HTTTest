using HTTTest.ApplicationCore.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTTest.ApplicationCore.Entities
{
    public class Product : BaseEntity
    {
        public string? Description { get; set; }
        public int Weight { get; set; }
        public decimal Price { get; set; }
        public Category? Category { get; set; }
    }
}
