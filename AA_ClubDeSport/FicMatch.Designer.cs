
namespace AA_ClubDeSport
{
    partial class EcranMatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranMatch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEditer = new System.Windows.Forms.Button();
            this.dgvMatch = new System.Windows.Forms.DataGridView();
            this.cIDMatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDomicile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cScoreDomicile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDAdversaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cScoreAdversaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDTerrain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lScoreDomicile = new System.Windows.Forms.Label();
            this.lScoreAdversaire = new System.Windows.Forms.Label();
            this.lDateDuMatch = new System.Windows.Forms.Label();
            this.dtpMatch = new System.Windows.Forms.DateTimePicker();
            this.lMatch = new System.Windows.Forms.Label();
            this.tbIDMatch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lIDDomicile = new System.Windows.Forms.Label();
            this.lIDAdversaire = new System.Windows.Forms.Label();
            this.lIDTerrain = new System.Windows.Forms.Label();
            this.tbIDTerrain = new System.Windows.Forms.TextBox();
            this.tbScoreAdversaire = new System.Windows.Forms.TextBox();
            this.tbIDAdversaire = new System.Windows.Forms.TextBox();
            this.tbIDDomicile = new System.Windows.Forms.TextBox();
            this.tbScoreDomicile = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(237, 547);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(37, 4);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(154, 152);
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
            this.label1.Location = new System.Drawing.Point(1, 160);
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
            // dgvMatch
            // 
            this.dgvMatch.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dgvMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDMatch,
            this.cIDDomicile,
            this.cScoreDomicile,
            this.cIDAdversaire,
            this.cScoreAdversaire,
            this.cDate,
            this.cIDTerrain});
            this.dgvMatch.Location = new System.Drawing.Point(243, 62);
            this.dgvMatch.Name = "dgvMatch";
            this.dgvMatch.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatch.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMatch.RowHeadersWidth = 51;
            this.dgvMatch.RowTemplate.Height = 24;
            this.dgvMatch.Size = new System.Drawing.Size(855, 302);
            this.dgvMatch.TabIndex = 13;
            // 
            // cIDMatch
            // 
            this.cIDMatch.DataPropertyName = "ID_Match";
            this.cIDMatch.HeaderText = "ID Match";
            this.cIDMatch.MinimumWidth = 6;
            this.cIDMatch.Name = "cIDMatch";
            this.cIDMatch.ReadOnly = true;
            this.cIDMatch.Width = 75;
            // 
            // cIDDomicile
            // 
            this.cIDDomicile.DataPropertyName = "ID_Domicile";
            this.cIDDomicile.HeaderText = "ID Domicile";
            this.cIDDomicile.MinimumWidth = 6;
            this.cIDDomicile.Name = "cIDDomicile";
            this.cIDDomicile.ReadOnly = true;
            this.cIDDomicile.Width = 80;
            // 
            // cScoreDomicile
            // 
            this.cScoreDomicile.DataPropertyName = "Score_Domicile";
            this.cScoreDomicile.HeaderText = "Score Domicile";
            this.cScoreDomicile.MinimumWidth = 2;
            this.cScoreDomicile.Name = "cScoreDomicile";
            this.cScoreDomicile.ReadOnly = true;
            this.cScoreDomicile.Width = 70;
            // 
            // cIDAdversaire
            // 
            this.cIDAdversaire.DataPropertyName = "ID_Adversaire";
            this.cIDAdversaire.HeaderText = "ID Adversaire";
            this.cIDAdversaire.MinimumWidth = 6;
            this.cIDAdversaire.Name = "cIDAdversaire";
            this.cIDAdversaire.ReadOnly = true;
            this.cIDAdversaire.Width = 80;
            // 
            // cScoreAdversaire
            // 
            this.cScoreAdversaire.DataPropertyName = "Score_Adversaire";
            this.cScoreAdversaire.HeaderText = "Score Adversaire";
            this.cScoreAdversaire.MinimumWidth = 6;
            this.cScoreAdversaire.Name = "cScoreAdversaire";
            this.cScoreAdversaire.ReadOnly = true;
            this.cScoreAdversaire.Width = 70;
            // 
            // cDate
            // 
            this.cDate.DataPropertyName = "Date";
            this.cDate.HeaderText = "Date";
            this.cDate.MinimumWidth = 6;
            this.cDate.Name = "cDate";
            this.cDate.ReadOnly = true;
            this.cDate.Width = 125;
            // 
            // cIDTerrain
            // 
            this.cIDTerrain.DataPropertyName = "ID_Terrain";
            this.cIDTerrain.HeaderText = "ID Terrain";
            this.cIDTerrain.MinimumWidth = 6;
            this.cIDTerrain.Name = "cIDTerrain";
            this.cIDTerrain.ReadOnly = true;
            this.cIDTerrain.Width = 70;
            // 
            // lScoreDomicile
            // 
            this.lScoreDomicile.AutoSize = true;
            this.lScoreDomicile.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScoreDomicile.Location = new System.Drawing.Point(365, 439);
            this.lScoreDomicile.Name = "lScoreDomicile";
            this.lScoreDomicile.Size = new System.Drawing.Size(194, 21);
            this.lScoreDomicile.TabIndex = 14;
            this.lScoreDomicile.Text = "Score equipe domicile";
            // 
            // lScoreAdversaire
            // 
            this.lScoreAdversaire.AutoSize = true;
            this.lScoreAdversaire.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScoreAdversaire.Location = new System.Drawing.Point(883, 439);
            this.lScoreAdversaire.Name = "lScoreAdversaire";
            this.lScoreAdversaire.Size = new System.Drawing.Size(214, 21);
            this.lScoreAdversaire.TabIndex = 15;
            this.lScoreAdversaire.Text = "Score equipe adversaire";
            // 
            // lDateDuMatch
            // 
            this.lDateDuMatch.AutoSize = true;
            this.lDateDuMatch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateDuMatch.Location = new System.Drawing.Point(637, 378);
            this.lDateDuMatch.Name = "lDateDuMatch";
            this.lDateDuMatch.Size = new System.Drawing.Size(140, 21);
            this.lDateDuMatch.TabIndex = 16;
            this.lDateDuMatch.Text = "Date du match";
            // 
            // dtpMatch
            // 
            this.dtpMatch.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpMatch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMatch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMatch.Location = new System.Drawing.Point(613, 428);
            this.dtpMatch.Name = "dtpMatch";
            this.dtpMatch.Size = new System.Drawing.Size(209, 28);
            this.dtpMatch.TabIndex = 19;
            // 
            // lMatch
            // 
            this.lMatch.AutoSize = true;
            this.lMatch.BackColor = System.Drawing.Color.SeaGreen;
            this.lMatch.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lMatch.Location = new System.Drawing.Point(617, 19);
            this.lMatch.Name = "lMatch";
            this.lMatch.Size = new System.Drawing.Size(122, 40);
            this.lMatch.TabIndex = 21;
            this.lMatch.Text = "Match";
            // 
            // tbIDMatch
            // 
            this.tbIDMatch.Location = new System.Drawing.Point(247, 402);
            this.tbIDMatch.Name = "tbIDMatch";
            this.tbIDMatch.Size = new System.Drawing.Size(90, 22);
            this.tbIDMatch.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "ID Match";
            // 
            // lIDDomicile
            // 
            this.lIDDomicile.AutoSize = true;
            this.lIDDomicile.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIDDomicile.Location = new System.Drawing.Point(403, 378);
            this.lIDDomicile.Name = "lIDDomicile";
            this.lIDDomicile.Size = new System.Drawing.Size(103, 21);
            this.lIDDomicile.TabIndex = 29;
            this.lIDDomicile.Text = "ID Domicile";
            // 
            // lIDAdversaire
            // 
            this.lIDAdversaire.AutoSize = true;
            this.lIDAdversaire.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIDAdversaire.Location = new System.Drawing.Point(937, 378);
            this.lIDAdversaire.Name = "lIDAdversaire";
            this.lIDAdversaire.Size = new System.Drawing.Size(123, 21);
            this.lIDAdversaire.TabIndex = 31;
            this.lIDAdversaire.Text = "ID Adversaire";
            // 
            // lIDTerrain
            // 
            this.lIDTerrain.AutoSize = true;
            this.lIDTerrain.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIDTerrain.Location = new System.Drawing.Point(247, 452);
            this.lIDTerrain.Name = "lIDTerrain";
            this.lIDTerrain.Size = new System.Drawing.Size(87, 21);
            this.lIDTerrain.TabIndex = 33;
            this.lIDTerrain.Text = "ID Terrain";
            // 
            // tbIDTerrain
            // 
            this.tbIDTerrain.Location = new System.Drawing.Point(247, 476);
            this.tbIDTerrain.Name = "tbIDTerrain";
            this.tbIDTerrain.Size = new System.Drawing.Size(90, 22);
            this.tbIDTerrain.TabIndex = 32;
            // 
            // tbScoreAdversaire
            // 
            this.tbScoreAdversaire.Location = new System.Drawing.Point(937, 476);
            this.tbScoreAdversaire.Name = "tbScoreAdversaire";
            this.tbScoreAdversaire.Size = new System.Drawing.Size(123, 22);
            this.tbScoreAdversaire.TabIndex = 35;
            // 
            // tbIDAdversaire
            // 
            this.tbIDAdversaire.Location = new System.Drawing.Point(941, 402);
            this.tbIDAdversaire.Name = "tbIDAdversaire";
            this.tbIDAdversaire.Size = new System.Drawing.Size(123, 22);
            this.tbIDAdversaire.TabIndex = 30;
            // 
            // tbIDDomicile
            // 
            this.tbIDDomicile.Location = new System.Drawing.Point(407, 402);
            this.tbIDDomicile.Name = "tbIDDomicile";
            this.tbIDDomicile.Size = new System.Drawing.Size(100, 22);
            this.tbIDDomicile.TabIndex = 28;
            // 
            // tbScoreDomicile
            // 
            this.tbScoreDomicile.Location = new System.Drawing.Point(407, 476);
            this.tbScoreDomicile.Name = "tbScoreDomicile";
            this.tbScoreDomicile.Size = new System.Drawing.Size(90, 22);
            this.tbScoreDomicile.TabIndex = 34;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox3.Location = new System.Drawing.Point(230, 536);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(887, 11);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox2.Location = new System.Drawing.Point(1104, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(13, 547);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(198, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(919, 11);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // EcranMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1115, 547);
            this.Controls.Add(this.tbScoreAdversaire);
            this.Controls.Add(this.tbScoreDomicile);
            this.Controls.Add(this.lIDTerrain);
            this.Controls.Add(this.tbIDTerrain);
            this.Controls.Add(this.lIDAdversaire);
            this.Controls.Add(this.tbIDAdversaire);
            this.Controls.Add(this.lIDDomicile);
            this.Controls.Add(this.tbIDDomicile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIDMatch);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lMatch);
            this.Controls.Add(this.dtpMatch);
            this.Controls.Add(this.lDateDuMatch);
            this.Controls.Add(this.lScoreAdversaire);
            this.Controls.Add(this.lScoreDomicile);
            this.Controls.Add(this.dgvMatch);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Match";
            this.Load += new System.EventHandler(this.EcranMatch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvMatch;
        private System.Windows.Forms.Label lScoreDomicile;
        private System.Windows.Forms.Label lScoreAdversaire;
        private System.Windows.Forms.Label lDateDuMatch;
        private System.Windows.Forms.DateTimePicker dtpMatch;
        private System.Windows.Forms.Label lMatch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tbIDMatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lIDDomicile;
        private System.Windows.Forms.Label lIDAdversaire;
        private System.Windows.Forms.Label lIDTerrain;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDomicile;
        private System.Windows.Forms.DataGridViewTextBoxColumn cScoreDomicile;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDAdversaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn cScoreAdversaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDTerrain;
        private System.Windows.Forms.TextBox tbIDTerrain;
        private System.Windows.Forms.TextBox tbScoreAdversaire;
        private System.Windows.Forms.TextBox tbIDAdversaire;
        private System.Windows.Forms.TextBox tbIDDomicile;
        private System.Windows.Forms.TextBox tbScoreDomicile;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}