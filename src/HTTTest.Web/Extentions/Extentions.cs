using HTTTest.Web.ViewModels;

namespace HTTTest.Web.Extentions
{
    public static class Extentions
    {
        public static Guid? SetActiveItem(this IList<CategoryViewModel> list, Guid? id)
        {
            id = list.Count > 0 ?
                                id ?? list.FirstOrDefault()!.Id :
                                default;
            if (list.Count > 0)
            {
                var item = list.Where(x => x.Id == id).FirstOrDefault()!;
                if (item is not null)
                {
                    item.ActiveLink = "active";
                }
            }
            return id;
        }
    }
}
