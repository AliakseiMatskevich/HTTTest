using HTTTest.ApplicationCore.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTTest.ApplicationCore.Entities
{
    public sealed class Category : BaseEntity
    {
        [MaxLength(5)]
        public string? Measure { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
