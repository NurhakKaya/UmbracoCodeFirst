﻿using Felinesoft.UmbracoCodeFirst.Attributes;
using Felinesoft.UmbracoCodeFirst.DataTypes.BuiltIn;
using Felinesoft.UmbracoCodeFirst.ContentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Felinesoft.UmbracoCodeFirst.Extensions;
using Felinesoft.UmbracoCodeFirst.Demo.MediaTypes;

namespace Felinesoft.UmbracoCodeFirst.Demo.DocTypes
{

    [MediaType(icon: BuiltInIcons.IconCircus)]
    public class Image : MediaImageBase { }

    [MediaType(mediaTypeName: "File", mediaTypeAlias: "file", icon: BuiltInIcons.IconCircus)]
    public class FileUpload : MediaFileBase { }

    [MediaType(icon: BuiltInIcons.IconCircus, allowAtRoot: true)]
    public class Folder : MediaFolderBase { }

    [DocumentType]
    public class TestComp1 : DocumentTypeBase
    {
        [ContentProperty]
        public virtual Textstring CompositeTextstring { get; set; }
    }

    [DocumentType]
    public class TestComp2 : DocumentTypeBase
    {
        [ContentProperty]
        public virtual Textstring CompositeTextstring2 { get; set; }

        [ContentComposition]
        public virtual Home HomePage { get; set; }
    }

    [DocumentType(icon: BuiltInIcons.IconAlarmClock, iconColor: UmbracoIconColor.Red)]
    [Template(isDefault:true)]
    [CssClass("test-page-main")]
    public class TestPage : Master
    {
        public new class SEOTab : Master.SEOTab
        {
            [ContentProperty]
            public virtual Textstring ExtraSeoProperty { get; set; }
        }

        public class ImageTab : TabBase
        {
            [MediaPickerProperty]
            [CssClass("test test-cropper test-attr")]
            public virtual Helicropter One { get; set; }

            [ContentProperty]
            [CssClass("test test-cropper test-property")]
            public virtual SingleMediaPicker<Helicropter> Two { get; set; }

            [ContentProperty]
            [CssClass("test test-file test-property")]
            public virtual SingleMediaPicker<FileUpload> Three { get; set; }

            [MediaPickerProperty]
            [CssClass("test test-image test-attr")]
            [HtmlData("return", "/home")]
            [AltText("media four")]
            public virtual Image Four { get; set; }

            [MediaPickerProperty]
            [NodePickerConfig(maximumItems: 3)]
            public virtual IEnumerable<FileUpload> Five { get; set; }
        }

        [ContentTab]
        public ImageTab Images { get; set; }

        [ContentProperty]
        public virtual int Counter { get; set; }

        [ContentProperty]
        public virtual DateTime Dater { get; set; }

        [ContentTab]
        public new SEOTab SEO { get; set; }

        [ContentTab(originalName:"FirstTab")]
        public FirstTab FirstTabNewName { get; set; }

        [ContentTab]
        public SecondTab SecondTab { get; set; }

        [ContentProperty]
        public virtual RichtextEditor RichtextEditor { get; set; }

        [ContentProperty]
        public virtual Tags Tags { get; set; }

        [ContentProperty]
        public virtual TextboxMultiple TextboxMultiple { get; set; }

        [ContentProperty]
        public virtual Textstring Textstring { get; set; }

        [ContentProperty]
        public virtual TrueFalse TrueFalse { get; set; }

        [ContentProperty]
        public virtual SingleDocumentPicker<Genericpage> TypedContentPicker { get; set; }

        [ContentProperty]
        public virtual Upload Upload { get; set; }

        [ContentComposition]
        public virtual TestComp1 Comp { get; set; }
    }
}