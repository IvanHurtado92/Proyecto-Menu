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
    public partial class CualquierBase : Form
    {
        public CualquierBase()
        {
            InitializeComponent();
        }

        private void convertir_Click(object sender, EventArgs e)
        {
            double n10 = Convert.ToDouble(Numero.Text);
            int Base = Convert.ToInt32(Basenum.Text);
            if (Base < 2 || Base > 16)
            {
                MessageBox.Show("La base es incorrecta, debe estar entre 2 y 16");
            } else
            {
                int entera = (Int32)n10;
                int cociente, residuo, i = 0;
                int[] parte_entera = new int[30];
                double decim = n10 - (double)entera;
                String total = "";

                //Parte entera
                do
                {
                    cociente = entera / Base;
                    residuo = entera % Base;
                    entera = cociente;
                    parte_entera[i] = residuo;
                    i++;
                } while (cociente != 0 || residuo != 0);
                i = i - 2;
                for (int j = i; j >= 0; j--)
                {
                    if (parte_entera[j] > 9)
                    {
                        switch (parte_entera[j])
                        {
                            case 10:
                                total = total + "A"; break;
                            case 11:
                                total = total + "B"; break;
                            case 12:
                                total = total + "C"; break;
                            case 13:
                                total = total + "D"; break;
                            case 14:
                                total = total + "E"; break;
                            case 15:
                                total = total + "F"; break;
                        }
                    }
                    else
                        total = total + parte_entera[j].ToString();
                }

                total = total + ".";

                //Parte Decimal
                int entero;
                double producto;
                double residuo_mul;
                int limite = 1;

                do
                {
                    producto = decim * Base;
                    entero = (Int32)producto;
                    residuo_mul = (double)producto - (double)entero;
                    decim = residuo_mul;
                    if (entero > 9)
                    {
                        switch (entero)
                        {
                            case 10:
                                total = total + "A"; break;
                            case 11:
                                total = total + "B"; break;
                            case 12:
                                total = total + "C"; break;
                            case 13:
                                total = total + "D"; break;
                            case 14:
                                total = total + "E"; break;
                            case 15:
                                total = total + "F"; break;
                        }
                    }
                    else
                    {
                        total = total + entero.ToString();
                    }
                    limite++;
                } while (producto != 0 && limite < 25);

                Result.Text = total;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
