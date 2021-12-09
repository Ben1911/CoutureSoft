using ProCouture.Fonctions;
using ProCouture.Connexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProCouture.ClsProprietes
{
   public class Agent
    {
        private string _id;
        private string _fonction;
        private string _idPersonne;
        private string _username;
        private string _pwd;
        private int _niveau;

        public string Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Fonction
        {
            get
            {
                return _fonction;
            }

            set
            {
                _fonction = value;
            }
        }

        public string IdPersonne
        {
            get
            {
                return _idPersonne;
            }

            set
            {
                _idPersonne = value;
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }

        public string Pwd
        {
            get
            {
                return _pwd;
            }

            set
            {
                _pwd = value;
            }
        }

        public int Niveau
        {
            get
            {
                return _niveau;
            }

            set
            {
                _niveau = value;
            }
        }

        public bool Enregistrer()
        {
            bool reponse = false;
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();

                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "sp_insert_Agent";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Id", 50, DbType.Int32, _id));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Username", 50, DbType.String, _fonction));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Pwd", 50, DbType.String,_idPersonne ));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Niveau", 50, DbType.Int32, _niveau));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Fonction", 50, DbType.String, _fonction));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdPersonne", 50, DbType.String, _idPersonne));
                    cmd.ExecuteNonQuery();
                    reponse = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);  }
            return reponse;
        }      
     

    }
}
