/**
 * \file      frmDisplayVideoGames.cs
 * \author    F. Andolfatto
 * \version   1.0
 * \date      15 Août 2018
 * \brief     Displays the properties of the selected game.
 *
 * \details   This form displays the properties of the selected video game.
 * From the id displayed in the main form, we get the information in the database.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGamesMgt
{
    /// <summary>
    /// manages the form that display properties of a video game
    /// </summary>
    public partial class frmDisplayVideoGames : Form
    {

        public VideoGame vg = null;

        //constructor
        public frmDisplayVideoGames()
        {
            InitializeComponent();
        }

        /// <summary>
        /// click on OK : close the form, we have seen the properties of the video game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// open the form to display the properties of the video game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDisplayVideoGames_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Labels initialisation
            lblValueName.Text = "";
            lblValueEditor.Text = "";
            lblValueDev.Text = "";
            lblValueType.Text = "";
            lblValueOutputDate.Text = "";
            lblValuePlatform.Text = "";

            //data of the selected video game
            lblValueName.Text = vg.Name;

            //arrange the data "editor" to get the list of the editors separated by ","
            string listEditor = String.Join(", ", vg.Editor);
            lblValueEditor.Text = listEditor;
            
            string listDev = String.Join(", ", vg.Developer);
            lblValueDev.Text = listDev;

            lblValueType.Text = vg.Type;
            lblValueOutputDate.Text = vg.DateOutput.ToShortDateString();

            //arrange the data "platform" to get the list of the platforms separated by ","
            string listPlatform = String.Join(", ", vg.ListPlatform);
            lblValuePlatform.Text = listPlatform;

        }

    }
}
