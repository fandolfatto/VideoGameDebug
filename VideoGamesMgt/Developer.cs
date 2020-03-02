/**
 * \file      Developer.cs
 * \author    F. Andolfatto
 * \version   1.0
 * \date      16 Août 2018
 * \brief     Describe the object "Developer".
 *
 * \details   This class contains methods and properties to manage developer.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGamesMgt
{
    /// <summary>
    /// Describe a developer (name and id)
    /// </summary>
    public class Developer
    {

        private string name;
        private long id;

        public Developer()
        {

        }

        public long Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
