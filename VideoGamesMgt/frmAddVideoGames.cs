/**
 * \file      frmAddVideoGames.cs
 * \author    F. Andolfatto
 * \version   1.0
 * \date      15 Août 2018
 * \brief     Form that enables to add a video game.
 *
 * \details   This form enables to create a new video game by entering a name and its other properties 
 * (outputdate, developers, editors of the game, platform, type of game...) 
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
    /// manages the form that enables to add a new video game
    /// </summary>
    public partial class frmAddVideoGame : Form
    {
        private ConnectionBD connection;
        private VideoGame videogame;

        public VideoGame vg
        {
            get
            {
                return videogame;
            }
            set
            {
                videogame = value;
            }
        }

        /// <summary>
        /// constructor
        /// </summary>
        public frmAddVideoGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// clic on the "save" button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSave_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && lstDev.Items.Count > 0 && lstEditor.Items.Count > 0 && lstPlatform.Items.Count > 0 )
            {

                //get the data entered in all fields
                videogame = new VideoGame();
                videogame.Name = txtName.Text;
                videogame.DateOutput = dtpDateOutput.Value;

                //we have an editor object in the list can contains data of the editor (id and name)
                //it will help us to know if the editor already exists in the DB (id is not null) or not
                videogame.Editor = new List<Editor>();
                foreach (Editor editor in lstEditor.Items)
                {
                    videogame.Editor.Add(editor);
                }

                //we have a developer object in the list can contains data of the developer (id and name)
                //it will help us to know if the developer already exists in the DB (id is not null) or not
                videogame.Developer = new List<Developer>();
                foreach (Developer dev in lstDev.Items)
                {
                    videogame.Developer.Add(dev);
                }

                videogame.ListPlatform = new List<string>();
                foreach (string platform in lstPlatform.Items)
                {
                    videogame.ListPlatform.Add(platform);
                }

                videogame.Type = cboTypeVG.Text;

                //save the data in the database
                //get the id of the video game that has just been added and set it to the videogame object (used to display the id in the datagrid)
                try
                {
                    videogame.Id = connection.AddVideoGame(videogame);
                    DialogResult = DialogResult.OK;
                } catch (VgSQLException vgex)
                {
                    MessageBox.Show(vgex.Message);
                    DialogResult = DialogResult.Cancel;
                }

            
            } else
            {
                MessageBox.Show("Tous les champs sont obligatoires!");
            }


        }

        /// <summary>
        /// load the form and the data that are useful for the good use of the form (video game's types) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVideoGame_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //We assume that the videogame release will not be announced before two years. 
            dtpDateOutput.MaxDate = DateTime.Today.AddYears(2);
            //We assume no video game existed before 01.01.1950
            dtpDateOutput.MinDate = DateTime.Parse("01.01.1950");

            try
            {
                connection = new ConnectionBD();

                List<string> lstTypeVG = connection.GetTypeVG();
                foreach (string typeVG in lstTypeVG)
                {
                    cboTypeVG.Items.Add(typeVG);
                }
            } catch (Exception vgex)
            {
                MessageBox.Show(vgex.Message);
            }
            cmdDeletePlatform.Enabled = false;
            cmdDeleteDev.Enabled = false;
            cmdDeleteEditor.Enabled = false;
        }

        /// <summary>
        /// cancel the form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// open a new form to choose an editor that already exists in the DB or to add a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAddEditor_Click(object sender, EventArgs e)
        {
            //open the form to choose or add an editor
            frmAddEditor frmEditor = new frmAddEditor();
            frmEditor.SetConnection(connection);
            if (frmEditor.ShowDialog(this) == DialogResult.OK)
            {
                foreach (Editor ed in frmEditor.listEditor)
                {
                    if (lstEditor.FindStringExact(ed.ToString()) == ListBox.NoMatches)
                    {
                        lstEditor.Items.Add(ed);
                    }
                }
            };
            //close the "add editor" form and free ressources
            frmEditor.Dispose();
        }

        /// <summary>
        /// open a new form to choose one or more platforms on which the game is supported
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAddPlatform_Click(object sender, EventArgs e)
        {
            //open the form to display the list of available platforms
            frmAddPlatform frmPlatform = new frmAddPlatform();
            frmPlatform.SetConnection(connection);
            if (frmPlatform.ShowDialog(this) == DialogResult.OK)
            {
                foreach (string pf in frmPlatform.listPlatform)
                {
                    lstPlatform.Items.Add(pf);   
                }
            };
            //close the "add" form and free ressources
            frmPlatform.Dispose();
        }

        /// <summary>
        /// delete the selected platform that had been chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDeletePlatform_Click(object sender, EventArgs e)
        {
            lstPlatform.Items.RemoveAt(lstPlatform.SelectedIndex);
        }

        /// <summary>
        /// open a new form to choose a developer that already exists in the DB or to add a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAddDev_Click(object sender, EventArgs e)
        {
            //open the form to choose or add a new developer
            frmAddDeveloper frmDeveloper = new frmAddDeveloper();
            frmDeveloper.SetConnection(connection);
            if (frmDeveloper.ShowDialog(this) == DialogResult.OK)
            {
                foreach (Developer dev in frmDeveloper.listDev)
                {
                    if (lstDev.FindStringExact(dev.ToString()) == ListBox.NoMatches)
                    {
                        lstDev.Items.Add(dev);
                    }
                }
            };
            //close the "add" form and free ressources
            frmDeveloper.Dispose();
        }

        /// <summary>
        /// delete the developer that had been chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDeleteDev_Click(object sender, EventArgs e)
        {
            //if a developer is selected, we delete it
            if (lstDev.SelectedItems.Count > 0)
            {
                lstDev.Items.RemoveAt(lstDev.SelectedIndex);
                cmdDeleteDev.Enabled = false;
            }
            else
            {
                MessageBox.Show("Sélectionner un développeur à supprimer");
            }
        }

        /// <summary>
        /// manage the click on an item in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstPlatform_Click(object sender, EventArgs e)
        {
            if (lstPlatform.SelectedItems.Count > 0) {
                cmdDeletePlatform.Enabled = true;
            } else
            {
                cmdDeletePlatform.Enabled = false;
            }
        }

        /// <summary>
        /// manage the click on an item in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstEditor_Click(object sender, EventArgs e)
        {
            if (lstEditor.SelectedItems.Count > 0)
            {
                cmdDeleteEditor.Enabled = true;
            }
            else
            {
                cmdDeleteEditor.Enabled = false;
            }
        }

        /// <summary>
        /// manage the click on an item in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstDev_Click(object sender, EventArgs e)
        {
            if (lstDev.SelectedItems.Count > 0)
            {
                cmdDeleteDev.Enabled = true;
            }
            else
            {
                cmdDeleteDev.Enabled = false;
            }
        }

        /// <summary>
        /// delete an editor that has been selected in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDeleteEditor_Click(object sender, EventArgs e)
        {
            lstEditor.Items.RemoveAt(lstEditor.SelectedIndex);
        }

        
    }
}
