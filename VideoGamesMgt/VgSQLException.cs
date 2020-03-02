/**
 * \file      VgSQLException.cs
 * \author    F. Andolfatto
 * \version   1.0
 * \date      16 Août 2018
 * \brief     Custom exception.
 *
 * \details   This class creates a custom exception to manage some SQL errors .
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGamesMgt
{
    /// <summary>
    /// Custom exception to manage the SQL errors
    /// </summary>
    class VgSQLException : Exception
    {
        public VgSQLException(string message) : base(message)
        {

        }
    }
}
