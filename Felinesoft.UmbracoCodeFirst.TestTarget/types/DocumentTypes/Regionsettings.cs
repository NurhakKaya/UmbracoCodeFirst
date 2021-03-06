using Felinesoft.UmbracoCodeFirst;
using Felinesoft.UmbracoCodeFirst.ContentTypes;
using Felinesoft.UmbracoCodeFirst.DataTypes;
using Felinesoft.UmbracoCodeFirst.Attributes;
using Felinesoft.UmbracoCodeFirst.Extensions;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System;
using Felinesoft.UmbracoCodeFirst.DataTypes.BuiltIn;

namespace UmbracoCodeFirst.GeneratedTypes
{
    [DocumentType(@"Region Settings", @"RegionSettings", null, @"icon-wrench color-orange", false, false, @"")]
    public class Regionsettings : Master
    {
        public class UsersTab : TabBase
        {
        }

        [ContentTab(@"Users", 0)]
        public UsersTab Users { get; set; }
    }
}