using Microsoft.AspNetCore.Mvc.Rendering;

namespace HTTTest.Web.ViewModels
{
    public sealed class ProductIndexViewModel
    {
        public IEnumerable<ProductViewModel[]>? Products { get; set; }
        public IList<CategoryViewModel>? Categories { get; set; }

    }
}
