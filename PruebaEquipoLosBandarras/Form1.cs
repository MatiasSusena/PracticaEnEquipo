using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Equipo Los Bandarras
namespace PruebaEquipoLosBandarras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //this.SetDesktopLocation(200,200);
            
            InitializeComponent();
          // this.SetDesktopLocation(800,600);
            this.SetBounds(800, 600, 200, 200);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

           matias formMatias = new matias();
           formMatias.Show();
           Hide();

            }

        private void button2_Click(object sender, EventArgs e)
        {
            javier formJavier = new javier();
            formJavier.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            willy formWilly = new willy();
            formWilly.Show();
            Hide();
        }
    }
}
