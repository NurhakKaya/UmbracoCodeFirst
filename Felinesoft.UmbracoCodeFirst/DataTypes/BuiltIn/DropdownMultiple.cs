﻿using Felinesoft.UmbracoCodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Felinesoft.UmbracoCodeFirst.Attributes;
using Felinesoft.UmbracoCodeFirst.DocumentTypes;
using Umbraco.Web;
using Felinesoft.UmbracoCodeFirst.Extensions;
using System.Drawing;
using System.Collections.ObjectModel;

namespace Felinesoft.UmbracoCodeFirst.DataTypes.BuiltIn
{
    /// <summary>
    /// Represents Umbraco's built-in multi-select dropdown data type
    /// </summary>
    [DataType(name: BuiltInDataTypes.DropdownMultiple, propertyEditorAlias: BuiltInPropertyEditorAliases.DropDownMultiple)]
    [BuiltInDataType]
    public class DropdownMultiple : MultiselectDataType
    {

    }
}