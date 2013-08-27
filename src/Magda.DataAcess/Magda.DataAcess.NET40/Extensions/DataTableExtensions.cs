// ------------------------------------------------------------------------------------------------
//  <copyright file="DataTableExtensions.cs" Company = "HSE">
//    Copyright (c) 1987 - 2013 MUCODEC. All rights reserved.
//  </copyright>
//  ------------------------------------------------------------------------------------------------

using System.Data;
using Catel;

namespace Magda.DataAcess.Extensions
{
    public static class DataTableExtensions
    {
        public static void AddColumn<TColumn>(this DataTable dataTable, string columnName)
        {
            Argument.IsNotNull(() => dataTable);

            dataTable.Columns.Add(columnName, typeof (TColumn));
        }
    }
}