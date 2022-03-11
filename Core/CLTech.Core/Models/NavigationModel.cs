using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLTech.Core.Models
{

    public class NavigationModel
    {
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? SubTitle { get; set; }
        public string? Description { get; set; }
        public string? Href { get; set; }
        public string? Icon { get; set; }
        public bool Visible { get; set; } = true;
        public bool ShowInPath { get; set; } = true;
        public List<NavigationModel> Items { get; set; }
        public NavigationModel()
        {
            Items = new List<NavigationModel>();
        }
    }

}
