using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

////tiré du site http://blog.mounier-logiciels.fr/comment-creer-une-connection-mysql-local-en-CSharp.html
//https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-sql-command.html

namespace VideoGamesMgt
{
    class DBConnection
    {
        

        private MySqlConnection connection;

        public DBConnection()
        {
            InitConnexion();
        }

        // Méthode pour initialiser la connexion
        private void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=127.0.0.1; DATABASE=quizz; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }

        /*
        // Méthode pour ajouter un élève
        public void AddJoueur(Joueur joueur)
        {
            try
            {

                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();
                //ou MySqlCommand cmd = new MySqlCommand(sql, conn);

                // Requête SQL
                cmd.CommandText = "INSERT INTO joueur (nomJoueur) VALUES (@nom)";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@nom", joueur.Nom);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                this.connection.Close();

            }
            catch (Exception ex)
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
                MessageBox.Show("erreur" + ex.Message);
            }
        }

        public bool IsJoueurAlreadyInDatabase(string nom)
        {
            MySqlDataReader rdr = null;
            bool nameAlreadyExist = true;

            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "select nomJoueur from joueur where nomJoueur = '" + nom + "'";

                // Exécution de la commande SQL
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    nameAlreadyExist = true;
                }
                else nameAlreadyExist = false;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                //Fermeture du datareader
                if (rdr != null)
                {
                    rdr.Close();
                }
                //Fermeture de la connection
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return nameAlreadyExist;
        }

        public List<Question> getQuestions()
        {
            MySqlDataReader rdr = null;
            List<Question> lstQuestion = null;

            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "select idquestion, libelle1, libelle2, reponse1, reponse2, reponse3, reponsecorrecte, "
                    + " c.nomcategorie from question q, categorie c "
                    + " where q.fkcategorie = c.idcategorie";

                // Exécution de la commande SQL
                rdr = cmd.ExecuteReader();

                lstQuestion = new List<Question>();

                while (rdr.Read())
                {
                    Question question = new Question();
                    //   Console.WriteLine(rdr[0] + " -- " + rdr[1]);
                    question.Id = rdr[0].ToString();
                    question.Libelle = rdr[1] + " " + rdr.GetString(2);
                    question.Reponse1 = rdr.GetString(3);
                    question.Reponse2 = rdr.GetString(4);
                    question.Reponse3 = rdr.GetString(5);
                    question.ReponseJuste = rdr.GetInt16(6);
                    question.Categorie = rdr.GetString(7);

                    lstQuestion.Add(question);
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Fermeture du datareader
                if (rdr != null)
                {
                    rdr.Close();
                }
                //Fermeture de la connection
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return lstQuestion;

        }

        public List<string> getCategorie()
        {
            MySqlDataReader rdr = null;
            List<string> lstCategorie = null;

            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "select nomcategorie from categorie ";

                // Exécution de la commande SQL
                rdr = cmd.ExecuteReader();

                lstCategorie = new List<string>();

                while (rdr.Read())
                {
                    string categorie = rdr.GetString(0);
                    lstCategorie.Add(categorie);
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Fermeture du datareader
                if (rdr != null)
                {
                    rdr.Close();
                }
                //Fermeture de la connection
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return lstCategorie;

        }

        public int getReponseJuste(int idQuest)
        {
            MySqlDataReader rdr = null;
            int reponse = 0;

            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "select reponsecorrecte from question where idquestion = " + idQuest;

                // Exécution de la commande SQL
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    reponse = rdr.GetInt16(0);
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Fermeture du datareader
                if (rdr != null)
                {
                    rdr.Close();
                }
                //Fermeture de la connection
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return reponse;

        }

        public void updateScore(int nbBonnesReponses, string nomJoueur)
        {

            try
            {

                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "update joueur set score = @score where nomjoueur = @nom";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@nom", nomJoueur);
                cmd.Parameters.AddWithValue("@score", nbBonnesReponses);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                this.connection.Close();

            }
            catch (Exception ex)
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
                MessageBox.Show("erreur" + ex.Message);
            }

        }
        */
    }
}