using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaEquipoLosBandarras
{
    public partial class javier : Form
    {
        public javier()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            JavierHernandez formJavierHernandez = new JavierHernandez();
            formJavierHernandez.Show();
            Hide();
        }
    }
}
