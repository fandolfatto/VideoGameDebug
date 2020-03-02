/**
 * \file      VideoGame.cs
 * \author    F. Andolfatto
 * \version   1.0
 * \date      16 Août 2018
 * \brief     Describe the object "VideoGame".
 *
 * \details   This class contains methods and properties to manage videogame.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGamesMgt
{
    /// <summary>
    /// Describe a video game (attributes, methods)
    /// </summary>
    public class VideoGame
    {
        private string name;
        private DateTime dateOutput;
        private List<string> listPlatform;
        private string type;
        private List<Editor> editor;
        private List<Developer> developer;
        private long id;

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
            set {
                name = value;
            }
        }

        public DateTime DateOutput
        {
            get
            {
                return dateOutput;
            }
            set
            {
                dateOutput = value;
            }
        }

        public List<string> ListPlatform
        {
            get
            {
                return listPlatform;
            }
            set
            {
                listPlatform = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public List<Editor> Editor
        {
            get
            {
                return editor;
            }
            set
            {
                editor = value;
            }
        }

        public List<Developer> Developer
        {
            get
            {
                return developer;
            }
            set
            {
                developer = value;
            }
        }

        /// <summary>
        /// display in the datagrid the video game's data (name, output date, developpers, editors, types and id)
        /// </summary>
        /// <returns>the video game's data</returns>
        public string[] DisplayRow()
        {
            
            string ed = String.Join(", ", editor);
            string dev = String.Join(", ", developer);
            
            string[] row = { name, dateOutput.ToShortDateString(), dev, ed, type, id.ToString() };

            return row;
        }

    }
}
