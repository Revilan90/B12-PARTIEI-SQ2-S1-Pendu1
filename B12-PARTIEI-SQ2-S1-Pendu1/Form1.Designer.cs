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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbAlphabet = new System.Windows.Forms.ComboBox();
            this.lblMotATrouver = new System.Windows.Forms.Label();
            this.txtbSaisieMot = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnRelancer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblGagnePerdu = new System.Windows.Forms.Label();
            this.lstbDejaEssaye = new System.Windows.Forms.ListBox();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 138);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbAlphabet
            // 
            this.cbAlphabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlphabet.FormattingEnabled = true;
            this.cbAlphabet.Location = new System.Drawing.Point(293, 95);
            this.cbAlphabet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAlphabet.Name = "cbAlphabet";
            this.cbAlphabet.Size = new System.Drawing.Size(84, 24);
            this.cbAlphabet.TabIndex = 1;
            // 
            // lblMotATrouver
            // 
            this.lblMotATrouver.AutoSize = true;
            this.lblMotATrouver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotATrouver.Location = new System.Drawing.Point(148, 65);
            this.lblMotATrouver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotATrouver.Name = "lblMotATrouver";
            this.lblMotATrouver.Size = new System.Drawing.Size(184, 17);
            this.lblMotATrouver.TabIndex = 2;
            this.lblMotATrouver.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            // 
            // txtbSaisieMot
            // 
            this.txtbSaisieMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSaisieMot.Location = new System.Drawing.Point(157, 22);
            this.txtbSaisieMot.Name = "txtbSaisieMot";
            this.txtbSaisieMot.Size = new System.Drawing.Size(128, 23);
            this.txtbSaisieMot.TabIndex = 3;
            // 
            // btnValider
            // 
            this.btnValider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnValider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnValider.BackgroundImage")));
            this.btnValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValider.Location = new System.Drawing.Point(293, 10);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(47, 52);
            this.btnValider.TabIndex = 4;
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEffacer.BackgroundImage")));
            this.btnEffacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEffacer.Location = new System.Drawing.Point(346, 10);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(47, 52);
            this.btnEffacer.TabIndex = 5;
            this.btnEffacer.UseVisualStyleBackColor = true;
            // 
            // btnRelancer
            // 
            this.btnRelancer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRelancer.BackgroundImage")));
            this.btnRelancer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelancer.Location = new System.Drawing.Point(293, 124);
            this.btnRelancer.Name = "btnRelancer";
            this.btnRelancer.Size = new System.Drawing.Size(47, 50);
            this.btnRelancer.TabIndex = 6;
            this.btnRelancer.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuitter.BackgroundImage")));
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitter.Location = new System.Drawing.Point(346, 124);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(99, 50);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // lblGagnePerdu
            // 
            this.lblGagnePerdu.AutoSize = true;
            this.lblGagnePerdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGagnePerdu.Location = new System.Drawing.Point(12, 161);
            this.lblGagnePerdu.Name = "lblGagnePerdu";
            this.lblGagnePerdu.Size = new System.Drawing.Size(134, 24);
            this.lblGagnePerdu.TabIndex = 8;
            this.lblGagnePerdu.Text = "Perdu/Gagne";
            // 
            // lstbDejaEssaye
            // 
            this.lstbDejaEssaye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbDejaEssaye.FormattingEnabled = true;
            this.lstbDejaEssaye.ItemHeight = 16;
            this.lstbDejaEssaye.Location = new System.Drawing.Point(157, 95);
            this.lstbDejaEssaye.Name = "lstbDejaEssaye";
            this.lstbDejaEssaye.Size = new System.Drawing.Size(120, 84);
            this.lstbDejaEssaye.TabIndex = 9;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(382, 95);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(63, 23);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 200);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lstbDejaEssaye);
            this.Controls.Add(this.lblGagnePerdu);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRelancer);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtbSaisieMot);
            this.Controls.Add(this.lblMotATrouver);
            this.Controls.Add(this.cbAlphabet);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Jeux du Pendu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbAlphabet;
        private System.Windows.Forms.Label lblMotATrouver;
        private System.Windows.Forms.TextBox txtbSaisieMot;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnRelancer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblGagnePerdu;
        private System.Windows.Forms.ListBox lstbDejaEssaye;
        private System.Windows.Forms.Button btnTest;
    }
}

