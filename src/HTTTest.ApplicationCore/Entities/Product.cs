using HTTTest.ApplicationCore.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTTest.ApplicationCore.Entities
{
    public class Product : BaseEntity
    {
        [MaxLength(500)]
        public string? Description { get; set; }
        [Range(0, int.MaxValue)]
        public int Weight { get; set; }
        [Range(0, (double)decimal.MaxValue)]
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
        public string? PictureUrl { get; set; }

    }
}
