using CLTech.Core.Models;

namespace CLTech.Core.Helpers
{
    internal static class NavigationHelper
    {
        internal static NavigationModel? Find(NavigationModel item, string name)
        {
            if (item.Name == name) return item;
            if (item.Items != null)
            {
                foreach (var subitem in item.Items)
                {
                    var result = Find(subitem, name);
                    if (result != null) return result;
                }
            }
            return null;
        }

        internal static bool Path(NavigationModel? from, NavigationModel? to, List<NavigationModel> list)
        {
            if (from == null) return false;
            if (from == to)
            {
                list.Add(from);
                return true;
            }

            foreach (var item in from.Items)
            {
                if(Path(item, to, list))
                {
                    list.Insert(0, from);
                    return true;
                }
            }
            return false;
        }
    }
}
