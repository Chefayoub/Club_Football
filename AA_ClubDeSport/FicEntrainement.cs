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
    public partial class EcranEntrainement : Form
    {
        string sConnexion;
        private DataTable dtEntrainement;
        private BindingSource bsEntrainement;

        public EcranEntrainement()
        {
            InitializeComponent();
        }

        #region Methodes activers
        private void Activer(bool lPrincipal)
        {
            dgvEntrainement.Enabled = lPrincipal;
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = lPrincipal;
            tbIDEntrainement.Enabled = dtpEntrainement.Enabled = tbIDEquipe.Enabled = tbIDTerrain.Enabled = !lPrincipal;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipal;
        }
        private void Activer2(bool lPrincipal)
        {
            dgvEntrainement.Enabled = lPrincipal;
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = lPrincipal;
            tbIDEntrainement.Enabled = lPrincipal;
            dtpEntrainement.Enabled = tbIDEquipe.Enabled = tbIDTerrain.Enabled = !lPrincipal;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipal;
        }
        #endregion

        private void RemplirDGV()
        {
            dtEntrainement = new DataTable();
            dtEntrainement.Columns.Add(new DataColumn("ID_Entrainement", System.Type.GetType("System.Int32")));
            dtEntrainement.Columns.Add(new DataColumn("ID_Equipe", System.Type.GetType("System.Int32")));
            dtEntrainement.Columns.Add(new DataColumn("Date"));
            dtEntrainement.Columns.Add(new DataColumn("ID_Terrain", System.Type.GetType("System.Int32")));

            List<C_T_Entrainement> lTmp = new G_T_Entrainement(sConnexion).Lire("ID_Entrainement");
            foreach (C_T_Entrainement p in lTmp)
            {
                dtEntrainement.Rows.Add(p.ID_Entrainement, p.ID_Equipe, p.Date.ToString("g"), p.ID_Terrain);
            }
            bsEntrainement = new BindingSource();
            bsEntrainement.DataSource = dtEntrainement;
            dgvEntrainement.DataSource = bsEntrainement;
        }
        private void EcranEntrainement_Load(object sender, EventArgs e)
        {
            // Accede a la chaine de caractere
            sConnexion = ConfigurationManager.ConnectionStrings["AA_ClubDeSport.Properties.Settings.BDConnectionString_Couches"].ConnectionString;
            RemplirDGV();
            if (dgvEntrainement.Rows.Count > 0)
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
            tbIDEntrainement.Text = "";
            dtpEntrainement.Value = DateTime.Today;
            Activer2(false);
            dtpEntrainement.Focus();
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            if (dgvEntrainement.SelectedRows.Count > 0)
            {
                tbIDEntrainement.Text = dgvEntrainement.SelectedRows[0].Cells["cIDEntrainement"].Value.ToString();
                C_T_Entrainement pTmp = new G_T_Entrainement(sConnexion).Lire_ID(int.Parse(tbIDEntrainement.Text));
                dtpEntrainement.Value = pTmp.Date == null ? DateTime.Today : (DateTime)pTmp.Date;
                tbIDEquipe.Text = pTmp.ID_Equipe.ToString();
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
            if (dgvEntrainement.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer l'enregistrement ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int iID = (int)dgvEntrainement.SelectedRows[0].Cells["cIDEntrainement"].Value;
                    new G_T_Entrainement(sConnexion).Supprimer(iID);
                    bsEntrainement.RemoveCurrent();
                    MessageBox.Show("Entrainement supprimer", "SUPPRIMER", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            bool idEq = Int32.TryParse(tbIDEquipe.Text, out number);
            bool idTer = Int32.TryParse(tbIDTerrain.Text, out number);

            if (tbIDEquipe.Text.Trim() == "" || tbIDTerrain.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez renseigner tous les champs ! ");
            }
            else if (!idEq || !idTer) { MessageBox.Show("Erreur dencodage"); }
            else
            {
                if (tbIDEntrainement.Text == "")
                //Ajout
                {
                    int iID = new G_T_Entrainement(sConnexion).Ajouter(dtpEntrainement.Value, int.Parse(tbIDTerrain.Text), int.Parse(tbIDEquipe.Text));
                    tbIDEntrainement.Text = iID.ToString();
                    tbIDEquipe.Text = iID.ToString();
                    dtEntrainement.Rows.Add(iID, iID, dtpEntrainement);
                    MessageBox.Show("Entrainement ajouter", "AJOUTER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                //Modification
                {
                    new G_T_Entrainement(sConnexion).Modifier(int.Parse(tbIDEntrainement.Text), dtpEntrainement.Value, int.Parse(tbIDTerrain.Text), int.Parse(tbIDEquipe.Text));
                    dgvEntrainement.SelectedRows[0].Cells["cIDEntrainement"].Value = tbIDEntrainement.Text;
                    dgvEntrainement.SelectedRows[0].Cells["cIDEquipe"].Value = tbIDEquipe.Text;
                    dgvEntrainement.SelectedRows[0].Cells["cDate"].Value = dtpEntrainement.Text;
                    dgvEntrainement.SelectedRows[0].Cells["cIDTerrain"].Value = tbIDTerrain.Text;
                    bsEntrainement.EndEdit();
                    MessageBox.Show("Entrainement modifier", "MODIFIER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                tbIDEntrainement.Clear();
                tbIDEquipe.Clear();
                tbIDTerrain.Clear();
                //dtpEntrainement.Clear();
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
