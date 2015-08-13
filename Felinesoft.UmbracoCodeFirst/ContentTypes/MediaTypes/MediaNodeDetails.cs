using Umbraco.Core.Models;

namespace Felinesoft.UmbracoCodeFirst.ContentTypes
{
    /// <summary>
    /// Represents the details of an Umbraco content node
    /// </summary>
    public class MediaNodeDetails : ContentNodeDetails<IMedia>
    {
        /// <summary>
        /// The IContent instance used to construct this instance
        /// </summary>
        public IMedia Media { get; private set; }

        /// <summary>
        /// Returns true if this instance was constructed from an IPublishedInstance instance
        /// </summary>
        public bool IsPublishedInstance { get; private set; }

        /// <summary>
        /// Constructs a new instance of <see cref="DocumentNodeDetails"/>
        /// </summary>
        public MediaNodeDetails() { UmbracoId = -1; }

        /// <summary>
        /// Constructs a new instance of <see cref="DocumentNodeDetails"/>
        /// </summary>
        /// <param name="content">The content instance to describe</param>
        public MediaNodeDetails(IMedia media)
        {
            Initialise(media);
        }

        public override void Initialise(IPublishedContent media)
        {
            base.Initialise(media);
            IsPublishedInstance = true;
        }

        public override void Initialise(IMedia media, string contentTypeAlias = null)
        {
            base.Initialise(media, media.ContentType.Alias);
            this.Media = media;
            IsPublishedInstance = false;
        }
    }
}