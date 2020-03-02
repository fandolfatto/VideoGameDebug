/**
 * \file      frmAddPlatform.cs
 * \author    F. Andolfatto
 * \version   1.0
 * \date      15 Août 2018
 * \brief     Form that enables to list the platforms and then set it to the video game.
 *
 * \details   This form lists the platforms on which video games are supported.The user can select on or more platforms.
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
    /// manages the form that enables to choose a platform available for the game
    /// </summary>
    public partial class frmAddPlatform : Form
    {
        private ConnectionBD connection;
        public List<string> listPlatform;

        /// <summary>
        /// constructor
        /// </summary>
        public frmAddPlatform()
        {
            InitializeComponent();
        }

        public void SetConnection(ConnectionBD conn)
        {
            connection = conn;
        }

        /// <summary>
        /// load the plaform's list existing in the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAddPlatform_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            try
            {
                List<string> listPlatform = connection.GetPlatform();
                foreach (string platform in listPlatform)
                {
                    lstPlatform.Items.Add(platform);
                }
            } catch (VgSQLException vgex)
            {
                MessageBox.Show(vgex.Message);
            }

        }

        /// <summary>
        /// add the platform that have been chosen in the list (in the DB) in the calling form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (lstPlatform.SelectedItems.Count == 0 )
            {
                MessageBox.Show("Vous devez sélectionner une plateforme déjà existante");
            }
            else
            {
                listPlatform = new List<string>();
                foreach (string pf in lstPlatform.SelectedItems)
                {
                    //add the platform that has been chosen in the list
                    listPlatform.Add(pf);
                }
                DialogResult = DialogResult.OK;
            }


        }

        /// <summary>
        /// cancel the call of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCancel_Click(object sender, EventArgs e)
        {            
            Dispose();
        }
    }
}
