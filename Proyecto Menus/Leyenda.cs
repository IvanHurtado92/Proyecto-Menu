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
    public partial class Leyenda : Form
    {
        public Leyenda()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
			int millon, cienmil, diezmil, mil, cen, dec, uni;
			int num = Convert.ToInt32(numorig.Text);
			string texto = "";


			if (num < 1 || num > 1000000)
			{
				MessageBox.Show("Solo se pueden asignar valores del 1 al 1000000");
			}
			else
			{
				millon = (num - (num % 1000000)) / 1000000; num = (num % 1000000);
				cienmil = (num - (num % 100000)) / 100000; num = (num % 100000);
				diezmil = (num - (num % 10000)) / 10000; num = (num % 10000);
				mil = (num - (num % 1000)) / 1000; num = (num % 1000);
				cen = (num - (num % 100)) / 100; num = (num % 100);
				dec = (num - (num % 10)) / 10; num = (num % 10);
				uni = num;

				switch (millon)
				{
					case 1: texto = ("Un millon"); break;
				}
				switch (cienmil)
				{
					case 1:
						if (diezmil == 0 && mil == 0)
						{
							texto = texto +("Cien mil"); break;
						}
						else
						{
							texto = texto +("Ciento"); break;
						}
					case 2: texto = texto +("Doscientos"); break;
					case 3: texto = texto +("Trescientos"); break;
					case 4: texto = texto +("Cuatrocientos"); break;
					case 5: texto = texto +("Quinientos"); break;
					case 6: texto = texto +("Seiscientos"); break;
					case 7: texto = texto +("Setecientos"); break;
					case 8: texto = texto +("Ochocientos"); break;
					case 9: texto = texto +("Novecientos"); break;
				}
				if (cienmil > 2 && diezmil == 0 && mil == 0)
					texto = texto +(" Mil");
				switch (diezmil)
				{
					case 1:
						switch (mil)
						{
							case 0: texto = texto +(" Diez"); break;
							case 1: texto = texto +(" Once"); break;
							case 2: texto = texto +(" Doce"); break;
							case 3: texto = texto +(" Trece"); break;
							case 4: texto = texto +(" Catorce"); break;
							case 5: texto = texto +(" Quince"); break;
							case 6: texto = texto +(" Diez y seis"); break;
							case 7: texto = texto +(" Diez y siete"); break;
							case 8: texto = texto +(" Diez y ocho"); break;
							case 9: texto = texto +(" Diez y nueve"); break;
						}
						break;

					case 2:
						if (mil == 0)
						{
							texto = texto +(" Veinte mil"); break;
						}
						else
						{
							texto = texto +(" Veinti"); break;
						}
					case 3: texto = texto +(" Treinta"); break;
					case 4: texto = texto +(" Cuarenta"); break;
					case 5: texto = texto +(" Cincuenta"); break;
					case 6: texto = texto +(" Sesenta"); break;
					case 7: texto = texto +(" Setenta"); break;
					case 8: texto = texto +(" Ochenta"); break;
					case 9: texto = texto +(" Noventa"); break;
				}
				if (diezmil > 2 && mil != 0)
					texto = texto +(" y");
				else
				{
					if (diezmil > 2 && mil == 0)
						texto = texto +(" Mil");
				}
				if (diezmil != 1)
				{
					switch (mil)
					{
						case 1:
							if (cienmil == 0 && diezmil == 0)
							{
								texto = texto +("Mil"); break;
							}
							else
							{
								texto = texto +(" Un mil"); break;
							}
						case 2: texto = texto +(" Dos mil"); break;
						case 3: texto = texto +(" Tres mil"); break;
						case 4: texto = texto +(" Cuatro mil"); break;
						case 5: texto = texto +(" Cinco mil"); break;
						case 6: texto = texto +(" Seis mil"); break;
						case 7: texto = texto +(" Siete mil"); break;
						case 8: texto = texto +(" Ocho mil"); break;
						case 9: texto = texto +(" Nueve mil"); break;
					}
				}
				switch (cen)
				{
					case 1:
						if (dec != 0)
						{
							texto = texto +(" Ciento"); break;
						}
						else
						{
							texto = texto +(" Cien"); break;
						}
					case 2: texto = texto +(" Doscientos"); break;
					case 3: texto = texto +(" Trescientos"); break;
					case 4: texto = texto +(" Cuatrocientos"); break;
					case 5: texto = texto +(" Quinientos"); break;
					case 6: texto = texto +(" Seiscientos"); break;
					case 7: texto = texto +(" Setecientos"); break;
					case 8: texto = texto +(" Ochocientos"); break;
					case 9: texto = texto +(" Novecientos"); break;
				}
				switch (dec)  //Optimizarlo para que solo tengas que poner un solo condicional para que se imprima el "y" despu�s de cada decena que la nececite
				{
					case 1:
						switch (uni)
						{
							case 0: texto = texto +(" Diez"); break;
							case 1: texto = texto +(" Once"); break;
							case 2: texto = texto +(" Doce"); break;
							case 3: texto = texto +(" Trece"); break;
							case 4: texto = texto +(" Catorce"); break;
							case 5: texto = texto +(" Quince"); break;
							case 6: texto = texto +(" Diez y seis"); break;
							case 7: texto = texto +(" Diez y siete"); break;
							case 8: texto = texto +(" Diez y ocho"); break;
							case 9: texto = texto +(" Diez y nueve"); break;
						}
						break;

					case 2:
						if (uni == 0)
						{
							texto = texto +(" Veinte"); break;
						}
						else
					{
							texto = texto +(" Veinti"); break;
						}
					case 3: texto = texto +(" Treinta"); break;
					case 4: texto = texto +(" Cuarenta"); break;
					case 5: texto = texto +(" Cincuenta"); break;
					case 6: texto = texto +(" Sesenta"); break;
					case 7: texto = texto +(" Setenta"); break;
					case 8: texto = texto +(" Ochenta"); break;
					case 9: texto = texto +(" Noventa"); break;
				}
				if (dec > 2 && uni != 0)
					texto = texto +(" y");
				if (dec != 1)
				{
					switch (uni)
					{
						case 1: texto = texto +(" Uno"); break;
						case 2: texto = texto +(" Dos"); break;
						case 3: texto = texto +(" Tres"); break;
						case 4: texto = texto +(" Cuatro"); break;
						case 5: texto = texto +(" Cinco"); break;
						case 6: texto = texto +(" Seis"); break;
						case 7: texto = texto +(" Siete"); break;
						case 8: texto = texto +(" Ocho"); break;
						case 9: texto = texto +(" Nueve"); break;
					}
				}
			}
			numtexto.Text = texto;
		}

        private void button1_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
