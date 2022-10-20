using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B12_PARTIEI_SQ2_S1_Pendu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alphabet()
        {
            int lettre = 65;
            for (int i = 0; i<26; i++)
            {
                cbAlphabet.Items.Add((char)(lettre+i));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            alphabet();
        }
    }
}
