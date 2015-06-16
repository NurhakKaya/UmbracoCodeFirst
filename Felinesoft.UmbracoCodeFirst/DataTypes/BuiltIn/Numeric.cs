
using Felinesoft.UmbracoCodeFirst;
using Felinesoft.UmbracoCodeFirst.DocumentTypes;
using Felinesoft.UmbracoCodeFirst.DataTypes;
using Felinesoft.UmbracoCodeFirst.DataTypes.BuiltIn;
using Felinesoft.UmbracoCodeFirst.Attributes;
using Felinesoft.UmbracoCodeFirst.Extensions;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Umbraco.Core.Models;
using System;

namespace Felinesoft.UmbracoCodeFirst.DataTypes.BuiltIn
{
    [DataType(BuiltInPropertyEditorAliases.Integer, BuiltInDataTypes.Numeric, null, DataTypeDatabaseType.Integer)]
    [BuiltInDataType]
    public class Numeric : IUmbracoIntDataType
    {
        public int Value { get; set; }

        /// <summary>
        /// Initialises the instance from the db value
        /// </summary>
        public void Initialise(int dbValue)
        {
            Value = dbValue;
        }

        /// <summary>
        /// Serialises the instance to the db value
        /// </summary>
        public int Serialise()
        {
            return Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}