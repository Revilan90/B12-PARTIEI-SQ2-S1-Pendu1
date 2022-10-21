using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace B12_PARTIEI_SQ2_S1_Pendu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //initialisation variable suivant l'évolution du jeux
        private int pendu;
        //remplissage du tableau du pendu
        string[] tabPendu = new string[11] { "pendu0", "pendu1", "pendu2", "pendu3", "pendu4", "pendu5", "pendu6", "pendu7", "pendu8", "pendu9", "pendu10" };


        private void phase1()
        {
            alphabet();
            pendu = 0;
            mAJPendu();
            btnTest.Enabled = true;
            cbAlphabet.Enabled = true;
            txtbSaisieMot.Text = " ";
            lblMotATrouver.Text = "";
            grpPhase1.Visible = true;
            grpPhase2.Visible = false;
            lblGagnePerdu.Text = "";
            lstbDejaEssaye.Items.Clear();
            txtbSaisieMot.Focus();
        }

        private void phase2()
        {
            for (int i = 0; i < txtbSaisieMot.TextLength; i++)
            {
                lblMotATrouver.Text += "_ ";
            }
            grpPhase1.Visible = false;
            grpPhase2.Visible = true;
            cbAlphabet.SelectedIndex = 0;
            cbAlphabet.Focus();
        }
        private void mAJPendu()
        {
            pbPendu.Image = (Image)Properties.Resources.ResourceManager.GetObject(tabPendu[pendu]);
        }
        private void finPhase2()
        {
            btnTest.Enabled = false;
            cbAlphabet.Enabled = false;
        }
        private void alphabet()
        {
            // remplissage de la combobox avec l'aplphabet
            cbAlphabet.Items.Clear();
            int lettre = 65;
            for (int i = 0; i<26; i++)
            {
                cbAlphabet.Items.Add((char)(lettre+i));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // initialisation à la phase 1
            phase1();
        }

        private void txtbSaisieMot_TextChanged(object sender, EventArgs e)
        {
            // vérification que seule des lettre de l'aphabet basique sont rentrées
            string lettres = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i< txtbSaisieMot.TextLength; i++)
            {
                if (!lettres.Contains(txtbSaisieMot.Text.Substring(i,1)))
                {
                    txtbSaisieMot.Clear();
                    txtbSaisieMot.Focus();
                }
            }
            
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // ajout de la lettre à la liste des déja essayé
            lstbDejaEssaye.Items.Add(cbAlphabet.SelectedItem);
            // recherche de la lettre au sein du mot à chercher
            int i = 0;
            string lettre = cbAlphabet.SelectedItem.ToString().ToLower();
            // si la lettre sélectionne est dans le mot à chercher, remplacement des tirets par la lettre
            if (txtbSaisieMot.Text.Contains(lettre))
            {
                while (txtbSaisieMot.Text.IndexOf(lettre, i) != -1 && i < txtbSaisieMot.TextLength)
                {
                    lblMotATrouver.Text = lblMotATrouver.Text.Remove(txtbSaisieMot.Text.IndexOf(lettre, i) * 2, 1);
                    lblMotATrouver.Text = lblMotATrouver.Text.Insert(txtbSaisieMot.Text.IndexOf(lettre, i) * 2, lettre);
                    i = txtbSaisieMot.Text.IndexOf(lettre, i) + 1;
                }
            }
            // si la lettre n'est pas dans le mot on incrémente le pendu
            else
            {
                pendu++;
                mAJPendu();
                // si pendu a 10 ou plus de lettre disponible on perd
                if (pendu == 10 || cbAlphabet.Items.Count == 0)
                {
                    lblGagnePerdu.Text = "PERDU";
                    finPhase2();
                }
            }
            // retire le lettre  de la combobox de sélection de lettre
            cbAlphabet.Items.Remove(cbAlphabet.SelectedItem);
            cbAlphabet.SelectedIndex = 0;
            // si mot trouvé on gagne
            if (!lblMotATrouver.Text.Contains("_"))
            {
                lblGagnePerdu.Text = "GAGNE";
                finPhase2();
            }
        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            // passage en phase 2 si la zone de saisie n'est pas vide
            if (txtbSaisieMot.TextLength > 0)
            {
                phase2();
            }
        }
        private void txtbSaisieMot_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si appui sur la touche entrée dans la zone de saisie, equivalent à appuyer sur le bouton valider
            if (e.KeyChar == (char)Keys.Return)
            {
                btnValider_Click(null, null);
            }
        }

        private void btnRelancer_Click(object sender, EventArgs e)
        {
            // si appui sur bouton relancer, repassage à la phase 1
            phase1();
        }

        private void cbAlphabet_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si appui sur la touche entrée dans la zone de saisie, equivalent à appuyer sur le bouton test
            if (e.KeyChar == (char)Keys.Return)
            {
                btnTest_Click(null, null);
            }
        }
    }
}
