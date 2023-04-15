using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace idade1
{
    public partial class Form1 : Form
    {
        int valor2 = 365, valor3 = 30;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxidade.Text = "";
            textBoxdias.Text = "";
            textBoxmeses.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxidade.Text = (Convert.ToDecimal(textBoxidade.Text).ToString());
                textBoxdias.Text = (Convert.ToDecimal(textBoxidade.Text) * valor2).ToString();
            textBoxmeses.Text = (Convert.ToDecimal(textBoxdias.Text) / valor3).ToString();



        }
    }
}
