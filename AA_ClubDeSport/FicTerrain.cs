using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_BD_ClubDeSport.Classes;
using Projet_BD_ClubDeSport.Gestion;

namespace AA_ClubDeSport
{
    public partial class EcranTerrain : Form
    {
        string sConnexion;
        private DataTable dtTerrain;
        private BindingSource bsTerrain;

        public EcranTerrain()
        {
            InitializeComponent();
        }

        #region Methodes activers
        private void Activer(bool lPrincipal)
        {
            dgvTerrain.Enabled = lPrincipal;
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = lPrincipal;
            tbIDTerrain.Enabled = tbNomTerrain.Enabled = !lPrincipal;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipal;
        }
        private void Activer2(bool lPrincipal)
        {
            dgvTerrain.Enabled = lPrincipal;
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = lPrincipal;
            tbIDTerrain.Enabled = lPrincipal;
            tbNomTerrain.Enabled = !lPrincipal;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipal;
        }
        #endregion

        private void RemplirDGV()
        {
            dtTerrain = new DataTable();
            dtTerrain.Columns.Add(new DataColumn("ID_Terrain", System.Type.GetType("System.Int32")));
            dtTerrain.Columns.Add(new DataColumn("Nom"));
            dtTerrain.Columns.Add(new DataColumn("TypeTerrain"));
            List<C_T_Terrain> lTmp = new G_T_Terrain(sConnexion).Lire("ID_Terrain");

            foreach (C_T_Terrain p in lTmp)
            {
                dtTerrain.Rows.Add(p.ID_Terrain, p.Nom, p.TypeTerrain);
            }
            bsTerrain = new BindingSource();
            bsTerrain.DataSource = dtTerrain;
            dgvTerrain.DataSource = bsTerrain;
        }

        private void EcranTerrain_Load(object sender, EventArgs e)
        {
            // Accede a la chaine de caractere
            sConnexion = ConfigurationManager.ConnectionStrings["AA_ClubDeSport.Properties.Settings.BDConnectionString_Couches"].ConnectionString;
            RemplirDGV();
            if (dgvTerrain.Rows.Count > 0)
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
            tbNomTerrain.Text = "";
            Activer2(false);
            tbNomTerrain.Focus();
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            if (dgvTerrain.SelectedRows.Count > 0)
            {
                tbIDTerrain.Text = dgvTerrain.SelectedRows[0].Cells["cIDTerrain"].Value.ToString();
                C_T_Terrain pTmp = new G_T_Terrain(sConnexion).Lire_ID(int.Parse(tbIDTerrain.Text));
                tbNomTerrain.Text = pTmp.Nom;
                tbTypeTerrain.Text = pTmp.TypeTerrain;
                MessageBox.Show(pTmp.Nom );
                Activer2(false);
            }
            else
            {
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvTerrain.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer l'enregistrement ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int iID = (int)dgvTerrain.SelectedRows[0].Cells["cIDTerrain"].Value;
                    new G_T_Terrain(sConnexion).Supprimer(iID);
                    bsTerrain.RemoveCurrent();
                    MessageBox.Show("Terrain supprimer", "SUPPRIMER", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            bool idTerrain = Int32.TryParse(tbIDTerrain.Text, out number);

            if (tbNomTerrain.Text.Trim() == "")
            {
                MessageBox.Show("Renseigner le nom du terrain");
            }
            else
            {
                if (tbIDTerrain.Text == "")
                //Ajout
                {
                    int iID = new G_T_Terrain(sConnexion).Ajouter(tbNomTerrain.Text,tbTypeTerrain.Text);
                    tbIDTerrain.Text = iID.ToString();
                    dtTerrain.Rows.Add(iID, tbNomTerrain.Text, tbTypeTerrain.Text);
                    MessageBox.Show("Terrain ajouter", "AJOUTER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                //Modification
                {
                    new G_T_Terrain(sConnexion).Modifier(int.Parse(tbIDTerrain.Text), tbNomTerrain.Text, tbTypeTerrain.Text);
                    dgvTerrain.SelectedRows[0].Cells["cIDTerrain"].Value = tbIDTerrain.Text;
                    dgvTerrain.SelectedRows[0].Cells["cNom"].Value = tbNomTerrain.Text;
                    dgvTerrain.SelectedRows[0].Cells["cTypeTerrain"].Value = tbTypeTerrain.Text;
                    bsTerrain.EndEdit();
                    MessageBox.Show("Terrain modifier", "MODIFIER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                tbIDTerrain.Clear();
                tbNomTerrain.Clear();
                tbTypeTerrain.Clear();
                Activer(true);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }
        #endregion

        // Bouton pour generer le fichier texte qui contient les info
        private void bSauvegarder_Click(object sender, EventArgs e)
        {

            File.Create("Terrain.txt").Close();
            using (StreamWriter sw = File.AppendText("Terrain.txt"))
            {
                // TERRAIN
                // Recuprere les ID du terrain
                List<C_T_Terrain> lTmp = new G_T_Terrain(sConnexion).Lire("ID_Terrain");

                foreach (C_T_Terrain p in lTmp)
                {
                    // Ecrit dans le fichier le veritable nom du terrain
                    sw.WriteLine("Nom terrain : "+ p.Nom);

                    // MATCH
                    List<C_T_Match> lTmpMatch = new G_T_Match(sConnexion).Lire("ID_Match");
                    foreach (C_T_Match m in lTmpMatch)
                    {
                        //Recupere les id des equipe domicile et adversaire et les changes avec leurs noms
                        if (m.ID_Terrain== p.ID_Terrain)
                        {
                            C_T_Equipe lEquipe = new G_T_Equipe(sConnexion).Lire_ID(m.ID_Domicile);
                            C_T_Equipe lEquipe2 = new G_T_Equipe(sConnexion).Lire_ID(m.ID_Deplacement);
                            sw.WriteLine("Match");
                            sw.WriteLine("Nom equipe domicile :  " + lEquipe.Nom);
                            sw.WriteLine("Nom equipe deplacement :  " + lEquipe2.Nom);
                            sw.WriteLine(" ");
                        }
                    }
                    //Entrainement
                    List <C_T_Entrainement> lTmpEntrainement = new G_T_Entrainement(sConnexion).Lire("ID_Entrainement");
                    foreach (C_T_Entrainement m in lTmpEntrainement)
                    {
                        if (m.ID_Terrain == p.ID_Terrain)
                        {
                            C_T_Equipe lEquipe2 = new G_T_Equipe(sConnexion).Lire_ID(Convert.ToInt32(m.ID_Equipe));
                            sw.WriteLine("Entrainement ");
                            sw.WriteLine("Nom equipe :  " + lEquipe2.Nom);
                            sw.WriteLine(" ");
                        }
                    }
                }

                List<C_T_Match> lTmp2 = new G_T_Match(sConnexion).Lire("ID_Match");
                foreach (C_T_Match p in lTmp2)
                {
                    List<C_T_Match> lTmpEquipe = new G_T_Match(sConnexion).Lire("ID_Match");
                }

            }


        }
    }
}
