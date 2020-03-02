/**
 * \file      frmAddDeveloper.cs
 * \author    F. Andolfatto
 * \version   1.0
 * \date      15 Août 2018
 * \brief     Form that enables to list the developers already existing for other video games and to add new ones and then set them to the video game.
 *
 * \details   This form lists the developers that have already been set to a video game and enables to create new developer.
 * The user can then select on or more developers and add a new name for a developer.
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
    /// manages the form that enables to add or create a developer
    /// </summary>
    public partial class frmAddDeveloper : Form
    {

        private ConnectionBD connection;
        public List<Developer> listDev;

        /// <summary>
        /// constructor
        /// </summary>
        public frmAddDeveloper()
        {
            InitializeComponent();
        }

        public void SetConnection(ConnectionBD conn)
        {
            connection = conn;
        }

        /// <summary>
        /// add the developers that have been chosen in the list (in the DB) or that have been created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (lstDev.SelectedItems.Count == 0 && txtDev.Text == "")
            {
                MessageBox.Show("Vous devez sélectionner un développeur déjà existant ou en ajouter un");
            }
            else
            {
                listDev = new List<Developer>();
                foreach (Developer dev in lstDev.SelectedItems)
                {
                    //developers in the list
                    listDev.Add(dev);
                }
                if (txtDev.Text != "")
                {
                    //developer created
                    Developer dev = new Developer();
                    dev.Id = 0;
                    dev.Name = txtDev.Text;
                    listDev.Add(dev);
                }
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// load the developers from the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAddDeveloper_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            try
            {
                List<Developer> listDev = connection.GetDeveloper();
                

            } catch (VgSQLException vgex)
            {
                MessageBox.Show(vgex.Message);
            }
        }

        /// <summary>
        /// Cancel the call of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
