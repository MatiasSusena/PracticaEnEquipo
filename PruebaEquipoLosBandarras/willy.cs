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
    public partial class willy : Form
    {
        public willy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuillermoGonzalez formGuillermoGonzalez = new GuillermoGonzalez();
            formGuillermoGonzalez.Show();
            Hide();
        }
    }
}
