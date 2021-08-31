using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Projet_BD_ClubDeSport.Classes;
using Projet_BD_ClubDeSport.Gestion;
using System.Threading;
using System.IO;

namespace AA_ClubDeSport
{
    public partial class EcranAccueil : Form
    {
        string sConnexionEquipe, sConnexionMatch, sConnexionEntrainement, sConnexionTerrain;
        private DataTable dtEquipe, dtMatch, dtEntrainement, dtTerrain;
        private BindingSource bsEquipe, bsMatch, bsEntrainement, bsTerrain;


        public EcranAccueil()
        {
            InitializeComponent();
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            RemplirDGV();
        }



        #region Butons
        private void btnEquipe_Click(object sender, EventArgs e)
        {
            Hide(); // Cache ecran accueil
            EcranEquipe f = new EcranEquipe(); // Affiche l'ecran Equipe
            f.ShowDialog();
            Show(); // Femer = affiche Accueil
        }



        private void btnMatch_Click(object sender, EventArgs e)
        {
            Hide(); 
            EcranMatch f = new EcranMatch(); 
            f.ShowDialog();
            Show();
        }



        private void btnEntrainement_Click(object sender, EventArgs e)
        {
            Hide();
            EcranEntrainement f = new EcranEntrainement();
            f.ShowDialog();
            Show();
        }



        private void btnTerrain_Click(object sender, EventArgs e)
        {
            Hide();
            EcranTerrain f = new EcranTerrain();
            f.ShowDialog();
            Show();
        }

        private void bClub_Click(object sender, EventArgs e)
        {
            Hide();
            EcranClub f = new EcranClub();
            f.ShowDialog();
            Show();
        }

        #endregion


        private void EcranAccueil_Load(object sender, EventArgs e)
        {
            sConnexionEquipe = ConfigurationManager.ConnectionStrings["AA_ClubDeSport.Properties.Settings.BDConnectionString_Couches"].ConnectionString;
            sConnexionMatch = ConfigurationManager.ConnectionStrings["AA_ClubDeSport.Properties.Settings.BDConnectionString_Couches"].ConnectionString;
            sConnexionEntrainement = ConfigurationManager.ConnectionStrings["AA_ClubDeSport.Properties.Settings.BDConnectionString_Couches"].ConnectionString;
            sConnexionTerrain = ConfigurationManager.ConnectionStrings["AA_ClubDeSport.Properties.Settings.BDConnectionString_Couches"].ConnectionString;
            RemplirDGV();

        }

        #region Remplir les DGV
        private void RemplirDGV() 
        {
            //Equipe
            dtEquipe = new DataTable();
            dtEquipe.Columns.Add(new DataColumn("ID_Equipe", System.Type.GetType("System.Int32")));
            dtEquipe.Columns.Add(new DataColumn("ID_Club", System.Type.GetType("System.Int32")));
            dtEquipe.Columns.Add(new DataColumn("Nom"));

            List<C_T_Equipe> lTmp = new G_T_Equipe(sConnexionEquipe).Lire("ID_Equipe");
            foreach (C_T_Equipe p in lTmp)
            {
                dtEquipe.Rows.Add(p.ID_Equipe, p.ID_Club, p.Nom);
            }
            bsEquipe = new BindingSource();
            bsEquipe.DataSource = dtEquipe;
            dgvEquipe.DataSource = bsEquipe;


            //Match
            dtMatch = new DataTable();
            dtMatch.Columns.Add(new DataColumn("ID_Match", System.Type.GetType("System.Int32")));
            dtMatch.Columns.Add(new DataColumn("ID_Domicile", System.Type.GetType("System.Int32")));
            dtMatch.Columns.Add(new DataColumn("Score_Domicile", System.Type.GetType("System.Int32")));
            dtMatch.Columns.Add(new DataColumn("ID_Adversaire", System.Type.GetType("System.Int32")));
            dtMatch.Columns.Add(new DataColumn("Score_Adversaire", System.Type.GetType("System.Int32")));
            dtMatch.Columns.Add(new DataColumn("Date"));
            dtMatch.Columns.Add(new DataColumn("ID_Terrain", System.Type.GetType("System.Int32")));


            List<C_T_Match> lTmp1 = new G_T_Match(sConnexionMatch).Lire("ID_Match");
            foreach (C_T_Match p in lTmp1)
            {
                dtMatch.Rows.Add(p.ID_Match, p.ID_Domicile, p.Score_Domicile, p.ID_Deplacement, p.Score_Adversaire, p.Date.ToString("g"), p.ID_Terrain);
            }
            bsMatch = new BindingSource();
            bsMatch.DataSource = dtMatch;
            dgvMatch.DataSource = bsMatch;

            //Entrainement
            dtEntrainement = new DataTable();
            dtEntrainement.Columns.Add(new DataColumn("ID_Entrainement", System.Type.GetType("System.Int32")));
            dtEntrainement.Columns.Add(new DataColumn("ID_Equipe", System.Type.GetType("System.Int32")));
            dtEntrainement.Columns.Add(new DataColumn("Date"));
            dtEntrainement.Columns.Add(new DataColumn("ID_Terrain", System.Type.GetType("System.Int32")));

            List<C_T_Entrainement> lTmp2 = new G_T_Entrainement(sConnexionEntrainement).Lire("ID_Entrainement");
            foreach (C_T_Entrainement p in lTmp2)
            {
                dtEntrainement.Rows.Add(p.ID_Entrainement, p.ID_Equipe, p.Date.ToString("g"), p.ID_Terrain);
            }
            bsEntrainement = new BindingSource();
            bsEntrainement.DataSource = dtEntrainement;
            dgvEntrainement.DataSource = bsEntrainement;

            //Terrain
            dtTerrain = new DataTable();
            dtTerrain.Columns.Add(new DataColumn("ID_Terrain", System.Type.GetType("System.Int32")));
            dtTerrain.Columns.Add(new DataColumn("Nom"));
            dtTerrain.Columns.Add(new DataColumn("TypeTerrain"));

            List<C_T_Terrain> lTmp3 = new G_T_Terrain(sConnexionTerrain).Lire("ID_Terrain");
            foreach (C_T_Terrain p in lTmp3)
            {
                dtTerrain.Rows.Add(p.ID_Terrain, p.Nom, p.TypeTerrain);
            }
            bsTerrain = new BindingSource();
            bsTerrain.DataSource = dtTerrain;
            dgvTerrain.DataSource = bsTerrain;



            //Match html
            dtMatch = new DataTable();
            dtMatch.Columns.Add(new DataColumn("ID_MatchHtml", System.Type.GetType("System.Int32")));
            dtMatch.Columns.Add(new DataColumn("ID_DomicileHtml", System.Type.GetType("System.Int32")));
            dtMatch.Columns.Add(new DataColumn { ColumnName = "Score_DomicileHtml", DataType = System.Type.GetType("System.Int32"), AllowDBNull = true });
            dtMatch.Columns[2].AllowDBNull = true;
            dtMatch.Columns.Add(new DataColumn("ID_AdversaireHtml", System.Type.GetType("System.Int32")));
            dtMatch.Columns.Add(new DataColumn { ColumnName = "Score_AdversaireHtml", DataType = System.Type.GetType("System.Int32"), AllowDBNull = true });
            dtMatch.Columns[4].AllowDBNull = true;
            dtMatch.Columns.Add(new DataColumn("DateHtml"));
            dtMatch.Columns.Add(new DataColumn("ID_TerrainHtml", System.Type.GetType("System.Int32")));

            List<C_T_Match> lTmp4 = new G_T_Match(sConnexionMatch).Lire("ID_MatchHtml");
            foreach (C_T_Match p in lTmp4)
            {
                dtMatch.Rows.Add(p.ID_Match, p.ID_Domicile, p.Score_Domicile, p.ID_Deplacement, p.Score_Adversaire, p.Date.ToString("g"), p.ID_Terrain);
            }
            bsMatch = new BindingSource();
            bsMatch.DataSource = dtMatch;
            dgvHTML.DataSource = bsMatch;

        }
        #endregion


        #region HTML
        private void tsbSauvegarderHtml_Click(object sender, EventArgs e)
        {
            dtMatch = new DataTable();

            string[] aNom = { "ID Match", "ID Domicile", "Score Domicile", "ID Adversaire", "Score Adversaire", "Date", "ID Terrain" };

            //Debut table
            string html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>";

            html += "<h1 style='text-align:center ; background - color: #65C509; font-family:arial; '>Football Club Managers</h1>";

            html += "<h1 style='text-align:center ; background - color: #65C509; font-family:arial; '>Match</h1>";

            //Ajout colonnes
            html += "<tr>";
            foreach (string s in aNom)
            {
                html += "<th style='background-color: green ;border: 1px solid white'>" + s + "</th>";
            }
            html += "</tr>";


            //Ajout lignes
            List<C_T_Match> lTmp4 = new G_T_Match(sConnexionMatch).Lire("DateHtml");
            foreach (C_T_Match p in lTmp4)
                if (p.Score_Domicile == null && p.Score_Domicile == null)
                {
                    html += "<tr>";
                    if ((p.Date - DateTime.Now).TotalDays <= 7 && (p.Date - DateTime.Now).TotalDays >= 0) 
                    {
                        html += "<td style='width:120px;border: 1px solid #ccc'>" + p.ID_Match.ToString() + "</td>";
                        html += "<td style='width:120px;border: 1px solid #ccc'>" + p.ID_Domicile.ToString() + "</td>";
                        if (p.Score_Domicile == null)
                            html += "<td style='width:120px;border: 1px solid #ccc'>-</td>";
                        else
                            html += "<td style='width:120px;border: 1px solid #ccc'>" + p.Score_Domicile.Value.ToString() + "</td>";
                            html += "<td style='width:120px;border: 1px solid #ccc'>" + p.ID_Deplacement.ToString() + "</td>";
                        if (p.Score_Domicile == null)
                            html += "<td style='width:120px;border: 1px solid #ccc'>-</td>";
                        else
                            html += "<td style='width:120px;border: 1px solid #ccc'>" + p.Score_Adversaire.Value.ToString() + "</td>";


                        html += "<td style='width:120px;border: 1px solid #ccc'>" + p.Date.ToString() + "</td>";
                        html += "<td style='width:120px;border: 1px solid #ccc'>" + p.ID_Terrain.ToString() + "</td>";
                    }

                    html += "</tr>";
                }


            //Fin table
            html += "</table>";

            string file = "Match.htm";

            string path = Path.GetFullPath(file); //Chemin complet

            File.WriteAllText(path, html); //Ecriture du fichier

            MessageBox.Show("Chemin du fichier : " + path, "Sauvegarde du fichier HTML"); //Affichage

            RemplirDGV(); //Retour à la normal pour la grid utilisée
        }
        private void tsbOuvrirHtml_Click(object sender, EventArgs e)
        {
            string file = "Match.htm";

            string path = Path.GetFullPath(file);

            EcranHtml f = new EcranHtml(path);

            f.ShowDialog();
        }
        #endregion


        #region Filtre
        private void tstbNom_TextChanged(object sender, EventArgs e)
        {
            //Les filtres sont diviser en trois sections : Equipe, Match et Terrain
            //Pour chaque on va travailler sur un dgv précis pour trouver les infos plus rapidement
            if (tscbNom.Text == "Equipe") 
            {
                DataView DVE = new DataView(dtEquipe);
                DVE.RowFilter = string.Format("Nom LIKE '%{0}%'", tstbNom.Text); 
                dgvEquipe.DataSource = DVE;
            }
            else if (tscbNom.Text == "Terrain")
            {
                DataView DVT = new DataView(dtTerrain);
                DVT.RowFilter = string.Format("Nom LIKE '%{0}%'", tstbNom.Text);
                dgvTerrain.DataSource = DVT;
            }
            else
            {
                MessageBox.Show("Erreur veuiller selectionner equipe ou terrain !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void tscbNom_DropDownClosed(object sender, EventArgs e)
        {
            RemplirDGV();
            tstbNom.Text = "";
        }


        private void tstbID_TextChanged(object sender, EventArgs e)
        {
            int parsedValue; //Variable int de test

            if (int.TryParse(tstbID.Text, out parsedValue)) //Si la textbox contient que des nombres
            {

                if (tscbID.Text == "Equipe")
                {
                    DataView DV_Equipe = new DataView(dtEquipe);

                    DV_Equipe.RowFilter = "ID_Equipe =" + Int32.Parse(tstbID.Text); //Filtrage selon int encoder

                    dgvEquipe.DataSource = DV_Equipe;
                }

                else if (tscbID.Text == "Match")
                {
                    DataView DV_Match = new DataView(dtMatch);

                    DV_Match.RowFilter = "ID_MatchHtml =" + Int32.Parse(tstbID.Text); //Filtrage selon int encoder

                    dgvMatch.DataSource = DV_Match;
                }
                else if (tscbID.Text == "Terrain")
                {
                    DataView DV_Terrain = new DataView(dtTerrain);

                    DV_Terrain.RowFilter = "ID_Terrain =" + Int32.Parse(tstbID.Text); //Filtrage selon int encoder

                    dgvTerrain.DataSource = DV_Terrain;
                }
                else if (tscbID.Text == "Entrainement")
                {
                    DataView DV_Entrainement = new DataView(dtEntrainement);

                    DV_Entrainement.RowFilter = "ID_Entrainement =" + Int32.Parse(tstbID.Text); //Filtrage selon int encoder

                    dgvEntrainement.DataSource = DV_Entrainement;
                }
                else
                {
                    MessageBox.Show("Erreur veuiller selectionner equipe, match, terrain ou entrainement !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            else //Si la textbox ne contient pas que des nombres, on reset le filtre
            {
                RemplirDGV();
            }
        }
        private void tscbID_DropDownClosed(object sender, EventArgs e)
        {
            RemplirDGV();
            tstbID.Text = "";
        }

        #endregion
    }
}
