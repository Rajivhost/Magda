// ------------------------------------------------------------------------------------------------
//  <copyright file="RepositoryBase.cs" Company = "HSE">
//    Copyright (c) 1987 - 2013 MUCODEC. All rights reserved.
//  </copyright>
//  ------------------------------------------------------------------------------------------------

using Catel;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Magda.DataAcess
{
    public class RepositoryBase
    {
        #region Fields

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="RepositoryBase" /> class.
        /// </summary>
        /// <param name="database">The database.</param>
        public RepositoryBase(Database database)
        {
            Argument.IsNotNull(() => database);

            Database = database;
        }

        #endregion

        #region Properties

        protected Database Database { get; private set; }

        #endregion

        #region Methods

        #endregion
    }
}