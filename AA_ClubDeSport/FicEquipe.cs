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
using System.Threading;

namespace AA_ClubDeSport
{
    public partial class EcranEquipe : Form
    {
        string sConnexion;
        private DataTable dtEquipe;
        private BindingSource bsEquipe;

        public EcranEquipe()
        {
            InitializeComponent();
        }

        #region Methodes activers
        private void Activer(bool lPrincipal)
        {
            dgvEquipe.Enabled = lPrincipal;
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = lPrincipal;
            tbNom.Enabled = tbIDEquipe.Enabled = tbIDClub.Enabled = !lPrincipal;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipal;


        }
        private void Activer2(bool lPrincipal)
        {
            dgvEquipe.Enabled = lPrincipal;
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = lPrincipal;
            tbIDEquipe.Enabled = lPrincipal;
            tbNom.Enabled =  tbIDClub.Enabled = !lPrincipal;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipal;
        }
        #endregion

        private void RemplirDGV()
        {
            dtEquipe = new DataTable();
            dtEquipe.Columns.Add(new DataColumn("ID_Equipe", System.Type.GetType("System.Int32")));
            dtEquipe.Columns.Add(new DataColumn("ID_Club", System.Type.GetType("System.Int32")));
            dtEquipe.Columns.Add(new DataColumn("Nom"));
           
            List<C_T_Equipe> lTmp = new G_T_Equipe(sConnexion).Lire("ID_Equipe");
            foreach (C_T_Equipe p in lTmp)
            {
                dtEquipe.Rows.Add(p.ID_Equipe,p.ID_Club,p.Nom);
            }
            bsEquipe = new BindingSource();
            bsEquipe.DataSource = dtEquipe;
            dgvEquipe.DataSource = bsEquipe;
        }

        private void EcranEquipe_Load(object sender, EventArgs e)
        {
            // Accede a la chaine de caractere
            sConnexion = ConfigurationManager.ConnectionStrings["AA_ClubDeSport.Properties.Settings.BDConnectionString_Couches"].ConnectionString;
            RemplirDGV();
            if (dgvEquipe.Rows.Count > 0)
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
            tbNom.Text = "";
            Activer2(false);
            tbNom.Focus();
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            if (dgvEquipe.SelectedRows.Count > 0)
            {
                tbIDEquipe.Text = dgvEquipe.SelectedRows[0].Cells["cIDEquipe"].Value.ToString();
                C_T_Equipe pTmp = new G_T_Equipe(sConnexion).Lire_ID(int.Parse(tbIDEquipe.Text));
                tbIDClub.Text = pTmp.ID_Club.ToString();
                tbNom.Text = pTmp.Nom;
                Activer2(false);
            }
            else
            {
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvEquipe.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer l'enregistrement ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int iID = (int)dgvEquipe.SelectedRows[0].Cells["cIDEquipe"].Value;
                    new G_T_Equipe(sConnexion).Supprimer(iID);
                    bsEquipe.RemoveCurrent();
                    MessageBox.Show("Equipe supprimer", "SUPPRIMER", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            bool idEquipe = Int32.TryParse(tbIDClub.Text, out number);
            bool idClub = Int32.TryParse(tbIDClub.Text, out number);

            if (tbNom.Text.Trim() == "" || tbIDClub.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez renseigner tous les champs ! ");
            }
            else if (!idClub || !idEquipe) { MessageBox.Show("Erreur dencodage"); }
            else
            {
                if (tbIDEquipe.Text == "")
                //Ajout
                {
                    int iID = new G_T_Equipe(sConnexion).Ajouter(tbNom.Text, int.Parse(tbIDClub.Text));
                    tbIDEquipe.Text = iID.ToString();
                    tbIDClub.Text = iID.ToString();
                    dtEquipe.Rows.Add(iID, iID, tbNom.Text);
                    MessageBox.Show("Equipe ajouter", "AJOUTER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                //Modification
                {                    
                    new G_T_Equipe(sConnexion).Modifier(int.Parse(tbIDEquipe.Text), tbNom.Text, int.Parse(tbIDClub.Text));
                    dgvEquipe.SelectedRows[0].Cells["cIDEquipe"].Value = tbIDEquipe.Text;
                    dgvEquipe.SelectedRows[0].Cells["cIDClub"].Value = tbIDEquipe.Text;
                    dgvEquipe.SelectedRows[0].Cells["cNom"].Value = tbNom.Text;
                    bsEquipe.EndEdit();
                    MessageBox.Show("Equipe modifier", "MODIFIER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                tbIDEquipe.Clear();
                tbIDClub.Clear();
                tbNom.Clear();
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
