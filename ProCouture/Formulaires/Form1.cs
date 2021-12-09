using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProCouture.Fonctions;
using ProCouture.Formulaires;
using ProCouture.ClsTraitements;

namespace ProCouture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ClsFonctions fx = new ClsFonctions();
        DynamicClass d = new DynamicClass();
        private void AjoutPersonne_Click(object sender, EventArgs e)
        {
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FrmDashbord m = new FrmDashbord();
            panelmouve.Width = picturedash.Width;
            panelmouve.Left = picturedash.Left;
            fx.openChildForm(m, afficher);
            fx.Picture_Rond(profil);
            fx.Picture_Rond(panel3);
            conect.Text = fonction.Text;
        }
        private void produit_Click(object sender, EventArgs e)
        {
           
        }
        private void finance_Click(object sender, EventArgs e)
        {
            switch (niveau.Text)
            {
                case "1":
                   

                    break;
                case "2":

                   

                    break;
                default:
                    MessageBox.Show("Vous n'avez pas l'autorisation d'acceder à ce formulaire ! ", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ; break;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch (niveau.Text)
            {
                case "1":
                   

                    break;
                default:
                    MessageBox.Show("Vous n'avez pas l'autorisation d'acceder à ce formulaire ! ", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ; break;
            }
        }
        private void picturedash_Click(object sender, EventArgs e)
        {
          
            
        }
        private void operation_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Etes-vous sûr de vouloir vous déconnecter?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr.Equals(DialogResult.Yes))
            {
                this.Hide();
                FrmLogin f = new FrmLogin();
                f.Show();
            }           
        }

        private void rapport_Click(object sender, EventArgs e)
        {
            switch (niveau.Text)
            {
                case "1":
                   

                    break;
                case "2":
                    FrmStatistique s = new FrmStatistique();
                  

                    break;
                default:
                    MessageBox.Show("Vous n'avez pas l'autorisation d'acceder à ce formulaire ! ", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ; break;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void profil_Click(object sender, EventArgs e)
        {
            FrmContact cont = new FrmContact();
            d.RetournerPhotoSQl("Profil", "Liste_Agent", "Id", id.Text, cont.profil);
            cont.nom.Text = username.Text;
            cont.fonction.Text = fonction.Text;
            cont.phone.Text = phone.Text;
            cont.ShowDialog();
        }
        private void afficher_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
            FrmDashbord m = new FrmDashbord();
            panelmouve.Width = picturedash.Width;
            panelmouve.Left = label2.Left;
            fx.openChildForm(m, afficher);
            fx.Picture_Rond(profil);
            fx.Picture_Rond(panel3);
            conect.Text = fonction.Text;
            //d.RetournerPhotoSQl("Profil", "Liste_Agent", "Id", id.Text, profil);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FrmMenu m = new FrmMenu();
            panelmouve.Width = menu.Width;
            panelmouve.Left = label7.Left;
            fx.openChildForm(m, afficher);
            fx.Picture_Rond(profil);
            fx.Picture_Rond(panel3);
            conect.Text = fonction.Text;
            //d.RetournerPhotoSQl("Profil", "Liste_Agent", "Id", id.Text, profil);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            FrmConfiguration m = new FrmConfiguration();
            panelmouve.Width = parametre.Width;
            panelmouve.Left = label9.Left;
            fx.openChildForm(m, afficher);
            fx.Picture_Rond(profil);
            fx.Picture_Rond(panel3);
            conect.Text = fonction.Text;
        }
    }
        
    
}
