﻿using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace MetaVertex.DataModel
{
    /// <summary>
    /// Contains information linking the column from a data reader with the property on the model type.
    /// </summary>
    internal class ReaderFieldInfo
    {
        public static IEnumerable<ReaderFieldInfo> GetInfos(ResultModelMap map, DbDataReader reader)
        {
            for (var i = 0; i < reader.FieldCount; i++)
            {
                var columnName = reader.GetName(i);

                var prop = map.PropertyMaps.FirstOrDefault(p => p.ColumnName == columnName);

                if (prop != null)
                    yield return new ReaderFieldInfo
                    {
                        ColumnIndex = i,
                        PropertyMap = prop,
                    };
            }
        }

        public int ColumnIndex { get; private set; }
        public ResultPropertyMap PropertyMap { get; private set; }
    }

}