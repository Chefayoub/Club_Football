using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_BD_ClubDeSport.Classes;
using Projet_BD_ClubDeSport.Gestion;

namespace AA_ClubDeSport
{
    public partial class EcranMatch : Form
    {
        string sConnexion;
        private DataTable dtMatch;
        private BindingSource bsMatch;

        public EcranMatch()
        {
            InitializeComponent();
        }

        #region Methodes activers
        private void Activer(bool lPrincipal)
        {
            dgvMatch.Enabled = lPrincipal;
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = lPrincipal;
            tbIDMatch.Enabled = tbIDDomicile.Enabled = tbScoreDomicile.Enabled = tbIDAdversaire.Enabled = tbScoreAdversaire.Enabled = dtpMatch.Enabled = tbIDTerrain.Enabled = !lPrincipal;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipal;
        }
        private void Activer2(bool lPrincipal)
        {
            dgvMatch.Enabled = lPrincipal;
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = lPrincipal;
            tbIDMatch.Enabled = lPrincipal;
            tbIDDomicile.Enabled = tbScoreDomicile.Enabled = tbIDAdversaire.Enabled = tbScoreAdversaire.Enabled = dtpMatch.Enabled = tbIDTerrain.Enabled = !lPrincipal;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipal;
        }
        #endregion

        private void RemplirDGV()
        {
            dtMatch = new DataTable();
            dtMatch.Columns.Add(new DataColumn("ID_Match", System.Type.GetType("System.Int32")));
            dtMatch.Columns.Add(new DataColumn("ID_Domicile", System.Type.GetType("System.Int32")));
            dtMatch.Columns.Add(new DataColumn { ColumnName = "Score_Domicile", DataType = System.Type.GetType("System.Int32"), AllowDBNull = true });
            dtMatch.Columns[2].AllowDBNull = true;
            dtMatch.Columns.Add(new DataColumn("ID_Adversaire", System.Type.GetType("System.Int32")));
            dtMatch.Columns.Add(new DataColumn { ColumnName = "Score_Adversaire", DataType = System.Type.GetType("System.Int32"), AllowDBNull = true });
            dtMatch.Columns[4].AllowDBNull = true;
            dtMatch.Columns.Add(new DataColumn("Date"));
            dtMatch.Columns.Add(new DataColumn("ID_Terrain", System.Type.GetType("System.Int32")));


            List<C_T_Match> lTmp = new G_T_Match(sConnexion).Lire("ID_Match");
            foreach (C_T_Match p in lTmp)
            {
                dtMatch.Rows.Add(p.ID_Match, p.ID_Domicile, p.Score_Domicile, p.ID_Deplacement, p.Score_Adversaire, p.Date.ToString("g"), p.ID_Terrain);
            }
            bsMatch = new BindingSource();
            bsMatch.DataSource = dtMatch;
            dgvMatch.DataSource = bsMatch;
        }

        private void EcranMatch_Load(object sender, EventArgs e)
        {
            // Accede a la chaine de caractere
            sConnexion = ConfigurationManager.ConnectionStrings["AA_ClubDeSport.Properties.Settings.BDConnectionString_Couches"].ConnectionString;
            RemplirDGV();
            if (dgvMatch.Rows.Count > 0)
            {
                Activer(true);
            }
            else
            {
                Activer(false);
            }
        }

        #region Boutons
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            tbIDMatch.Text = "";
            Activer2(false);
            tbIDDomicile.Focus();
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            if (dgvMatch.SelectedRows.Count > 0)
            {
                tbIDMatch.Text = dgvMatch.SelectedRows[0].Cells["cIDMatch"].Value.ToString();
                C_T_Match pTmp = new G_T_Match(sConnexion).Lire_ID(int.Parse(tbIDMatch.Text));
                tbIDDomicile.Text = pTmp.ID_Domicile.ToString();
                tbScoreDomicile.Text = pTmp.Score_Domicile.ToString();
                tbIDAdversaire.Text = pTmp.ID_Deplacement.ToString();
                tbScoreAdversaire .Text = pTmp.Score_Adversaire.ToString();
                dtpMatch.Value = pTmp.Date == null ? DateTime.Today : (DateTime)pTmp.Date;
                tbIDTerrain.Text = pTmp.ID_Terrain.ToString();
                Activer2(false);
            }
            else
            {
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvMatch.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer l'enregistrement ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int iID = (int)dgvMatch.SelectedRows[0].Cells["cIDMatch"].Value;
                    new G_T_Match(sConnexion).Supprimer(iID);
                    bsMatch.RemoveCurrent();
                    MessageBox.Show("Match supprimer", "SUPPRIMER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            int number;
            bool idDom = Int32.TryParse(tbIDDomicile.Text, out number);
            bool idAdv = Int32.TryParse(tbIDAdversaire.Text, out number);
            bool scoreD = Int32.TryParse(tbScoreDomicile.Text, out number);
            bool scoreA = Int32.TryParse(tbScoreAdversaire.Text, out number);
            bool idTer = Int32.TryParse(tbIDTerrain.Text, out number);

            if (tbIDAdversaire.Text.Trim() == "" || tbIDDomicile.Text.Trim() == "" || tbIDTerrain.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez renseigner tous les champs ! ");
            }
            else if (!idDom || !idAdv || !idTer) { MessageBox.Show("Erreur dencodage"); }
            
            else
            {

                if (tbIDMatch.Text == "")
                //Ajout
                {
                    if (tbScoreDomicile.Text == "" && tbScoreAdversaire.Text == "")
                    {
                        int iID = new G_T_Match(sConnexion).Ajouter(null, null, dtpMatch.Value, int.Parse(tbIDDomicile.Text), 
                            int.Parse(tbIDAdversaire.Text), int.Parse(tbIDTerrain.Text));
                        tbIDMatch.Text = iID.ToString();
                        tbIDDomicile.Text = iID.ToString();
                        tbIDAdversaire.Text = iID.ToString();
                        tbIDTerrain.Text = iID.ToString();
                        dtMatch.Rows.Add(iID, iID, null, iID, null, dtpMatch.Value, tbIDTerrain.Text);
                        MessageBox.Show("Match ajouter", "AJOUTER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int iID = new G_T_Match(sConnexion).Ajouter(int.Parse(tbScoreDomicile.Text), int.Parse(tbScoreAdversaire.Text), dtpMatch.Value,
                            int.Parse(tbIDDomicile.Text), int.Parse(tbIDAdversaire.Text), int.Parse(tbIDTerrain.Text));
                        tbIDMatch.Text = iID.ToString();
                        tbIDDomicile.Text = iID.ToString();
                        tbIDAdversaire.Text = iID.ToString();
                        tbIDTerrain.Text = iID.ToString();
                        dtMatch.Rows.Add(iID, iID, tbScoreDomicile.Text, iID, tbScoreAdversaire.Text, dtpMatch.Value, tbIDTerrain.Text);
                        MessageBox.Show("Match ajouter", "AJOUTER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                //Modification
                {
                    if (tbScoreDomicile.Text == "" && tbScoreAdversaire.Text == "")
                    {
                        new G_T_Match(sConnexion).Modifier(int.Parse(tbIDMatch.Text), null, null,
                            dtpMatch.Value, int.Parse(tbIDDomicile.Text), int.Parse(tbIDAdversaire.Text), int.Parse(tbIDTerrain.Text));
                        dgvMatch.SelectedRows[0].Cells["cIDMatch"].Value = tbIDMatch.Text;
                        dgvMatch.SelectedRows[0].Cells["cIDDomicile"].Value = tbIDDomicile.Text;
                        dgvMatch.SelectedRows[0].Cells["cScoreDomicile"].Value = DBNull.Value;
                        dgvMatch.SelectedRows[0].Cells["cIDAdversaire"].Value = tbIDAdversaire.Text;
                        dgvMatch.SelectedRows[0].Cells["cScoreAdversaire"].Value = DBNull.Value;
                        dgvMatch.SelectedRows[0].Cells["cDate"].Value = dtpMatch.Text;
                        dgvMatch.SelectedRows[0].Cells["cIDTerrain"].Value = tbIDTerrain.Text;
                        dgvMatch.EndEdit();
                        MessageBox.Show("Match modifier", "MODIFIER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        new G_T_Match(sConnexion).Modifier(int.Parse(tbIDMatch.Text), int.Parse(tbScoreDomicile.Text), int.Parse(tbScoreAdversaire.Text),
                            dtpMatch.Value, int.Parse(tbIDDomicile.Text), int.Parse(tbIDAdversaire.Text), int.Parse(tbIDTerrain.Text));
                        dgvMatch.SelectedRows[0].Cells["cIDMatch"].Value = tbIDMatch.Text;
                        dgvMatch.SelectedRows[0].Cells["cIDDomicile"].Value = tbIDDomicile.Text;
                        dgvMatch.SelectedRows[0].Cells["cScoreDomicile"].Value = tbScoreDomicile.Text;
                        dgvMatch.SelectedRows[0].Cells["cIDAdversaire"].Value = tbIDAdversaire.Text;
                        dgvMatch.SelectedRows[0].Cells["cScoreAdversaire"].Value = tbScoreAdversaire.Text;
                        dgvMatch.SelectedRows[0].Cells["cDate"].Value = dtpMatch.Text;
                        dgvMatch.SelectedRows[0].Cells["cIDTerrain"].Value = tbIDTerrain.Text;
                        dgvMatch.EndEdit();
                        MessageBox.Show("Match modifier", "MODIFIER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                tbIDMatch.Clear();
                tbIDDomicile.Clear();
                tbIDAdversaire.Clear();
                tbIDTerrain.Clear();
                tbScoreDomicile.Clear();
                tbScoreAdversaire.Clear();                
                Activer(true);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }
        #endregion
    }
}
