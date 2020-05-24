using System;
using System.Collections.Generic;
using System.Text;

namespace RTM_FRONT_END.Models
{
    public enum MenuItemType
    {
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
