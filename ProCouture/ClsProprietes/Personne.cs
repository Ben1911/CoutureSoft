using ProCouture.Fonctions;
using ProCouture.ClsTraitements;
using ProCouture.Connexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProCouture.ClsProprietes
{
    public class Personne 
    {
        public Personne()
        {
        }

        private string  _id;
        private string _nomComplet;
        private string _sex;
        private string _phone;
        private string _adresse;
        private byte[] _profil;
        
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

      

        private string ValidateName(string nom)
        {
            if (!string.IsNullOrEmpty(nom))
            {
                if (!char.IsLetter(nom[0]))
                    throw new InvalidOperationException("Name must begin with letter !!!");
                else
                {
                    nom = nom.ToLower();
                    return nom[0].ToString().ToUpper() + new string(nom.ToCharArray(), 1, nom.Length - 1);
                }

            }
            else
                throw new InvalidOperationException("Name must have value !!!");
        }

       

        public string Sex
        {
            get
            {
                return _sex;
            }

            set
            {
                _sex = value;
            }
        }       


        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }

       

        public byte[] Profil
        {
            get
            {
                return _profil;
            }

            set
            {
                _profil = value;
            }
        }

      

     

        public string NomComplet1
        {
            get
            {
                return _nomComplet;
            }

            set
            {
                _nomComplet = value;
            }
        }

        public void SavePhoto(byte[] profil, string Table, string code)
        {
            try
            {
                DynamicClass d = new DynamicClass();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {                    
                    d.con = (SqlConnection)ImplementeConnexion.Instance.Conn;
                    cmd.CommandText = "update " + Table + " set Profil= @photo where Code='" + code + "'";
                    if (_profil != null)
                    {
                        cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "photo", int.MaxValue, DbType.Binary, _profil));
                    }
                    else
                    {
                        MessageBox.Show("Pas de photo svp !!");
                        cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "photo", int.MaxValue, DbType.Binary, null));
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                    cmd.CommandText = "sp_insert_Personne";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Id", 50, DbType.Int32, _id));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@NomComplet", 50, DbType.String, _nomComplet));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Sexe", 10, DbType.String, _sex));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Phone", 50, DbType.String, _phone));
                    cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@IdAdresse", 50, DbType.String, _adresse));
                    if (_profil != null)
                    {
                        cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Profil", int.MaxValue, DbType.Binary, _profil));
                    }
                    else
                    {
                        MessageBox.Show("Pas de photo svp !!");
                        cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@Profil", int.MaxValue, DbType.Binary, null));
                    }
                    cmd.ExecuteNonQuery();
                    reponse = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return reponse;
        }
      
        public void Supprimer(string id)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "sp_delete_personne";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(ClsParametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, _id));

                int record = cmd.ExecuteNonQuery();

                if (record == 0)
                    throw new InvalidOperationException("That id does not exist !!!");
            }
        }        
        
    }
}
