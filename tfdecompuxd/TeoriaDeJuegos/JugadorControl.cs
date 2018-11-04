using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeoriaDeJuegos
{
    public partial class JugadorControl : UserControl
    {

        public void logica_boton(int din, string credito, string inversion, string label, CEdificio e)
        {
            din = int.Parse(credito);
            inversion = label;

            dinero = int.Parse(txb_credito.Text);
            txb_inversion.Text = label;

            if (dinero >= Int32.Parse(label))
            {
                txb_credito.Text = obj.Calcular(perso, e).ToString();
                listView1.Items.Add(new ListViewItem(new[] { ronda.ToString(), txb_inversion.Text.ToString() }));
                labelRonda.Text = "RONDA " + ronda;
                ronda = ronda + 1;
            }
            else
            {
                labelRonda.Text = "Dinero insuficiente";
            }
            labelRonda.Visible = Visible;
        }

        CControladora obj = new CControladora();
        CPersona perso = new CPersona(0);

        static Random r = new Random();

        CEdificio e1 = new CEdificio(r.Next(100, 100));

        CEdificio e2 = new CEdificio(r.Next(1000, 10000));

        CEdificio e3 = new CEdificio(r.Next(1000, 10000));

        CEdificio e4 = new CEdificio(r.Next(1000, 10000));

        CEdificio e5 = new CEdificio(r.Next(1000, 10000));

        CEdificio e6 = new CEdificio(r.Next(1000, 10000));

        CEdificio e7 = new CEdificio(r.Next(1000, 10000));

        CEdificio e8 = new CEdificio(r.Next(1000, 10000));

        CEdificio e9 = new CEdificio(r.Next(1000, 10000));

        int ronda = 1;



        int dinero;

        public JugadorControl()
        {
            InitializeComponent();

         label10.Text = e1.Precio.ToString();
         label14.Text = e2.Precio.ToString();
         label15.Text = e3.Precio.ToString();
         label16.Text = e4.Precio.ToString();
         label17.Text = e5.Precio.ToString();
         label18.Text = e6.Precio.ToString();
         label19.Text = e7.Precio.ToString();
         label20.Text = e8.Precio.ToString();
         label21.Text = e9.Precio.ToString();
        
         txb_credito.Text = perso.Credito.ToString();
        }

        private void Bedif1_Click(object sender, EventArgs e)
        {
            logica_boton(dinero, txb_credito.Text, txb_inversion.Text, label10.Text, e1);
        }

        private void Bedif2_Click(object sender, EventArgs e)
        {
            logica_boton(dinero, txb_credito.Text, txb_inversion.Text, label14.Text, e2);
        }

        private void Bedif3_Click(object sender, EventArgs e)
        {
            logica_boton(dinero, txb_credito.Text, txb_inversion.Text, label15.Text, e3);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Bedif4_Click(object sender, EventArgs e)
        {
            logica_boton(dinero, txb_credito.Text, txb_inversion.Text, label16.Text, e4);
        }

        private void Bedif5_Click(object sender, EventArgs e)
        {
            logica_boton(dinero, txb_credito.Text, txb_inversion.Text, label17.Text, e5);
        }

        private void Bedif6_Click(object sender, EventArgs e)
        {
            logica_boton(dinero, txb_credito.Text, txb_inversion.Text, label18.Text, e6);
        }

        private void Bedif7_Click(object sender, EventArgs e)
        {
            logica_boton(dinero, txb_credito.Text, txb_inversion.Text, label19.Text, e7);
        }

        private void Bedif8_Click(object sender, EventArgs e)
        {
            logica_boton(dinero, txb_credito.Text, txb_inversion.Text, label20.Text, e8);
        }

        private void Bedif9_Click(object sender, EventArgs e)
        {
            logica_boton(dinero, txb_credito.Text, txb_inversion.Text, label21.Text, e9);
        }

        private void bt_definir_credito_Click(object sender, EventArgs e)
        {
            perso.set_credito(Int32.Parse(txb_credito.Text));
           
        }

        private void JugadorControl_Load(object sender, EventArgs e)
        {

            listView1.View = View.Details;
            listView1.Columns.Add("Ronda", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Monto", 200, HorizontalAlignment.Center);
        }

        private void txb_credito_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
