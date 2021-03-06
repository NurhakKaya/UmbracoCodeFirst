using System.Collections.Generic;
using Marsman.UmbracoCodeFirst.Core.Modules.ContentTypeBase.T4;

namespace Marsman.UmbracoCodeFirst.Core.ClassFileGeneration
{
    public sealed class ContentTypeDescription
    {
        public ContentTypeDescription()
        {
            Templates = new List<TemplateDescription>();
            Tabs = new List<TabDescription>();
            Properties = new List<PropertyDescription>();
            Compositions = new List<CompositionDescription>();
            IgnoredPropertyAliases = new List<string>();
            IgnoredTabs = new List<string>();
        }

        public string ClassName { get; set; }
        public string ParentClassName { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Icon { get; set; }
        public string AllowedChildren { get; set; }
        public string AllowAtRoot { get; set; }
        public string EnableListView { get; set; }
        public string Description { get; set; }
        public List<TabDescription> Tabs { get; set; }
        public List<PropertyDescription> Properties { get; set; }
        public List<CompositionDescription> Compositions { get; set; }
        public string ParentAlias { get; set; }
        public string AttributeName { get; set; }
        public List<TemplateDescription> Templates { get; set; }
        public List<string> IgnoredPropertyAliases { get; set; }
        public List<string> IgnoredTabs { get; set; }
    }
}