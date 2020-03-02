/**
 * \file      frmVideoGamesList.cs
 * \author    F. Andolfatto
 * \version   1.0
 * \date      15 Août 2018
 * \brief     Lists the video games the user has entered in the application.
 *
 * \details   This form displays the list of video games that are sorted in the database 
 * with their properties (outputdate, developers, editors of the game, platform, type of game...) 
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
using System.Text.RegularExpressions;

namespace VideoGamesMgt
{
    /// <summary>
    /// manages the form that show the list of video games
    /// </summary>
    public partial class frmVideoGamesList : Form
    {

        private ConnectionBD connection;

        /// <summary>
        /// constructeur
        /// </summary>
        public frmVideoGamesList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// click on the the add button to add a new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            frmAddVideoGame frmAddVg = new frmAddVideoGame();
            //If "Add" done, display all the games in the datagrid
            if (frmAddVg.ShowDialog(this) == DialogResult.OK)
            {
                dgvVideoGamesList.Rows.Add(frmAddVg.vg.DisplayRow());
            };
            //close the "add" form and free ressources, otherwise the resources add to each other when the form opens again
            frmAddVg.Dispose();
            
        }

        /// <summary>
        /// display the datagrid (columns, header and data)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVideoGamesList_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            dgvVideoGamesList.ColumnCount = 6;
            //option for display
            dgvVideoGamesList.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvVideoGamesList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVideoGamesList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvVideoGamesList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvVideoGamesList.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvVideoGamesList.GridColor = Color.Black;

            //columns name
            dgvVideoGamesList.Columns[0].Name = "Nom";
            dgvVideoGamesList.Columns[1].Name = "Date de sortie";
            dgvVideoGamesList.Columns[2].Name = "Développeur";
            dgvVideoGamesList.Columns[3].Name = "Editeur";
            dgvVideoGamesList.Columns[4].Name = "Type";
            dgvVideoGamesList.Columns[5].Name = "Id";
            dgvVideoGamesList.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;

            dgvVideoGamesList.ReadOnly = true;
            dgvVideoGamesList.AllowUserToAddRows = false;
            dgvVideoGamesList.AllowUserToDeleteRows = false;
            dgvVideoGamesList.AllowUserToOrderColumns = false;
            dgvVideoGamesList.AllowUserToResizeColumns = false;
            dgvVideoGamesList.AllowUserToResizeRows = false;
            dgvVideoGamesList.AllowDrop = false;

            //connect to the database
            try
            {
                connection = new ConnectionBD();

                //get the list of video games and display it
                List<VideoGame> listVideoGames = connection.GetVideoGames();
                foreach (VideoGame vg in listVideoGames)
                {
                    dgvVideoGamesList.Rows.Add(vg.DisplayRow());
                }

                cmdDisplay.Enabled = false;
                cmdModify.Enabled = false;
                cmdDelete.Enabled = false;

            } catch (Exception vgex)
            {
                MessageBox.Show(vgex.Message);
                Close();
            }

            
        }

        /// <summary>
        /// close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdClose_Click(object sender, EventArgs e)
        {
            connection.CloseConnection();
            Close();
        }

        /// <summary>
        /// Display data for the video game that has been selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDisplay_Click(object sender, EventArgs e)
        {
            if (dgvVideoGamesList.SelectedRows.Count == 1)
            {
                //if a single game is selected
                //get all the data of the game that has been selected : 
                //We get the id from the display and we get the data from the database
                //because....

                if (dgvVideoGamesList.SelectedRows[0].Cells[5].Value != null)
                {
                    Int64 id = Convert.ToInt64(dgvVideoGamesList.SelectedRows[0].Cells[5].Value);

                    //platform, editor and developper can contain many values separated by ",", we have to split the string inside the datagrid 
                    //to get all the values
                    VideoGame vg = new VideoGame();
                    try
                    {
                        vg = connection.GetVideoGameFromId(id);
                    } catch (VgSQLException vgex)
                    {
                        MessageBox.Show(vgex.Message);
                    }

                    //open the form to display the properties of the selected game
                    frmDisplayVideoGames frmVideoGames = new frmDisplayVideoGames();
                    frmVideoGames.vg = vg;
                    frmVideoGames.ShowDialog(this);
                } else
                {
                    MessageBox.Show("Sélectionner une ligne non vide");
                }
            }
            else if (dgvVideoGamesList.SelectedRows.Count > 1)
            {
                //shouldn't append, only one row can be selected (property of the datagrid)
                MessageBox.Show("Sélectionner une seule ligne");
            }
            else
            {
                MessageBox.Show("Sélectionner une ligne");
            }
        }

        /// <summary>
        /// To do
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdModify_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A implémenter si vous avez du temps");
        }

        /// <summary>
        /// To do
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A implémenter si vous avez du temps");
        }

        /// <summary>
        /// change the state of the button depending if a row is selected or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvVideoGamesList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //if no line is selected or if many lines are selected
            if (dgvVideoGamesList.SelectedRows.Count != 1)
            {
                cmdDelete.Enabled = false;
                cmdModify.Enabled = false;
                cmdDisplay.Enabled = false;

            } else
            {
                cmdDelete.Enabled = true;
                cmdModify.Enabled = true;
                cmdDisplay.Enabled = true;
            }

        }
    }
}
