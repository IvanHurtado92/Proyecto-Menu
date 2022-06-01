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
    public partial class Quienes_Somos : Form
    {
        public Quienes_Somos()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            var parameter = new System.Diagnostics.ProcessStartInfo { Verb = "open", FileName = "explorer", Arguments = "https://www.facebook.com/joseluis.elizondo.904" }; //Proceso para abrir links desde un form secundario
            System.Diagnostics.Process.Start(parameter);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel4.LinkVisited = true;
            var parameter = new System.Diagnostics.ProcessStartInfo { Verb = "open", FileName = "explorer", Arguments = "https://www.facebook.com/obed.toledo.14" };
            System.Diagnostics.Process.Start(parameter);
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel8.LinkVisited = true;
            var parameter = new System.Diagnostics.ProcessStartInfo { Verb = "open", FileName = "explorer", Arguments = "https://www.facebook.com/Mauricio.RG.10" };
            System.Diagnostics.Process.Start(parameter);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel6.LinkVisited = true;
            var parameter = new System.Diagnostics.ProcessStartInfo { Verb = "open", FileName = "explorer", Arguments = "https://www.facebook.com/ivan.hur02" };
            System.Diagnostics.Process.Start(parameter);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel5.LinkVisited = true;
            var parameter = new System.Diagnostics.ProcessStartInfo { Verb = "open", FileName = "explorer", Arguments = "https://github.com/IvanHurtado92" };
            System.Diagnostics.Process.Start(parameter);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            var parameter = new System.Diagnostics.ProcessStartInfo { Verb = "open", FileName = "explorer", Arguments = "https://github.com/ElizondoStudios" };
            System.Diagnostics.Process.Start(parameter);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;
            var parameter = new System.Diagnostics.ProcessStartInfo { Verb = "open", FileName = "explorer", Arguments = "https://github.com/Obed-Toledo" };
            System.Diagnostics.Process.Start(parameter);
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel7.LinkVisited = true;
            var parameter = new System.Diagnostics.ProcessStartInfo { Verb = "open", FileName = "explorer", Arguments = "https://github.com/MauriRiver345" };
            System.Diagnostics.Process.Start(parameter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
