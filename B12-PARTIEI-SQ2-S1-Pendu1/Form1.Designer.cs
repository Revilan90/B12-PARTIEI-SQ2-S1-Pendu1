namespace B12_PARTIEI_SQ2_S1_Pendu1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbPendu = new System.Windows.Forms.PictureBox();
            this.cbAlphabet = new System.Windows.Forms.ComboBox();
            this.lblMotATrouver = new System.Windows.Forms.Label();
            this.txtbSaisieMot = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnRelancer = new System.Windows.Forms.Button();
            this.lblGagnePerdu = new System.Windows.Forms.Label();
            this.lstbDejaEssaye = new System.Windows.Forms.ListBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.grpPhase2 = new System.Windows.Forms.GroupBox();
            this.grpPhase1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPendu)).BeginInit();
            this.grpPhase2.SuspendLayout();
            this.grpPhase1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPendu
            // 
            this.pbPendu.Location = new System.Drawing.Point(18, 13);
            this.pbPendu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPendu.Name = "pbPendu";
            this.pbPendu.Size = new System.Drawing.Size(180, 170);
            this.pbPendu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPendu.TabIndex = 0;
            this.pbPendu.TabStop = false;
            // 
            // cbAlphabet
            // 
            this.cbAlphabet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlphabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlphabet.FormattingEnabled = true;
            this.cbAlphabet.Location = new System.Drawing.Point(176, 51);
            this.cbAlphabet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAlphabet.Name = "cbAlphabet";
            this.cbAlphabet.Size = new System.Drawing.Size(111, 28);
            this.cbAlphabet.TabIndex = 1;
            this.cbAlphabet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAlphabet_KeyPress);
            // 
            // lblMotATrouver
            // 
            this.lblMotATrouver.AutoSize = true;
            this.lblMotATrouver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotATrouver.Location = new System.Drawing.Point(6, 17);
            this.lblMotATrouver.Name = "lblMotATrouver";
            this.lblMotATrouver.Size = new System.Drawing.Size(321, 29);
            this.lblMotATrouver.TabIndex = 2;
            this.lblMotATrouver.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            // 
            // txtbSaisieMot
            // 
            this.txtbSaisieMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSaisieMot.Location = new System.Drawing.Point(12, 17);
            this.txtbSaisieMot.Margin = new System.Windows.Forms.Padding(4);
            this.txtbSaisieMot.MaxLength = 15;
            this.txtbSaisieMot.Name = "txtbSaisieMot";
            this.txtbSaisieMot.Size = new System.Drawing.Size(169, 26);
            this.txtbSaisieMot.TabIndex = 3;
            this.txtbSaisieMot.TextChanged += new System.EventHandler(this.txtbSaisieMot_TextChanged);
            this.txtbSaisieMot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbSaisieMot_KeyPress);
            // 
            // btnValider
            // 
            this.btnValider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnValider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnValider.BackgroundImage")));
            this.btnValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValider.Location = new System.Drawing.Point(242, 3);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(63, 64);
            this.btnValider.TabIndex = 4;
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnRelancer
            // 
            this.btnRelancer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRelancer.BackgroundImage")));
            this.btnRelancer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelancer.Location = new System.Drawing.Point(177, 85);
            this.btnRelancer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRelancer.Name = "btnRelancer";
            this.btnRelancer.Size = new System.Drawing.Size(63, 62);
            this.btnRelancer.TabIndex = 6;
            this.btnRelancer.UseVisualStyleBackColor = true;
            this.btnRelancer.Click += new System.EventHandler(this.btnRelancer_Click);
            // 
            // lblGagnePerdu
            // 
            this.lblGagnePerdu.AutoSize = true;
            this.lblGagnePerdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGagnePerdu.Location = new System.Drawing.Point(16, 198);
            this.lblGagnePerdu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGagnePerdu.Name = "lblGagnePerdu";
            this.lblGagnePerdu.Size = new System.Drawing.Size(168, 29);
            this.lblGagnePerdu.TabIndex = 8;
            this.lblGagnePerdu.Text = "Perdu/Gagne";
            // 
            // lstbDejaEssaye
            // 
            this.lstbDejaEssaye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbDejaEssaye.FormattingEnabled = true;
            this.lstbDejaEssaye.ItemHeight = 20;
            this.lstbDejaEssaye.Location = new System.Drawing.Point(10, 48);
            this.lstbDejaEssaye.Margin = new System.Windows.Forms.Padding(4);
            this.lstbDejaEssaye.Name = "lstbDejaEssaye";
            this.lstbDejaEssaye.Size = new System.Drawing.Size(159, 84);
            this.lstbDejaEssaye.TabIndex = 9;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(294, 50);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(84, 28);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // grpPhase2
            // 
            this.grpPhase2.Controls.Add(this.btnTest);
            this.grpPhase2.Controls.Add(this.lstbDejaEssaye);
            this.grpPhase2.Controls.Add(this.lblMotATrouver);
            this.grpPhase2.Controls.Add(this.btnRelancer);
            this.grpPhase2.Controls.Add(this.cbAlphabet);
            this.grpPhase2.Location = new System.Drawing.Point(198, 95);
            this.grpPhase2.Name = "grpPhase2";
            this.grpPhase2.Size = new System.Drawing.Size(387, 162);
            this.grpPhase2.TabIndex = 11;
            this.grpPhase2.TabStop = false;
            this.grpPhase2.Text = "Recherche";
            // 
            // grpPhase1
            // 
            this.grpPhase1.Controls.Add(this.btnValider);
            this.grpPhase1.Controls.Add(this.txtbSaisieMot);
            this.grpPhase1.Location = new System.Drawing.Point(197, 10);
            this.grpPhase1.Name = "grpPhase1";
            this.grpPhase1.Size = new System.Drawing.Size(318, 79);
            this.grpPhase1.TabIndex = 12;
            this.grpPhase1.TabStop = false;
            this.grpPhase1.Text = "Veuillez saisir un mot à chercher";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 269);
            this.Controls.Add(this.grpPhase1);
            this.Controls.Add(this.grpPhase2);
            this.Controls.Add(this.lblGagnePerdu);
            this.Controls.Add(this.pbPendu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Jeux du Pendu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPendu)).EndInit();
            this.grpPhase2.ResumeLayout(false);
            this.grpPhase2.PerformLayout();
            this.grpPhase1.ResumeLayout(false);
            this.grpPhase1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPendu;
        private System.Windows.Forms.ComboBox cbAlphabet;
        private System.Windows.Forms.Label lblMotATrouver;
        private System.Windows.Forms.TextBox txtbSaisieMot;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnRelancer;
        private System.Windows.Forms.Label lblGagnePerdu;
        private System.Windows.Forms.ListBox lstbDejaEssaye;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.GroupBox grpPhase2;
        private System.Windows.Forms.GroupBox grpPhase1;
    }
}

