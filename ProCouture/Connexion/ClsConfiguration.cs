using ProCouture.Connexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerConnection
{
    public class ClsConfiguration
    {
        public static bool CreationDeFichierConf(Connexions con ,ConnexionType connexionType)
        {
            bool reponse = false;
            string chemin = "";            
            switch (connexionType)
            {
                case ConnexionType.SQLServer:
                    chemin = "Data Source=" + con.Serveur + "; Initial Catalog=" + con.Database + "; User Id=" + con.User + "; Password=" + con.Password+";";
                    File.WriteAllText(ClsConstante.Table.cheminSql, chemin.ToString());                   
                    reponse= true;
                    break;
                case ConnexionType.MySQL:
                    chemin = "Server=" + con.Serveur + "; Database=" + con.Database + "; UserId=" + con.User + "; Password=" + con.Password + ";";
                   // File.WriteAllText(ClsConstante.Table.cheminMysql, chemin.ToString());
                    reponse = true;
                    break;
            }
            return reponse;
        }
        Connexions con = new Connexions();

        public static bool BackUp(string txtpar, string database)
        {
            bool reponse = false;
            try
            {
                   if (txtpar == string.Empty)
                {
                    MessageBox.Show("Veiller parcouris svp Avant de faire le backup");
                }
                else
                {
                    if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                        ImplementeConnexion.Instance.Conn.Open();

                    using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                    {
                        string sql = "BACKUP DATABASE [" + database + "] TO DISK='" + txtpar + "\\" + database + "--" + "--" + "" + DateTime.Now.Ticks.ToString().ToUpper() + ".bak'";
                        cmd.CommandText = sql;
                        //cmd.CommandText = "BACKUP DATABASE [" + database + "] TO DISK='" + txtpar + "\\" + database + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss")+".bak'";
                        //cmd.CommandText = "BACKUP DATABASE [" + database + "] TO DISK='" + txtpar + "\\" + database +"-"+ DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                        cmd.ExecuteNonQuery();
                        reponse = true;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            return reponse;
        }
        public static bool Restaure_Backup(string textrestor, string database)
        {
            bool ok = false;
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
              
                    cmd.CommandText = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK= N'" + textrestor + "' WITH REPLACE;";                 
                   cmd.ExecuteNonQuery();
                    ok = true;
                }
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText =  string.Format("USE MASTER ALTER DATABASE [" + database + "] SET MULTI_USER");
                    cmd.ExecuteNonQuery();

                }
                 textrestor = "";
                ImplementeConnexion.Instance.Conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ok;
        }
        string  nomchemin;
        public string CheminFichier(int choix)
        {
            try
            {
                switch (choix)
                {
                    case 1:
                        FolderBrowserDialog fi = new FolderBrowserDialog();
                        if (fi.ShowDialog() == DialogResult.OK)
                        {
                            nomchemin = fi.SelectedPath;
                        }
                        else { nomchemin = ""; }

                        break;
                    case 2:
                        OpenFileDialog rest = new OpenFileDialog();
                        rest.Filter = "SQL SERVER database backup files|*.bak";
                        rest.Title = "Restauration de base de données";
                        if (rest.ShowDialog() == DialogResult.OK)
                        {
                            nomchemin = rest.FileName;
                        }
                        else { nomchemin = ""; }
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return nomchemin;

        }
        public static void SelectionnerBd(ComboBox combo)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM sys.databases d WHERE d.database_id>4";
                cmd.ExecuteNonQuery();
                IDataReader reader = cmd.ExecuteReader();
                combo.Items.Clear();
                while (reader.Read())
                {
                    combo.Items.Add(reader[0].ToString());
                }
                reader.Dispose();
                ImplementeConnexion.Instance.Conn.Close();
            }
        }
    }
}
