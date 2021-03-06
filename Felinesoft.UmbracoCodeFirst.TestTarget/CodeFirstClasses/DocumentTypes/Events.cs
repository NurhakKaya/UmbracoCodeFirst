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
    [DocumentType(@"Events", @"Events", new Type[] { typeof(Eventlisting) }, @"icon-map-alt", false, false, @"")]
    [Template(true, "Debug", "Debug")]
    public class Events : Seopage
    {
        public class SettingsTab : TabBase
        {
            [ContentProperty(@"All Events Page", @"umbracoRedirect", false, @"", 0, false)]
            public LMI.BusinessLogic.CodeFirst.EventlistingsPicker Umbracoredirect { get; set; }

        }

        [ContentTab(@"Settings", 0)]
        public SettingsTab Settings { get; set; }
    }
}