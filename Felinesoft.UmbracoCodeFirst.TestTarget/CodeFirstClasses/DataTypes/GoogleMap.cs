
using Marsman.UmbracoCodeFirst;
using Marsman.UmbracoCodeFirst.ContentTypes;
using Marsman.UmbracoCodeFirst.DataTypes;
using Marsman.UmbracoCodeFirst.DataTypes.BuiltIn;
using Marsman.UmbracoCodeFirst.Attributes;
using Marsman.UmbracoCodeFirst.Extensions;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Umbraco.Core.Models;
using System;

namespace LMI.BusinessLogic.CodeFirst
{
    [DataType("AngularGoogleMaps", "Google Map")]
    [PreValue("defaultLocation", @"")]
    [PreValue("height", @"400")]
    [PreValue("hideSearch", @"")]
    [PreValue("hideLabel", @"")]
    [PreValue("coordinatesBehavour", @"2")]
    public class GoogleMap : IUmbracoNtextDataType
    {
        //TODO implement the properties and serialisation logic for the AngularGoogleMaps property editor's values

        /// <summary>
        /// Initialises the instance from the db value
        /// </summary>
        public void Initialise(string dbValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Serialises the instance to the db value
        /// </summary>
        public string Serialise()
        {
            throw new NotImplementedException();
        }
    }
}