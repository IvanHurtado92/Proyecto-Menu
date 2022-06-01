using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Menus
{
    public partial class EnvCalen : Form
    {
        public EnvCalen()
        {
            InitializeComponent();
            label12.Hide();
            label13.Hide();
            label15.Hide();
            calendario.Hide();
            button9.Enabled = false;
        }
        public static double costo = 0;
        public int cosmon, mons = 0;
        public int costel, tels = 0;
        public int cosboc, bocs = 0;
        public int cosaud, auds = 0;
        public int coslap, laps = 0;
        public int coscom, coms = 0;

        private void button8_Click(object sender, EventArgs e)
        {
            
            costo = costo + cosmon + costel + cosboc + cosaud + coslap + coscom;
            double envio = costo * 0.02;
            label8.Text = "Costo: "+ Convert.ToString(costo);
            label10.Text = "Envío: "+ Convert.ToString(envio);
            label11.Text = "Total: " + Convert.ToString(costo + envio);
            
            costo = 0;
            envio = 0;
            cosmon = costel = cosboc = cosaud = coslap = coscom = mons = tels = bocs = auds = laps = coms = 0;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button8.Enabled = false;
            label12.Show();
            label13.Show();
            label15.Show();
            calendario.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label8.Text = "Costo: ";
            label10.Text = "Envío: ";
            label11.Text = "Total: ";
            label13.Text = "Fecha de entrega: ";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = false;
            label12.Hide();
            label13.Hide();
            label15.Hide();
            calendario.Hide();
            calendario.Enabled = true;
            listBox1.Items.Clear();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Random ale = new Random();
            int alea = ale.Next(2, 5);
            DateTime fechaenv = calendario.Value.AddDays(alea);
            label13.Text = "Fecha de Entrega: " + fechaenv.ToString("ddd dd/MM/yyyy");
            label12.Text = "Fecha de Encargo: " + calendario.Value.ToString("ddd dd/MM/yyyy");
            calendario.Enabled = false;
            button9.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mons++;
            cosmon = mons * 3000;
            listBox1.Items.Add("Monitor: $3000");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tels++;
            costel = tels * 8000;
            listBox1.Items.Add("Televisión: $8000");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bocs++;
            cosboc = bocs * 1000;
            listBox1.Items.Add("Bocinas: $1000");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            auds++;
            cosaud = auds * 500;
            listBox1.Items.Add("Audífonos: $500");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            laps++;
            coslap = laps * 7000;
            listBox1.Items.Add("Laptop: $7000");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            coms++;
            coscom = coms * 13000;
            listBox1.Items.Add("Computadora: $13000");
        }
    }
}
