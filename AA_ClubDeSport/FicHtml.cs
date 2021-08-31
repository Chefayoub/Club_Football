using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class EcranHtml : Form
    {
        public EcranHtml(string path)
        {
            InitializeComponent();
            var uri = new Uri(path); //Produit une url à l'aide du fichier
            //this.Text = Path.GetFileName(path); //Affiche le nom du fichier sur la fenêtre
            wbHtml.Navigate(uri); //Lecteur de page web  
        }
    }
}
