using DevExpress.XtraReports.UI;
using ProCouture.ClsProprietes;
using ProCouture.ClsTraitements;
using ProCouture.Connexion;
using ProCouture.Fonctions;
using ProCouture.Proprietes;
using ProCouture.Rapports;
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
    public partial class AjoutDepense : Form
    {
        public AjoutDepense()
        {
            InitializeComponent();
        }
        ProprietePublique pro = new ProprietePublique();
        ClsFonctions fx = new ClsFonctions();
        DynamicClass d = new DynamicClass();
        private void montant_TextChanged(object sender, EventArgs e)
        {
            fx.ErrorProvide(errorProvider1, montant);
        }        
        private void AjoutDepense_Load(object sender, EventArgs e)
        {
            ImplementeConnexion.Instance.Initialise();
            DataGrid();
            ClsFonctions.Instance.ProprieteDatagrid(Table);
            fx.Picture_Rond(profil);
        }
        public void DataGrid()
        {
            try
            {
                Table.DataSource = d.GetTableUsingSql("V_Depense");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        private void montant_TextChanged_1(object sender, EventArgs e)
        {
            fx.ErrorProvide(errorProvider1, montant);
        }
        Depense dp = new Depense();
        string id = "0";
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string a = pro.Montant("Liste_Recu where id is not null and Etat=1", "sum(isnull(Paye,0)) ").ToString();
                string b = pro.Montant("V_Depense where id is not null and Etat=1", "sum(isnull(Montant,0)) ").ToString();
                decimal c = (decimal.Parse(a) - decimal.Parse(b));
                switch (btnSave.Text)
                {
                    case "Enregistrer":

                        if (fx.Question(1) == true)
                        {
                            dp.Id = fx.ValidateName(id);
                            dp.Motif = fx.ValidateName(motif.Text);
                            dp.Montant =decimal.Parse( fx.ValidateName(montant.Text));
                            dp.IdAgent = fx.ValidateName(idagent.Text); if(decimal.Parse(montant.Text) < c)
                            {
                                if (dp.Enregistrer() == true)
                                {
                                    fx.Message(1);
                                    Actualiser();
                                }
                            }else
                            {
                                MessageBox.Show("Desolé vous ne pouvez pas sortir le montant supérieur au montant disponible qui est " + c + "", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case "Modifier":
                        if (fx.Question(2) == true)
                        {
                            dp.Id = fx.ValidateName(id);
                            dp.Motif = fx.ValidateName(motif.Text);
                            dp.Montant = decimal.Parse(fx.ValidateName(montant.Text));
                            dp.IdAgent = fx.ValidateName(idagent.Text);
                            if (decimal.Parse(montant.Text) < c)
                            {
                                if (dp.Enregistrer() == true)
                                {
                                    fx.Message(2);
                                    Actualiser();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Desolé vous ne devez pas sortir le montant supérieur au montant disponible qui est "+c+"", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        break;
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error when loading datas, " + ex.Message, "Loading datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Error when loading datas, " + ex.Message, "Loading datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            finally
            {
                if (ImplementeConnexion.Instance.Conn != null)
                {
                    if (ImplementeConnexion.Instance.Conn.State == System.Data.ConnectionState.Open)
                        ImplementeConnexion.Instance.Conn.Close();
                }
            }
        }
        public void Actualiser()
        {
            motif.Text = "";
            montant.Text = "00";
            DataGrid();
            save.Visible = true;
            update.Visible = false;
            btnSave.Text = "Enregistrer";
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Actualiser();
        }
        private void Table_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Text = "Modifier";
                save.Visible = false;
                update.Visible = true;
                id = Table.SelectedCells[0].Value.ToString();
                motif.Text = Table.SelectedCells[2].Value.ToString();
                montant.Text = Table.SelectedCells[3].Value.ToString();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        } private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        ClsRapports clr = new ClsRapports();
        private void label15_Click(object sender, EventArgs e)
        {
            
                RpDepense xtp = new RpDepense();
                xtp.DataSource = clr.GetInstance().SelectAll("V_Depense where Etat = 1");
                ReportPrintTool printTool = new ReportPrintTool(xtp);
                printTool.ShowRibbonPreview();
        }

        private void recherche_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Table.DataSource = d.recherche_UsignSql("select * from V_Depense  where id is not null and  Motif LIKE '%" + recherche.Text + "%'");

            }
            catch (Exception ex)
          { MessageBox.Show(ex.Message); }
        }

        private void recherche_Enter(object sender, EventArgs e)
        {
            if (recherche.Text == "Tapez ici le mot de Recherche")
            {
                recherche.Text = "";
            }
        }
    }
    
}
