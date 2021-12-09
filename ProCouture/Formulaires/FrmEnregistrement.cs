using ProCouture.Fonctions;
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
    public partial class FrmEnregistrement : Form
    {
        public FrmEnregistrement()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        ClsFonctions fx = new ClsFonctions();
        private void label1_Click(object sender, EventArgs e)
        {
            AjoutPersonne p = new AjoutPersonne();
            fx.openChildForm( p, PanelAffichage);
            panelMouve.Height = panel2.Height;
            panelMouve.Top = panel2.Top;
        }
        
        private void label2_Click(object sender, EventArgs e)
        {
            switch (niveau.Text)
            {
                case "1":
                    //AjoutConsultation p = new AjoutConsultation();
                    //p.idagent.Text = idagent.Text;
                    //panelMouve.Height = panel3.Height;
                    //panelMouve.Top = panel3.Top;
                    //fx.openChildForm(p, PanelAffichage);

                    break;
                case "2":

                  

                    break;
                case "3":


                    break;
                default:
                    MessageBox.Show("Vous n'avez pas l'autorisation d'acceder à ce formulaire ! ", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ; break;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            switch (niveau.Text)
            {
                case "1":
                   

                    break;
                case "2":

                    //AjoutExamen ex = new AjoutExamen();
                    //ex.idagent.Text = idagent.Text;
                    //fx.openChildForm(ex, PanelAffichage);
                    //panelMouve.Height = panel4.Height;
                    //panelMouve.Top = panel4.Top;

                    break;
                case "3":

                   

                    break;
                default:
                    MessageBox.Show("Vous n'avez pas l'autorisation d'acceder à ce formulaire ! ", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ; break;
            }
        }
        private void categorie_Click(object sender, EventArgs e)
        {
            AjoutCategorie p = new AjoutCategorie();
            p.idagent.Text = idagent.Text;
            fx.openChildForm(p, PanelAffichage);
            panelMouve.Height = panel8.Height;
            panelMouve.Top = panel8.Top;
        }
        private void label5_Click(object sender, EventArgs e)
        {
            //AjoutAdresse p = new AjoutAdresse();
            //PanelAffichage.Controls.Clear();
            //panelMouve.Height = panel7.Height;
            //panelMouve.Top = panel7.Top;
            //fx.openChildForm(p, PanelAffichage);
        }
        private void label4_Click(object sender, EventArgs e)
        {
            switch (niveau.Text)
            {
                case "1":

                    

                    break;
                case "2":
                    //Commande m = new Commande();
                    //fx.openChildForm(m, PanelAffichage);
                    //m.idagent.Text = idagent.Text;
                    //panelMouve.Height = panel5.Height;
                    //panelMouve.Top = panel5.Top;

                    break;
                case "3":

                    //Commande med = new Commande();
                    //fx.openChildForm(med, PanelAffichage);
                    //med.idagent.Text = idagent.Text;
                    //panelMouve.Height = panel5.Height;
                    //panelMouve.Top = panel5.Top;

                    break;
                default:
                    MessageBox.Show("Vous n'avez pas l'autorisation d'acceder à ce formulaire ! ", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ; break;
            }
        }

        private void FrmEnregistrement_Load(object sender, EventArgs e)
        {
            AjoutPersonne p = new AjoutPersonne();
            PanelAffichage.Controls.Clear();
            fx.openChildForm(p, PanelAffichage);
            panelMouve.Height = panel2.Height;
            panelMouve.Top = panel2.Top;
        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {
           
        }
        private void label7_Click(object sender, EventArgs e)
        {
            switch (niveau.Text)
            {
                case "1":
                    

                    break;
                case "2":

                    break;
                case "3":
               

                    break;
                default:
                    MessageBox.Show("Vous n'avez pas l'autorisation d'acceder à ce formulaire ! ", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ; break;
            }
        }
    }
}
