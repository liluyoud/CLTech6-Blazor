using CLTech.Core.Models;
using CLTech.Core.Helpers;

namespace CLTech.Core.Extensions
{
    public static class NavigationExtensions
    {
        public static NavigationModel? GetNavigationItem(this NavigationModel? navigation, string name)
        {
            if (navigation == null) return null;

            foreach (var item in navigation.Items)
            {
                var result = NavigationHelper.Find(item, name);
                if (result != null) return result;
            }

            return null;
        }

        public static List<NavigationModel>? GetNavigationPath(this NavigationModel? to, NavigationModel? from)
        {
            var path = new List<NavigationModel>();
            NavigationHelper.Path(from, to, path);
            return path;
        }
        
    }
}
