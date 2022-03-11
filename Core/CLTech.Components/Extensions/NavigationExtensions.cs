using CLTech.Core.Models;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLTech.Components.Extensions
{
    public static class NavigationExtensions
    {
        public static string ToMudBlazorIcon(this string? icon)
        {
            var result = string.Empty;
            if (icon != null)
            {
                var parts = icon.Split('.');
                if (parts.Length == 2)
                {
                    switch (parts[0])
                    {
                        case "Outlined": {
                            var property = typeof(MudBlazor.Outlined).GetProperty(parts[1]);
                            if (property != null)
                                result = (string)(property.GetValue(new MudBlazor.Outlined()) ?? string.Empty);
                            break;
                        }
                        case "Rounded":
                        {
                            var property = typeof(MudBlazor.Rounded).GetProperty(parts[1]);
                            if (property != null)
                                result = (string)(property.GetValue(new MudBlazor.Rounded()) ?? string.Empty);
                            break;
                        }
                        case "Sharp":
                        {
                            var property = typeof(MudBlazor.Sharp).GetProperty(parts[1]);
                            if (property != null)
                                result = (string)(property.GetValue(new MudBlazor.Sharp()) ?? string.Empty);
                            break;
                        }
                        case "TwoTone":
                        {
                            var property = typeof(MudBlazor.TwoTone).GetProperty(parts[1]);
                            if (property != null)
                                result = (string)(property.GetValue(new MudBlazor.TwoTone()) ?? string.Empty);
                            break;
                        }
                        default:
                        {
                            var property = typeof(MudBlazor.Filled).GetProperty(parts[1]);
                            if (property != null)
                                result = (string)(property.GetValue(new MudBlazor.Filled()) ?? string.Empty);
                            break;
                        }
                    }
                }
            }
          return result;
        }

        public static void FillWithPath(this List<BreadcrumbItem>? breadcrumbs, List<NavigationModel>? path)
        {
            if (breadcrumbs != null && path != null)
            {
                for (int i = 1; i < path.Count - 1; i++)
                {
                    var item = path[i];
                    if (item.ShowInPath)
                    {
                        breadcrumbs.Add(new BreadcrumbItem(
                            text: item.Name,
                            href: item.Href,
                            disabled: string.IsNullOrEmpty(item.Href),
                            icon: item.Icon));
                    }
                }
            }
        }
    }
}
