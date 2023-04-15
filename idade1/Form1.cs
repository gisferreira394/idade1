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
        int valor1 = 17, valor2 = 365;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxidade.Text = (Convert.ToDecimal(textBoxidade.Text) * valor2 ).ToString();


            
        }
    }
}
