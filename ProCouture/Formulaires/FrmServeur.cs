using ProCouture.ClsTraitements;
using ProCouture.Connexion;
using ProCouture.Fonctions;
using ManagerConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProCouture.Formulaires
{
    public partial class FrmServeur : Form
    {
        public FrmServeur()
        {
            InitializeComponent();
        }
        public void initialiser()
        {
        }
       
        private void FrmServeur_Load(object sender, EventArgs e)
        {

        }
        Connexions con = new Connexions();
        ClsFonctions fx = new ClsFonctions();
        private void FrmServeur_Load_1(object sender, EventArgs e)
        {
            ImplementeConnexion.Instance.Initialise();
            ClsConfiguration.SelectionnerBd(bd);
            radBackup.Checked = true;
            radRestaurer.Checked = false;

        }

        ClsConfiguration conf = new ClsConfiguration();
        private void AjoutPersonne_Click(object sender, EventArgs e)
        {
            backup.Text= conf.CheminFichier(1);
        }
        public void selection()
        {
            if(radBackup.Checked==true)
            {
                rest.Enabled = false;
                back.Enabled = true;
            }
            else if(radRestaurer.Checked==true)
            {
                rest.Enabled = true;
                back.Enabled = false;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            restaurer.Text = conf.CheminFichier(2);
        }
        ClsDAO dao = new ClsDAO();
        private void btnSave_Click(object sender, EventArgs e)
        {
                try
                {
                if (radBackup.Checked==true)
                {
                    if (dao.Backup(backup.Text, bd.Text) == true)
                    {
                        MessageBox.Show("Backup reçu! ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        initialiser();
                    }
                    else
                    {
                        MessageBox.Show("Backup echoué!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (radRestaurer.Checked == true)
                {
                    if (ClsConfiguration.Restaure_Backup(rest.Text,bd.Text)==true)
                    {
                        MessageBox.Show("La base de données est restaurée avec succès!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        initialiser();
                    }
                    else
                    {
                        MessageBox.Show("Configuration echouée!", "Création de fichier config", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void radBackup_CheckedChanged(object sender, EventArgs e)
        {
            selection();
        }

        private void radRestaurer_CheckedChanged(object sender, EventArgs e)
        {
            selection();
        }
    }
}
