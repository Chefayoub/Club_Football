
namespace AA_ClubDeSport
{
    partial class EcranEntrainement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranEntrainement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEditer = new System.Windows.Forms.Button();
            this.lEntrainement = new System.Windows.Forms.Label();
            this.dgvEntrainement = new System.Windows.Forms.DataGridView();
            this.cIDEntrainement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDEquipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDTerrain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpEntrainement = new System.Windows.Forms.DateTimePicker();
            this.lDTP = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lIDEntrainement = new System.Windows.Forms.Label();
            this.tbIDEntrainement = new System.Windows.Forms.TextBox();
            this.tbIDEquipe = new System.Windows.Forms.TextBox();
            this.lIDEquipe = new System.Windows.Forms.Label();
            this.tbIDTerrain = new System.Windows.Forms.TextBox();
            this.lIDterrain = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrainement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
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
            this.panel1.Size = new System.Drawing.Size(237, 561);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 157);
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
            this.btnSupprimer.Location = new System.Drawing.Point(46, 354);
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
            this.btnAjouter.Location = new System.Drawing.Point(46, 252);
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
            this.btnEditer.Location = new System.Drawing.Point(46, 303);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(144, 45);
            this.btnEditer.TabIndex = 5;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = false;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // lEntrainement
            // 
            this.lEntrainement.AutoSize = true;
            this.lEntrainement.BackColor = System.Drawing.Color.SeaGreen;
            this.lEntrainement.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEntrainement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lEntrainement.Location = new System.Drawing.Point(447, 14);
            this.lEntrainement.Name = "lEntrainement";
            this.lEntrainement.Size = new System.Drawing.Size(232, 40);
            this.lEntrainement.TabIndex = 26;
            this.lEntrainement.Text = "Entrainement";
            // 
            // dgvEntrainement
            // 
            this.dgvEntrainement.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dgvEntrainement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEntrainement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrainement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDEntrainement,
            this.cIDEquipe,
            this.cDate,
            this.cIDTerrain});
            this.dgvEntrainement.Location = new System.Drawing.Point(253, 71);
            this.dgvEntrainement.Name = "dgvEntrainement";
            this.dgvEntrainement.ReadOnly = true;
            this.dgvEntrainement.RowHeadersWidth = 51;
            this.dgvEntrainement.RowTemplate.Height = 24;
            this.dgvEntrainement.Size = new System.Drawing.Size(610, 302);
            this.dgvEntrainement.TabIndex = 25;
            // 
            // cIDEntrainement
            // 
            this.cIDEntrainement.DataPropertyName = "ID_Entrainement";
            this.cIDEntrainement.HeaderText = "ID Entrainement";
            this.cIDEntrainement.MinimumWidth = 6;
            this.cIDEntrainement.Name = "cIDEntrainement";
            this.cIDEntrainement.ReadOnly = true;
            this.cIDEntrainement.Width = 75;
            // 
            // cIDEquipe
            // 
            this.cIDEquipe.DataPropertyName = "ID_Equipe";
            this.cIDEquipe.HeaderText = "ID Equipe";
            this.cIDEquipe.MinimumWidth = 6;
            this.cIDEquipe.Name = "cIDEquipe";
            this.cIDEquipe.ReadOnly = true;
            this.cIDEquipe.Width = 75;
            // 
            // cDate
            // 
            this.cDate.DataPropertyName = "Date";
            this.cDate.HeaderText = "Date";
            this.cDate.MinimumWidth = 6;
            this.cDate.Name = "cDate";
            this.cDate.ReadOnly = true;
            this.cDate.Width = 180;
            // 
            // cIDTerrain
            // 
            this.cIDTerrain.DataPropertyName = "ID_Terrain";
            this.cIDTerrain.HeaderText = "ID Terrain";
            this.cIDTerrain.MinimumWidth = 6;
            this.cIDTerrain.Name = "cIDTerrain";
            this.cIDTerrain.ReadOnly = true;
            this.cIDTerrain.Width = 75;
            // 
            // dtpEntrainement
            // 
            this.dtpEntrainement.CalendarMonthBackground = System.Drawing.SystemColors.ActiveBorder;
            this.dtpEntrainement.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpEntrainement.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntrainement.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntrainement.Location = new System.Drawing.Point(611, 517);
            this.dtpEntrainement.Name = "dtpEntrainement";
            this.dtpEntrainement.Size = new System.Drawing.Size(211, 28);
            this.dtpEntrainement.TabIndex = 31;
            // 
            // lDTP
            // 
            this.lDTP.AutoSize = true;
            this.lDTP.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDTP.Location = new System.Drawing.Point(631, 479);
            this.lDTP.Name = "lDTP";
            this.lDTP.Size = new System.Drawing.Size(140, 21);
            this.lDTP.TabIndex = 30;
            this.lDTP.Text = "Date du match";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox3.Location = new System.Drawing.Point(228, 553);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(783, 11);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox2.Location = new System.Drawing.Point(879, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(13, 576);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(196, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(815, 11);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lIDEntrainement
            // 
            this.lIDEntrainement.AutoSize = true;
            this.lIDEntrainement.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIDEntrainement.Location = new System.Drawing.Point(289, 393);
            this.lIDEntrainement.Name = "lIDEntrainement";
            this.lIDEntrainement.Size = new System.Drawing.Size(143, 21);
            this.lIDEntrainement.TabIndex = 32;
            this.lIDEntrainement.Text = "ID Entrainement";
            // 
            // tbIDEntrainement
            // 
            this.tbIDEntrainement.Location = new System.Drawing.Point(293, 438);
            this.tbIDEntrainement.Name = "tbIDEntrainement";
            this.tbIDEntrainement.Size = new System.Drawing.Size(139, 22);
            this.tbIDEntrainement.TabIndex = 33;
            // 
            // tbIDEquipe
            // 
            this.tbIDEquipe.Location = new System.Drawing.Point(657, 438);
            this.tbIDEquipe.Name = "tbIDEquipe";
            this.tbIDEquipe.Size = new System.Drawing.Size(86, 22);
            this.tbIDEquipe.TabIndex = 35;
            // 
            // lIDEquipe
            // 
            this.lIDEquipe.AutoSize = true;
            this.lIDEquipe.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIDEquipe.Location = new System.Drawing.Point(653, 393);
            this.lIDEquipe.Name = "lIDEquipe";
            this.lIDEquipe.Size = new System.Drawing.Size(90, 21);
            this.lIDEquipe.TabIndex = 34;
            this.lIDEquipe.Text = "ID Equipe";
            // 
            // tbIDTerrain
            // 
            this.tbIDTerrain.Location = new System.Drawing.Point(293, 524);
            this.tbIDTerrain.Name = "tbIDTerrain";
            this.tbIDTerrain.Size = new System.Drawing.Size(86, 22);
            this.tbIDTerrain.TabIndex = 37;
            // 
            // lIDterrain
            // 
            this.lIDterrain.AutoSize = true;
            this.lIDterrain.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIDterrain.Location = new System.Drawing.Point(289, 479);
            this.lIDterrain.Name = "lIDterrain";
            this.lIDterrain.Size = new System.Drawing.Size(87, 21);
            this.lIDterrain.TabIndex = 36;
            this.lIDterrain.Text = "ID Terrain";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(30, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(170, 153);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // EcranEntrainement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 561);
            this.Controls.Add(this.tbIDTerrain);
            this.Controls.Add(this.lIDterrain);
            this.Controls.Add(this.tbIDEquipe);
            this.Controls.Add(this.lIDEquipe);
            this.Controls.Add(this.tbIDEntrainement);
            this.Controls.Add(this.lIDEntrainement);
            this.Controls.Add(this.dtpEntrainement);
            this.Controls.Add(this.lDTP);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lEntrainement);
            this.Controls.Add(this.dgvEntrainement);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranEntrainement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrainement";
            this.Load += new System.EventHandler(this.EcranEntrainement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrainement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.Label lEntrainement;
        private System.Windows.Forms.DataGridView dgvEntrainement;
        private System.Windows.Forms.DateTimePicker dtpEntrainement;
        private System.Windows.Forms.Label lDTP;
        private System.Windows.Forms.Label lIDEntrainement;
        private System.Windows.Forms.TextBox tbIDEntrainement;
        private System.Windows.Forms.TextBox tbIDEquipe;
        private System.Windows.Forms.Label lIDEquipe;
        private System.Windows.Forms.TextBox tbIDTerrain;
        private System.Windows.Forms.Label lIDterrain;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDEntrainement;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDEquipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDTerrain;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}