/**
 * \file      Editor.cs
 * \author    F. Andolfatto
 * \version   1.0
 * \date      16 Août 2018
 * \brief     Describe the object "Editor".
 *
 * \details   This class contains methods and properties to manage editor.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGamesMgt
{
    public class Editor
    {
        /// <summary>
        /// Describe an editor (name and id)
        /// </summary>
        private string name;
        private long id;

        public Editor()
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
