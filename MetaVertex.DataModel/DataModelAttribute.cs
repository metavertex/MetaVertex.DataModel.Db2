﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaVertex.DataModel
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class DataModelAttribute : Attribute
    {
        /// <summary>
        /// If true, all string fields on this model will be trimmed, regardless of their <see cref="DataColumnAttribute.AutoTrim"/>
        /// value.
        /// </summary>
        public bool AutoTrim { get; set; }
    }
}
