using ProCouture.ClsProprietes;
using ProCouture.ClsTraitements;
using ProCouture.Connexion;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FrmQuestion q = new FrmQuestion();
            q.ShowDialog();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }
        DynamicClass d = new DynamicClass();
        Testlogin log = new Testlogin();
        public void Login()
        {
            if (d.loginTest(txtuser.Text, pwd.Text, log) == true)
            {
                this.Hide();
                Form1 fr = new Form1();
                fr.id.Text = log.Id;
                fr.username.Text = log.NomUser;
                fr.niveau.Text = (log.Niveau).ToString();
                fr.fonction.Text = log.Fonction;
                fr.phone.Text = log.Phone;
                fr.ShowDialog();
              
            }
            else
            {
                MessageBox.Show("Le nom ou le mot de passe est incorrect!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuser.Text = "";
                pwd.Text = "";
            }            
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
        private void username_Enter(object sender, EventArgs e)
        {
            
           
        }
        private void username_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void iTalk_RichTextBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void pwd_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void username_MouseLeave_1(object sender, EventArgs e)
        {
            
        }

        private void username_Enter_1(object sender, EventArgs e)
        {
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (Connexions.TestFile() == true)
            {
                ImplementeConnexion.Instance.Initialise();
            }
            else
            {
                MessageBox.Show("Désolé les fichier de la connexion est introuvable ! , ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void afficher_CheckedChanged(object sender, EventArgs e)
        {
            if (!afficher.Checked == true)
            {
                pwd.UseSystemPasswordChar = true;
            }
            else { pwd.UseSystemPasswordChar = false; }
        }
        private void pwd_TextChanged(object sender, EventArgs e)
        {           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsave.PerformClick();
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void btnsave_Click_2(object sender, EventArgs e)
        {

            if (txtuser.Text == "" || pwd.Text == "")
            {
                MessageBox.Show("Le nom ou le mot de passe ne doit pas être vide ! , ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Login();
            }
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pwd.Focus();
            }
        }
    }
}
