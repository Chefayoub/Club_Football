
namespace AA_ClubDeSport
{
    partial class EcranTerrain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranTerrain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEditer = new System.Windows.Forms.Button();
            this.lTerrain = new System.Windows.Forms.Label();
            this.dgvTerrain = new System.Windows.Forms.DataGridView();
            this.cIDTerrain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTypeTerrain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNomTerrain = new System.Windows.Forms.Label();
            this.tbNomTerrain = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lIDTerrain = new System.Windows.Forms.Label();
            this.tbIDTerrain = new System.Windows.Forms.TextBox();
            this.tbTypeTerrain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bSauvegarder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.bSauvegarder);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAnnuler);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.btnConfirmer);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.btnEditer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 535);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(46, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 141);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Football Club Manager";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Honeydew;
            this.btnAnnuler.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnnuler.Location = new System.Drawing.Point(12, 479);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(212, 45);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Honeydew;
            this.btnSupprimer.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSupprimer.Location = new System.Drawing.Point(43, 292);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(144, 45);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.BackColor = System.Drawing.Color.Honeydew;
            this.btnConfirmer.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmer.Location = new System.Drawing.Point(12, 428);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(212, 45);
            this.btnConfirmer.TabIndex = 3;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = false;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Honeydew;
            this.btnAjouter.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAjouter.Location = new System.Drawing.Point(43, 190);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(144, 45);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.BackColor = System.Drawing.Color.Honeydew;
            this.btnEditer.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditer.Location = new System.Drawing.Point(43, 241);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(144, 45);
            this.btnEditer.TabIndex = 5;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = false;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // lTerrain
            // 
            this.lTerrain.AutoSize = true;
            this.lTerrain.BackColor = System.Drawing.Color.SeaGreen;
            this.lTerrain.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTerrain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lTerrain.Location = new System.Drawing.Point(376, 19);
            this.lTerrain.Name = "lTerrain";
            this.lTerrain.Size = new System.Drawing.Size(125, 40);
            this.lTerrain.TabIndex = 26;
            this.lTerrain.Text = "Terrain";
            // 
            // dgvTerrain
            // 
            this.dgvTerrain.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dgvTerrain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTerrain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDTerrain,
            this.cNom,
            this.cTypeTerrain});
            this.dgvTerrain.Location = new System.Drawing.Point(255, 62);
            this.dgvTerrain.Name = "dgvTerrain";
            this.dgvTerrain.ReadOnly = true;
            this.dgvTerrain.RowHeadersWidth = 51;
            this.dgvTerrain.RowTemplate.Height = 24;
            this.dgvTerrain.Size = new System.Drawing.Size(413, 302);
            this.dgvTerrain.TabIndex = 25;
            // 
            // cIDTerrain
            // 
            this.cIDTerrain.DataPropertyName = "ID_Terrain";
            this.cIDTerrain.HeaderText = "ID Terrain";
            this.cIDTerrain.MinimumWidth = 6;
            this.cIDTerrain.Name = "cIDTerrain";
            this.cIDTerrain.ReadOnly = true;
            this.cIDTerrain.Width = 60;
            // 
            // cNom
            // 
            this.cNom.DataPropertyName = "Nom";
            this.cNom.HeaderText = "Nom";
            this.cNom.MinimumWidth = 6;
            this.cNom.Name = "cNom";
            this.cNom.ReadOnly = true;
            this.cNom.Width = 173;
            // 
            // cTypeTerrain
            // 
            this.cTypeTerrain.DataPropertyName = "TypeTerrain";
            this.cTypeTerrain.HeaderText = "TypeTerrain";
            this.cTypeTerrain.MinimumWidth = 6;
            this.cTypeTerrain.Name = "cTypeTerrain";
            this.cTypeTerrain.ReadOnly = true;
            this.cTypeTerrain.Width = 125;
            // 
            // lNomTerrain
            // 
            this.lNomTerrain.AutoSize = true;
            this.lNomTerrain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNomTerrain.Location = new System.Drawing.Point(449, 385);
            this.lNomTerrain.Name = "lNomTerrain";
            this.lNomTerrain.Size = new System.Drawing.Size(156, 23);
            this.lNomTerrain.TabIndex = 30;
            this.lNomTerrain.Text = "Nom du terrain";
            // 
            // tbNomTerrain
            // 
            this.tbNomTerrain.BackColor = System.Drawing.SystemColors.Menu;
            this.tbNomTerrain.Location = new System.Drawing.Point(453, 428);
            this.tbNomTerrain.Name = "tbNomTerrain";
            this.tbNomTerrain.Size = new System.Drawing.Size(152, 22);
            this.tbNomTerrain.TabIndex = 31;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox3.Location = new System.Drawing.Point(227, 524);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(454, 10);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox2.Location = new System.Drawing.Point(674, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(13, 535);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(195, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 11);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lIDTerrain
            // 
            this.lIDTerrain.AutoSize = true;
            this.lIDTerrain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIDTerrain.Location = new System.Drawing.Point(236, 385);
            this.lIDTerrain.Name = "lIDTerrain";
            this.lIDTerrain.Size = new System.Drawing.Size(98, 23);
            this.lIDTerrain.TabIndex = 32;
            this.lIDTerrain.Text = "ID Terrain";
            // 
            // tbIDTerrain
            // 
            this.tbIDTerrain.BackColor = System.Drawing.SystemColors.Menu;
            this.tbIDTerrain.Location = new System.Drawing.Point(240, 428);
            this.tbIDTerrain.Name = "tbIDTerrain";
            this.tbIDTerrain.Size = new System.Drawing.Size(152, 22);
            this.tbIDTerrain.TabIndex = 33;
            // 
            // tbTypeTerrain
            // 
            this.tbTypeTerrain.BackColor = System.Drawing.SystemColors.Menu;
            this.tbTypeTerrain.Location = new System.Drawing.Point(340, 496);
            this.tbTypeTerrain.Name = "tbTypeTerrain";
            this.tbTypeTerrain.Size = new System.Drawing.Size(152, 22);
            this.tbTypeTerrain.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Type terrain";
            // 
            // bSauvegarder
            // 
            this.bSauvegarder.BackColor = System.Drawing.Color.Yellow;
            this.bSauvegarder.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSauvegarder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSauvegarder.Location = new System.Drawing.Point(43, 349);
            this.bSauvegarder.Name = "bSauvegarder";
            this.bSauvegarder.Size = new System.Drawing.Size(141, 59);
            this.bSauvegarder.TabIndex = 16;
            this.bSauvegarder.Text = "Generer fichier texte";
            this.bSauvegarder.UseVisualStyleBackColor = false;
            this.bSauvegarder.Click += new System.EventHandler(this.bSauvegarder_Click);
            // 
            // EcranTerrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 535);
            this.Controls.Add(this.tbTypeTerrain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIDTerrain);
            this.Controls.Add(this.lIDTerrain);
            this.Controls.Add(this.tbNomTerrain);
            this.Controls.Add(this.lNomTerrain);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lTerrain);
            this.Controls.Add(this.dgvTerrain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EcranTerrain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terrain";
            this.Load += new System.EventHandler(this.EcranTerrain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEditer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lTerrain;
        private System.Windows.Forms.DataGridView dgvTerrain;
        private System.Windows.Forms.Label lNomTerrain;
        private System.Windows.Forms.TextBox tbNomTerrain;
        private System.Windows.Forms.Label lIDTerrain;
        private System.Windows.Forms.TextBox tbIDTerrain;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tbTypeTerrain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDTerrain;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTypeTerrain;
        private System.Windows.Forms.Button bSauvegarder;
    }
}