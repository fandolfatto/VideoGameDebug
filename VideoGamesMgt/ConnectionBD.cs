/**
 * \file      ConnectionBD.cs
 * \author    F. Andolfatto
 * \version   1.0
 * \date      8 Août 2018
 * \brief     Class that manages the connection and the queries to the database.
 *
 * \details   This class contains methods to get data form the database and to insert data from the database.
 */


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Data;

////tiré du site http://blog.mounier-logiciels.fr/comment-creer-une-connection-mysql-local-en-CSharp.html
//https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-sql-command.html

namespace VideoGamesMgt
{
    /// <summary>
    /// Enables to connect to the database and to do all the operations with the database (insert, select...)
    /// </summary>
    public class ConnectionBD
    {
        private MySqlConnection connection;

        public ConnectionBD()
        {
            InitConnexion();
        }

        /// <summary>
        /// Initialize the connection to the DB
        /// </summary>
        private void InitConnexion()
        {
            // Creation of the connection string : where, who
            // Avoid user id and pwd hardcoded
            ConfigJSONFile confJSONFile;
            try
            {
                confJSONFile = ConfigJSONFile.ReadJSONFile(@"..\..\JSONConfig.json");
            }
            catch (FileNotFoundException fnfe)
            {
                confJSONFile = ConfigJSONFile.ReadJSONFile(@"JSONConfig.json");
            }
            string connectionString = "SERVER=" + confJSONFile.ServerIP + "; DATABASE=" + confJSONFile.Database + "; UID=" + confJSONFile.User + "; PASSWORD=" + confJSONFile.Password;
            connection = new MySqlConnection(connectionString);
            // Open the SQL connection
            OpenConnection();
        }

        /// <summary>
        /// Close MySqlDataReader
        /// </summary>
        private void CloseMySQLQuery(MySqlDataReader rdr)
        {
            if (rdr != null)
            {
                rdr.Close();
            }
        }

        /// <summary>
        /// Close connection
        /// </summary>
        public void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }

        /// <summary>
        /// open connection if it is closed
        /// </summary>
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        /// <summary>
        /// Get the list of the video game's types
        /// </summary>
        /// <returns>list of the type</returns>           
        public List<string> GetTypeVG()
        {
            MySqlDataReader rdr = null;
            List<string> lstType = new List<string>();

            try
            {
                //Check if connection is not closed, otherwise open it
                OpenConnection();

                // Creation of a SQL command
                MySqlCommand cmd = this.connection.CreateCommand();

                // SQL request
                cmd.CommandText = "select name from types order by name";

                // SQL command execution
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string type = rdr.GetString(0);
                    lstType.Add(type);
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                throw new VgSQLException("Erreur lors de la sélection des types de jeux vidéos");
            }
            finally
            {
                CloseMySQLQuery(rdr);
            }
            return lstType;

        }

        /// <summary>
        /// get the list of platforms on which the game is supported
        /// </summary>
        /// <returns>list of platform's name</returns>
        public List<string> GetPlatform()
        {
            MySqlDataReader rdr = null;
            List<string> lstPlatform = new List<string>();

            try
            {
                //Check if connection is not closed, otherwise open it
                OpenConnection();

                // Creation of a SQL command
                MySqlCommand cmd = this.connection.CreateCommand();

                // SQL request
                cmd.CommandText = "select name from platforms order by name";

                // Execution of the SQL command
                rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    string type = rdr.GetString(0);
                    lstPlatform.Add(type);
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                throw new VgSQLException("Erreur lors de la sélection des plateformes de jeux vidéos");
            }
            finally
            {
                CloseMySQLQuery(rdr);
            }
            return lstPlatform;

        }

        /// <summary>
        /// get the list of editors existing in the DB
        /// </summary>
        /// <returns>list of editor</returns>
        public List<Editor> GetEditor()
        {
            MySqlDataReader rdr = null;
            List<Editor> lstEditor = new List<Editor>();

            try
            {
                //Check if connection is not closed, otherwise open it
                OpenConnection();

                // Creation of a SQL command
                MySqlCommand cmd = this.connection.CreateCommand();

                // SQL request
                cmd.CommandText = "select id, name from editors order by name";

                // Execution of the SQL command
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Editor ed = new Editor();
                    ed.Id = rdr.GetInt64(0);
                    ed.Name = rdr.GetString(1);
                     
                    lstEditor.Add(ed);
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                throw new VgSQLException("Erreur lors de la sélection des éditeurs de jeux vidéos");
            }
            finally
            {
                CloseMySQLQuery(rdr);
            }
            return lstEditor;

        }

        /// <summary>
        /// get the list of developers in the DB
        /// </summary>
        /// <returns>list of developers</returns>
        public List<Developer> GetDeveloper()
        {
            MySqlDataReader rdr = null;
            List<Developer> lstDev = new List<Developer>();

            try
            {
                //Check if connection is not closed, otherwise open it
                OpenConnection();

                // Creation of a SQL command
                MySqlCommand cmd = this.connection.CreateCommand();

                // SQL request
                cmd.CommandText = "select id, name from developers order by name";

                // Execution of the SQL command
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Developer dev = new Developer();
                    dev.Id = rdr.GetInt64(0);
                    dev.Name = rdr.GetString(1);
                    lstDev.Add(dev);
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                throw new VgSQLException("Erreur lors de la sélection des développeurs de jeux vidéos");
            }
            finally
            {
                CloseMySQLQuery(rdr);
            }
            return lstDev;

        }


        /// <summary>
        /// get the id of the game's type
        /// </summary>
        /// <param name="type">game's type</param>
        /// <returns>id of the type</returns>
        public int GetType(string type)
        {
            MySqlDataReader rdr = null;
            int idType = 0;

            try
            {
                //Check if connection is not closed, otherwise open it
                OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "select id from Types where name = @type";
                cmd.Parameters.AddWithValue("@type", type);

                // Exécution de la commande SQL
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    idType = rdr.GetInt16(0);
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                throw new VgSQLException("Erreur lors de la recherche de l'id du type de jeux vidéos en fonction de son nom");
            }
            finally
            {
                CloseMySQLQuery(rdr);
            }
            return idType;

        }

        /// <summary>
        /// get the list of video games from DB
        /// </summary>
        /// <returns>list of video games</returns>
        public List<VideoGame> GetVideoGames()
        {
            MySqlDataReader rdr = null;
            List<VideoGame> listVideoGames = new List<VideoGame>();

            try
            {
                //Check if connection is not closed, otherwise open it
                OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "select v.name, v.dateOutput, t.name, v.id " +
                    "from videogames v " +
                    "inner join types t on v.type_id = t.id " +
                    "order by v.name";

                // Exécution de la commande SQL
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //Bug commence à 0 et non 1
                    VideoGame vg = new VideoGame();
                    vg.Name = rdr.GetString(0);
                    vg.DateOutput = rdr.GetDateTime(1);
                    vg.Type = rdr.GetString(2);
                    vg.Id = rdr.GetInt64(3);
                    listVideoGames.Add(vg);
                }

            }
             catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                throw new VgSQLException("Erreur lors de la recherche de la liste des jeux vidéos");
            }
            finally
            {
                CloseMySQLQuery(rdr);
            }
            
            //Here when the SQL Data Reader is closed otherwise we have to open another connection if done in the while 
            foreach (VideoGame vg in listVideoGames)
            {
                vg.Editor = GetEditorList(vg.Id);
                vg.Developer = GetDeveloperList(vg.Id);
            }
            
            return listVideoGames;

        }

        /// <summary>
        /// get the list of editors of the video game
        /// </summary>
        /// <param name="vgId"></param>
        /// <returns>list of editors</returns>
        public List<Editor> GetEditorList(Int64 vgId)
        {
            MySqlDataReader rdr = null;
            List<Editor> listEditor = new List<Editor>();
            
            try
            {
                // Open the SQL connection
                OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "select e.id, e.name " +
                    "from editors e, editorvideogames evg where e.id = evg.editor_id and videogame_id = '" + vgId + "'";

                // Exécution de la commande SQL
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //create editor object to return : contains the id and the name of the editor
                    Editor ed = new Editor();
                    ed.Id = rdr.GetInt64(0);
                    ed.Name = rdr.GetString(1);
                    listEditor.Add(ed);
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                throw new VgSQLException("Erreur lors de la recherche des éditeurs d'un jeu vidéos");
            }
            finally
            {
                CloseMySQLQuery(rdr);
            }
            return listEditor;

        }

        /// <summary>
        /// get the developers list of the video game defined by its id
        /// </summary>
        /// <param name="vgId"></param>
        /// <returns>list of developer</returns>
        public List<Developer> GetDeveloperList(Int64 vgId)
        {
            MySqlDataReader rdr = null;
            List<Developer> listDev = new List<Developer>();

            try
            {
                //Check if connection is not closed, otherwise open it
                OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "select d.id, d.name " +
                    "from developers d, developervideogames dvg " +
                    "where d.id = dvg.developer_id and videogame_id = '" + vgId + "'";

                // Exécution de la commande SQL
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //Developer object created : name and id are available
                    Developer dev = new Developer();
                    dev.Id = rdr.GetInt64(0);
                    dev.Name = rdr.GetString(1);
                    listDev.Add(dev);
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                throw new VgSQLException("Erreur lors de la recherche des développeurs d'un jeu vidéos");
            }
            finally
            {
                CloseMySQLQuery(rdr);
            }
            return listDev;

        }

        /// <summary>
        /// get the list of platforms on which the video game is supported
        /// </summary>
        /// <param name="vgId"></param>
        /// <returns>list of platform's name</returns>
        public List<string> GetPlatformList(Int64 vgId)
        {
            MySqlDataReader rdr = null;
            List<string> listPlatform = new List<string>();

            try
            {
                OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "select name from platformvideogames v, platforms p " +
                    "where p.id = v.Platform_id and videogame_id = '" + vgId + "'";

                // Exécution de la commande SQL
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //Bug commence à 0 et non 1
                    listPlatform.Add(rdr.GetString(0));
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                throw new VgSQLException("Erreur lors de la recherche des plateformes supportées pour le jeu vidéo");
            }
            finally
            {
                CloseMySQLQuery(rdr);
            }
            return listPlatform;

        }

        /// <summary>
        /// Add a video game in the DB and get the id of the video game inserted in
        /// the DB
        /// </summary>
        /// <param name="game">video game to insert into the DB</param>
        /// <returns>the id of the video game inserted into the DB</returns>
        public long AddVideoGame(VideoGame game)
        {
            long videogameId = 0;
            MySqlTransaction transacAddVg = connection.BeginTransaction();
            try
            {

                int idType = GetType(game.Type);

                //Check if connection is not closed, otherwise open it
                OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL : add data into videogame table
                cmd.CommandText = "INSERT INTO videogames (name, dateOutput, type_id) VALUES (@nom, @dateOutput, @fkType)";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@nom", game.Name);
                cmd.Parameters.AddWithValue("@dateOutput", game.DateOutput);
                cmd.Parameters.AddWithValue("@fkType", idType);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();
                videogameId = cmd.LastInsertedId;

                foreach (string platform in game.ListPlatform)
                {
                    int platFormId = GetPlatformId(platform);
                    //insert data into the platformvideogame table
                    cmd.CommandText = "INSERT INTO platformvideogames (platform_id, videogame_id) VALUES (@idplatform, @idvideogame)";

                    // utilisation de l'objet contact passé en paramètre
                    cmd.Parameters.AddWithValue("@idplatform", platFormId);
                    cmd.Parameters.AddWithValue("@idvideogame", videogameId);
                    
                    // Exécution de la commande SQL
                    cmd.ExecuteNonQuery();
                    
                    //on vide les paramètres sinon le programme dit qu'ils existent déjà
                    cmd.Parameters.Clear();
                }

                foreach (Editor ed in game.Editor)
                {
                    long editorId = ed.Id;
                    if (editorId == 0)
                    {
                        //insert into the editor table if the editor does not exist yet
                        cmd.CommandText = "INSERT INTO editors (name) VALUES (@nameeditor)";
                        // utilisation de l'objet contact passé en paramètre
                        cmd.Parameters.AddWithValue("@nameeditor", ed.Name);
                        // Exécution de la commande SQL
                        cmd.ExecuteNonQuery();
                        editorId = cmd.LastInsertedId;
                        cmd.Parameters.Clear();
                    }

                    // editorvideogame table
                    cmd.CommandText = "INSERT INTO editorvideogames (editor_id, videogame_id) VALUES (@fkeditor, @fkvideogame)";
                    // utilisation de l'objet contact passé en paramètre
                    cmd.Parameters.AddWithValue("@fkeditor", editorId);
                    cmd.Parameters.AddWithValue("@fkvideogame", videogameId);
                    // Exécution de la commande SQL
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                foreach (Developer dev in game.Developer)
                {
                    long developerId = dev.Id;
                    if (developerId == 0)
                    {
                        //insert data into the developer table if it does not exist yet
                        cmd.CommandText = "INSERT INTO developers (name) VALUES (@namedeveloper)";
                        // utilisation de l'objet contact passé en paramètre
                        cmd.Parameters.AddWithValue("@namedeveloper", dev.Name);
                        // Exécution de la commande SQL
                        cmd.ExecuteNonQuery();
                        developerId = cmd.LastInsertedId;
                        cmd.Parameters.Clear();
                    }
                    //insert into developervideogame table
                    cmd.CommandText = "INSERT INTO developervideogames (developer_id, videogame_id) VALUES (@fkdev, @fkvideogame)";
                    // utilisation de l'objet contact passé en paramètre
                    cmd.Parameters.AddWithValue("@fkdev", developerId);
                    cmd.Parameters.AddWithValue("@fkvideogame", videogameId);
                    // Exécution de la commande SQL
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                transacAddVg.Commit() ;

            }
            catch (Exception ex)
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                transacAddVg.Rollback();
                throw new VgSQLException("Erreur lors de l'insertion d'un jeu vidéo : " + ex.Message);
            }
            return videogameId;
        }

        /// <summary>
        /// get the platform id from the platform name
        /// </summary>
        /// <param name="platformName"></param>
        /// <returns>the platform id</returns>
        public int GetPlatformId(String platformName)
        {
            MySqlDataReader rdr = null;
            int platformId = 0;

            try
            {
                //Check if connection is not closed, otherwise open it
                OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL : insert into the platform table
                cmd.CommandText = "select id from platforms where name = @platformname";

                cmd.Parameters.AddWithValue("@platformname", platformName);

                // Exécution de la commande SQL
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    platformId = rdr.GetInt16(0);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                throw new VgSQLException("Erreur lors de la recherche de l'id de la plateforme en fonction de son nom");
            }
            finally
            {
                CloseMySQLQuery(rdr);
            }
            return platformId;

        }

        /// <summary>
        /// get the videogame data from its id
        /// </summary>
        /// <param name="vgId"></param>
        /// <returns>the videogame object</returns>
        public VideoGame GetVideoGameFromId(Int64 vgId)
        {
            MySqlDataReader rdr = null;
            VideoGame vg = new VideoGame();

            try
            {
                //Check if connection is not closed, otherwise open it
                OpenConnection();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "select v.name, dateoutput, t.name " +
                    "from videogames v left outer join types t on t.id = v.type_id " +
                    "where v.id = '" + vgId + "'";

                // Exécution de la commande SQL
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    vg.Name = rdr.GetString(0);
                    vg.DateOutput = rdr.GetDateTime(1);
                    vg.Type = rdr.GetString(2);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                throw new VgSQLException("Erreur lors de la recherche des informations sur le jeu vidéo à partir de son id : " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                throw new VgSQLException(ex.Message);
            }
            finally
            {
                CloseMySQLQuery(rdr);
            }

            vg.Editor = GetEditorList(vgId);
            vg.Developer = GetDeveloperList(vgId);
            vg.ListPlatform = GetPlatformList(vgId);

            return vg;
        }

    }
}

