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
    public partial class Romanos : Form
    {
        public Romanos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			int mil, cen, dec, uni, numoriginal;
			string texto = "";

			int num = Convert.ToInt32(numn.Text);

			if (num < 1 || num > 3999)
			{
				MessageBox.Show("Solo se pueden números entre 1 y 3999");
			}
			else
			{
				numoriginal = num;
				mil = (num - (num % 1000)) / 1000; num = (num % 1000);
				cen = (num - (num % 100)) / 100; num = (num % 100);
				dec = (num - (num % 10)) / 10; num = (num % 10);
				uni = num;

				switch (mil)
				{
					case 1: texto = texto +("M"); break;
					case 2: texto = texto +("MM"); break;
					case 3: texto = texto +("MMM"); break;
				}
				switch (cen)
				{
					case 1: texto = texto +("C"); break;
					case 2: texto = texto +("CC"); break;
					case 3: texto = texto +("CCC"); break;
					case 4: texto = texto +("CD"); break;
					case 5: texto = texto +("D"); break;
					case 6: texto = texto +("DC"); break;
					case 7: texto = texto +("DCC"); break;
					case 8: texto = texto +("DCCC"); break;
					case 9: texto = texto +("CM"); break;
				}
				switch (dec)
				{
					case 1: texto = texto +("X"); break;
					case 2: texto = texto +("XX"); break;
					case 3: texto = texto +("XXX"); break;
					case 4: texto = texto +("XL"); break;
					case 5: texto = texto +("L"); break;
					case 6: texto = texto +("LX"); break;
					case 7: texto = texto +("LXX"); break;
					case 8: texto = texto +("LXXX"); break;
					case 9: texto = texto +("XC"); break;
				}
				switch (uni)
				{
					case 1: texto = texto +("I"); break;
					case 2: texto = texto +("II"); break;
					case 3: texto = texto +("III"); break;
					case 4: texto = texto +("IV"); break;
					case 5: texto = texto +("V"); break;
					case 6: texto = texto +("VI"); break;
					case 7: texto = texto +("VII"); break;
					case 8: texto = texto +("VIII"); break;
					case 9: texto = texto +("IX"); break;
				}
			}
			numr.Text = texto;
		}

        private void button2_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
