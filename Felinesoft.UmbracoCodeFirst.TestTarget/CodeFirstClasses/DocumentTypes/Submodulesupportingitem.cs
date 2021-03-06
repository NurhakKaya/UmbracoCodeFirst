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
    [DocumentType(@"SUB MODULE: Supporting Item", @"SUBMODULESupportingItem", null, @".sprTreeFolder", false, false, @"")]
    public class Submodulesupportingitem : Submodules
    {
        public class ContentTab : TabBase
        {
            [ContentProperty(@"Header", @"header", true, @"Max Character limit: 41", 1, false)]
            public Textstring Header { get; set; }

            [ContentProperty(@"Image or Video", @"image", false, @"", 0, false)]
            public LegacyMediaPicker Image { get; set; }

            [ContentProperty(@"Body Text", @"bodyText", true, @"", 3, false)]
            public RichtextEditor Bodytext { get; set; }

            [ContentProperty(@"CTA", @"cTA", false, @"", 5, false)]
            public Textstring Cta { get; set; }

            [ContentProperty(@"CTA URL", @"cTAURL", false, @"", 6, false)]
            public LMI.BusinessLogic.CodeFirst.UrlPicker Ctaurl { get; set; }

            [ContentProperty(@"Header Colour", @"headerColour", false, @"", 2, false)]
            public LMI.BusinessLogic.CodeFirst.SpectrumColorPicker Headercolour { get; set; }

            [ContentProperty(@"Body Text Colour", @"bodyTextColour", false, @"", 4, false)]
            public LMI.BusinessLogic.CodeFirst.SpectrumColorPicker Bodytextcolour { get; set; }

        }

        [ContentTab(@"Content", 0)]
        public ContentTab Content { get; set; }
    }
}