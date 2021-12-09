using ProCouture.ClsTraitements;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        ClsFonctions fx = new ClsFonctions();
        DynamicClass d = new DynamicClass();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmFinance m = new FrmFinance();
            fx.openChildForm(m, afficher);           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Commande m = new Commande();
            fx.openChildForm(m, afficher);
        }
    }
}
