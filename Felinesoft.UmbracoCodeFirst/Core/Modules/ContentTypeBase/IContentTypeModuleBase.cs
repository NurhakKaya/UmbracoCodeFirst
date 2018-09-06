using System;

namespace Marsman.UmbracoCodeFirst.Core.Modules
{
    public interface IContentTypeModuleBase
    {
        bool TryGetContentType(string alias, out ContentTypeRegistration registration);
        bool TryGetContentType(Type type, out ContentTypeRegistration registration);
    }
}