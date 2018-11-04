using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeoriaDeJuegos
{
    public partial class FormMenu : Form
    {

      
        public FormMenu()
        {
            InitializeComponent();
            Panel1.Height = button1.Height;
            Panel1.Top = button1.Top;
            jugadorControl1.BringToFront();  
        
            
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

            //    listView1.View = View.Details;
            //    listView1.Columns.Add("Ronda", 100, HorizontalAlignment.Center);
            //    listView1.Columns.Add("Monto", 200, HorizontalAlignment.Center);
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel1.Height = button1.Height;
            Panel1.Top = button1.Top;

            jugadorControl1.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel1.Height = button2.Height;
            Panel1.Top = button2.Top;
            computadoraControl2.BringToFront();
  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Panel1.Top = button3.Top;
            Panel1.Height = button3.Height;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Panel1.Height = button4.Height;
            Panel1.Top = button4.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Panel1.Height = button5.Height;
            Panel1.Top = button5.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jugadorControl1_Load(object sender, EventArgs e)
        {

        }

        private void computadoraControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
