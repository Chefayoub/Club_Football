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
    public partial class EcranClub : Form
    {
        string sConnexion;
        private DataTable dtClub; // Stock les donner
        private BindingSource bsClub;

        public EcranClub()
        {
            InitializeComponent();
        }

        #region Methodes activers
        private void Activer(bool lPrincipal)
        {
            dgvClub.Enabled = lPrincipal;
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = lPrincipal;
            tbIDClub.Enabled = tbNom.Enabled = tbRue.Enabled = tbNumero.Enabled = tbCP.Enabled = tbLocalite.Enabled = cbMonClub.Enabled = !lPrincipal;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipal;
        }
        private void Activer2(bool lPrincipal)
        {
            dgvClub.Enabled = lPrincipal;
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = lPrincipal;
            tbIDClub.Enabled = lPrincipal;
            tbNom.Enabled = tbRue.Enabled = tbNumero.Enabled = tbCP.Enabled = tbLocalite.Enabled = cbMonClub.Enabled = !lPrincipal;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipal;
        }
        #endregion

        private void RemplirDGV()
        {
            dtClub = new DataTable();
            dtClub.Columns.Add(new DataColumn("ID_Club", System.Type.GetType("System.Int32")));
            dtClub.Columns.Add(new DataColumn("Nom"));
            dtClub.Columns.Add(new DataColumn("Rue"));
            dtClub.Columns.Add(new DataColumn("Numero"));
            dtClub.Columns.Add(new DataColumn("Code_Postal"));
            dtClub.Columns.Add(new DataColumn("Localite"));
            dtClub.Columns.Add(new DataColumn("Mon_Club"));

            List<C_T_Club> lTmp = new G_T_Club(sConnexion).Lire("ID_Club");
            foreach (C_T_Club p in lTmp)
            {
                dtClub.Rows.Add(p.ID_Club, p.Nom, p.Rue, p.Numero, p.Code_Postal, p.Localite, p.Mon_Club);
            }
            bsClub = new BindingSource();
            bsClub.DataSource = dtClub;
            dgvClub.DataSource = bsClub;
        }

        private void EcranClub_Load(object sender, EventArgs e)
        {
            // Accede a la chaine de caractere
            sConnexion = ConfigurationManager.ConnectionStrings["AA_ClubDeSport.Properties.Settings.BDConnectionString_Couches"].ConnectionString;
            RemplirDGV();
            if (dgvClub.Rows.Count > 0)
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
            if (dgvClub.SelectedRows.Count > 0)
            {
                tbIDClub.Text = dgvClub.SelectedRows[0].Cells["cIDClub"].Value.ToString();
                C_T_Club pTmp = new G_T_Club(sConnexion).Lire_ID(int.Parse(tbIDClub.Text));
                tbNom.Text = pTmp.Nom;
                tbRue.Text = pTmp.Rue;
                tbNumero.Text = pTmp.Numero.ToString();
                tbCP.Text = pTmp.Code_Postal.ToString();
                tbLocalite.Text = pTmp.Localite;
                cbMonClub.Text = pTmp.Mon_Club;
                Activer2(false);
            }
            else
            {
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvClub.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer l'enregistrement ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int iID = (int)dgvClub.SelectedRows[0].Cells["cIDClub"].Value;
                    new G_T_Club(sConnexion).Supprimer(iID);
                    bsClub.RemoveCurrent();
                    MessageBox.Show("Club supprimer", "SUPPRIMER", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            bool idNum = Int32.TryParse(tbNumero.Text, out number);
            bool cp = Int32.TryParse(tbCP.Text, out number);


            if (tbNom.Text.Trim() == "" || tbRue.Text.Trim() == "" || tbNumero.Text.Trim() == "" || tbLocalite.Text.Trim() == "" || tbCP.Text.Trim() == "" || cbMonClub.Text.Trim()=="")
            {
                MessageBox.Show("Veuillez renseigner tous les champs ! ");
            }
            else if (!idNum || !cp) { MessageBox.Show("Erreur dencodage"); } 
            else
            {
                if (tbIDClub.Text == "")
                //Ajout
                {
                    int iID = new G_T_Club(sConnexion).Ajouter(tbNom.Text, tbRue.Text, int.Parse(tbNumero.Text), int.Parse(tbCP.Text), tbLocalite.Text, cbMonClub.Text);
                    tbIDClub.Text = iID.ToString();
                    dtClub.Rows.Add(iID, tbNom.Text,tbRue.Text, int.Parse(tbNumero.Text), int.Parse(tbCP.Text), tbLocalite.Text, cbMonClub.Text);
                    MessageBox.Show("Club ajouter", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                //Modification
                {
                    new G_T_Club(sConnexion).Modifier(int.Parse(tbIDClub.Text), tbNom.Text, tbRue.Text, int.Parse(tbNumero.Text), int.Parse(tbCP.Text), tbLocalite.Text, cbMonClub.Text);
                    dgvClub.SelectedRows[0].Cells["cIDClub"].Value = tbIDClub.Text;
                    dgvClub.SelectedRows[0].Cells["cNom"].Value = tbNom.Text;
                    dgvClub.SelectedRows[0].Cells["cRue"].Value = tbRue.Text;
                    dgvClub.SelectedRows[0].Cells["cNumero"].Value = tbNumero.Text;
                    dgvClub.SelectedRows[0].Cells["cCodePostal"].Value = tbCP.Text;
                    dgvClub.SelectedRows[0].Cells["cLocalite"].Value = tbLocalite.Text;
                    dgvClub.SelectedRows[0].Cells["cMonClub"].Value = cbMonClub.Text;
                    bsClub.EndEdit();
                    MessageBox.Show("Club modifier", "MODIFIER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                tbIDClub.Clear();
                tbNom.Clear();
                tbRue.Clear();
                tbNumero.Clear();
                tbCP.Clear();
                tbLocalite.Clear();
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
