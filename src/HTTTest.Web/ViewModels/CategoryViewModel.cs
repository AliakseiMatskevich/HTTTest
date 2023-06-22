namespace HTTTest.Web.ViewModels
{
    public sealed class CategoryViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string ActiveLink { get; set; }

        public CategoryViewModel()
        {
            ActiveLink = string.Empty;
        }
    }
}
