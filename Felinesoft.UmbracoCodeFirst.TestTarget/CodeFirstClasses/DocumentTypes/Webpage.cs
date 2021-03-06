using Marsman.UmbracoCodeFirst;
using Marsman.UmbracoCodeFirst.ContentTypes;
using Marsman.UmbracoCodeFirst.DataTypes;
using Marsman.UmbracoCodeFirst.Attributes;
using Marsman.UmbracoCodeFirst.Extensions;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System;
using Marsman.UmbracoCodeFirst.DataTypes.BuiltIn;

namespace LMI.BusinessLogic.CodeFirst
{
    [DocumentType(@"Web Page", @"WebPage", new Type[] { typeof(Modules), typeof(Settings), typeof(Article), typeof(Classeslanding), typeof(Search), typeof(Seopage), typeof(Webpage), typeof(Redirectpage), typeof(Events) }, @"icon-folder", false, false, @"")]
    [Template(true, "Webpage", "Webpage")]
    public class Webpage : Seopage
    {
        public class ContentTab : TabBase
        {
        }
        public class MenuTab : TabBase
        {
            [ContentProperty(@"Has Flyout Menu", @"hasFlyoutMenu", false, @"Tick this if this is a main menu link with flyout menu", 0, false)]
            public Checkbox Hasflyoutmenu { get; set; }

            [ContentProperty(@"Show in Flyout Menu", @"showInFlyoutMenu", false, @"Tick this if you want this page to appear as a child in a flyout menu", 1, false)]
            public Checkbox Showinflyoutmenu { get; set; }

            [ContentProperty(@"Hide In Sub Nav", @"hideInSubNav", false, @"Hide this from sub navigation", 2, false)]
            public Checkbox Hideinsubnav { get; set; }

        }

        [ContentTab(@"Content", 0)]
        public ContentTab Content { get; set; }

        [ContentTab(@"Menu", 1)]
        public MenuTab Menu { get; set; }

        [ContentProperty(@"Hide in Navigation", "umbracoNaviHide", false, @"", 0, false)]
        public Checkbox Umbraconavihide { get; set; }
    }
}