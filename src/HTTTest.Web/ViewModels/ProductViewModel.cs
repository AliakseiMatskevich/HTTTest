using HTTTest.ApplicationCore.Entities;
using System.ComponentModel.DataAnnotations;

namespace HTTTest.Web.ViewModels
{
    public sealed class ProductViewModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Range(0, int.MaxValue)]
        public int Weight { get; set; }
        [Range(0, (double)decimal.MaxValue)]
        public decimal Price { get; set; }
        public string? CategoryName { get; set; }
        public string? PictureUrl { get; set; }
        public string? Measure { get; set; }
    }
}
