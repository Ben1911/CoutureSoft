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
    public class Client
    {
        private string _id;
        private string _idPersonne;
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

        public bool Enregistrer()
        {
            bool reponse = false;
            try { 
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "[sp_insert_Client]";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Id", 50, DbType.String, _id));
                cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdPersonne", 50, DbType.Int32, _idPersonne));
                cmd.ExecuteNonQuery();
                reponse = true;
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            return reponse;
        }     

       
       
    }
}
