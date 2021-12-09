namespace ProCouture.Formulaires
{
    partial class FrmServeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServeur));
            this.rest = new System.Windows.Forms.GroupBox();
            this.restaurer = new iTalk.iTalk_RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.GroupBox();
            this.backup = new iTalk.iTalk_RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.PictureBox();
            this.update = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.AjoutPersonne = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radBackup = new System.Windows.Forms.RadioButton();
            this.radRestaurer = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bd = new System.Windows.Forms.ComboBox();
            this.rest.SuspendLayout();
            this.back.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AjoutPersonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rest
            // 
            this.rest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rest.BackColor = System.Drawing.Color.White;
            this.rest.Controls.Add(this.pictureBox1);
            this.rest.Controls.Add(this.restaurer);
            this.rest.Controls.Add(this.label6);
            this.rest.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rest.ForeColor = System.Drawing.Color.Black;
            this.rest.Location = new System.Drawing.Point(7, 191);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(377, 79);
            this.rest.TabIndex = 520;
            this.rest.TabStop = false;
            this.rest.Text = "Database Restore";
            // 
            // restaurer
            // 
            this.restaurer.AutoWordSelection = false;
            this.restaurer.BackColor = System.Drawing.Color.Transparent;
            this.restaurer.Font = new System.Drawing.Font("Tahoma", 10F);
            this.restaurer.ForeColor = System.Drawing.Color.DimGray;
            this.restaurer.Location = new System.Drawing.Point(42, 37);
            this.restaurer.Name = "restaurer";
            this.restaurer.ReadOnly = false;
            this.restaurer.Size = new System.Drawing.Size(260, 30);
            this.restaurer.TabIndex = 762;
            this.restaurer.WordWrap = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(45, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 523;
            this.label6.Text = "Backup Path :";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Controls.Add(this.AjoutPersonne);
            this.back.Controls.Add(this.backup);
            this.back.Controls.Add(this.label9);
            this.back.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(8, 111);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(377, 75);
            this.back.TabIndex = 519;
            this.back.TabStop = false;
            this.back.Text = "Data Base Backup";
            // 
            // backup
            // 
            this.backup.AutoWordSelection = false;
            this.backup.BackColor = System.Drawing.Color.Transparent;
            this.backup.Font = new System.Drawing.Font("Tahoma", 10F);
            this.backup.ForeColor = System.Drawing.Color.DimGray;
            this.backup.Location = new System.Drawing.Point(37, 38);
            this.backup.Name = "backup";
            this.backup.ReadOnly = false;
            this.backup.Size = new System.Drawing.Size(260, 30);
            this.backup.TabIndex = 762;
            this.backup.WordWrap = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(34, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 517;
            this.label9.Text = "Localisation :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(155)))), ((int)(((byte)(167)))));
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.pictureBox8);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(44)))), ((int)(((byte)(76)))));
            this.panel4.Location = new System.Drawing.Point(-1, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 62);
            this.panel4.TabIndex = 820;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(93, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 22);
            this.label10.TabIndex = 517;
            this.label10.Text = "Backup et Restauration";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(155)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.update);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(232, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 30);
            this.panel2.TabIndex = 833;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(53, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 20);
            this.btnSave.TabIndex = 816;
            this.btnSave.Text = "Valider";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.save.Image = global::ProCouture.Properties.Resources.Checked_32;
            this.save.Location = new System.Drawing.Point(14, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(25, 26);
            this.save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.save.TabIndex = 889;
            this.save.TabStop = false;
            // 
            // update
            // 
            this.update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.update.Image = global::ProCouture.Properties.Resources.Uninstalling_Updates_32;
            this.update.Location = new System.Drawing.Point(14, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(25, 26);
            this.update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.update.TabIndex = 888;
            this.update.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(27, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(41, 48);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 516;
            this.pictureBox8.TabStop = false;
            // 
            // AjoutPersonne
            // 
            this.AjoutPersonne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AjoutPersonne.Image = global::ProCouture.Properties.Resources.icons8_Open_32;
            this.AjoutPersonne.Location = new System.Drawing.Point(302, 40);
            this.AjoutPersonne.Name = "AjoutPersonne";
            this.AjoutPersonne.Size = new System.Drawing.Size(27, 25);
            this.AjoutPersonne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AjoutPersonne.TabIndex = 763;
            this.AjoutPersonne.TabStop = false;
            this.AjoutPersonne.Click += new System.EventHandler(this.AjoutPersonne_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProCouture.Properties.Resources.icons8_Open_32;
            this.pictureBox1.Location = new System.Drawing.Point(310, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 763;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radBackup
            // 
            this.radBackup.AutoSize = true;
            this.radBackup.Location = new System.Drawing.Point(12, 77);
            this.radBackup.Name = "radBackup";
            this.radBackup.Size = new System.Drawing.Size(62, 17);
            this.radBackup.TabIndex = 518;
            this.radBackup.TabStop = true;
            this.radBackup.Text = "Backup";
            this.radBackup.UseVisualStyleBackColor = true;
            this.radBackup.CheckedChanged += new System.EventHandler(this.radBackup_CheckedChanged);
            // 
            // radRestaurer
            // 
            this.radRestaurer.AutoSize = true;
            this.radRestaurer.Location = new System.Drawing.Point(126, 77);
            this.radRestaurer.Name = "radRestaurer";
            this.radRestaurer.Size = new System.Drawing.Size(71, 17);
            this.radRestaurer.TabIndex = 518;
            this.radRestaurer.TabStop = true;
            this.radRestaurer.Text = "Restaurer";
            this.radRestaurer.UseVisualStyleBackColor = true;
            this.radRestaurer.CheckedChanged += new System.EventHandler(this.radRestaurer_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 523;
            this.label1.Text = "Nom de la base de donnée";
            // 
            // bd
            // 
            this.bd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bd.FormattingEnabled = true;
            this.bd.Location = new System.Drawing.Point(49, 289);
            this.bd.Name = "bd";
            this.bd.Size = new System.Drawing.Size(260, 24);
            this.bd.TabIndex = 834;
            // 
            // FrmServeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 321);
            this.Controls.Add(this.bd);
            this.Controls.Add(this.radRestaurer);
            this.Controls.Add(this.radBackup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.rest);
            this.Controls.Add(this.back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmServeur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmServeur";
            this.Load += new System.EventHandler(this.FrmServeur_Load_1);
            this.rest.ResumeLayout(false);
            this.rest.PerformLayout();
            this.back.ResumeLayout(false);
            this.back.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AjoutPersonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox rest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox back;
        private System.Windows.Forms.Label label9;
        private iTalk.iTalk_RichTextBox restaurer;
        private iTalk.iTalk_RichTextBox backup;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label btnSave;
        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.PictureBox update;
        private System.Windows.Forms.PictureBox AjoutPersonne;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radBackup;
        private System.Windows.Forms.RadioButton radRestaurer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bd;
    }
}