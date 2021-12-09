using ProCouture.Connexion;
using ProCouture.Fonctions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProCouture.ClsProprietes
{
    public class Paiement
    {
        private string _id;
        private string _idAgent;
        private decimal _montant;
        private string _idPatient;
        private int __idProCouture;
        private decimal _apayer;

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

        public string IdAgent
        {
            get
            {
                return _idAgent;
            }

            set
            {
                _idAgent = value;
            }
        }

        public decimal Montant
        {
            get
            {
                return _montant;
            }

            set
            {
                _montant = value;
            }
        }

        public string IdPatient
        {
            get
            {
                return _idPatient;
            }

            set
            {
                _idPatient = value;
            }
        }

        public int IdProCouture
        {
            get
            {
                return __idProCouture;
            }

            set
            {
                __idProCouture = value;
            }
        }

        public decimal Apayer
        {
            get
            {
                return _apayer;
            }

            set
            {
                _apayer = value;
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
                    cmd.CommandText = "sp_insert_Paiement";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Id", 50, DbType.Int32, _id));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Patient", 50, DbType.String, _idPatient));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdAgent", 50, DbType.Int32, _idAgent));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdProCouture", 50, DbType.Int32, IdProCouture));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Montant", 50, DbType.Decimal, _montant));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Apayer", 50, DbType.Decimal, _apayer));
                    cmd.ExecuteNonQuery();
                    reponse = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { ImplementeConnexion.Instance.Conn.Close(); }
            return reponse;
        }

    }
}
