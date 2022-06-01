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
    public partial class Maya : Form
    {
        public Maya()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num = Convert.ToInt32(textBox2.Text);
            double potencia, res, cinco, i, j, uni;
			int pot2, res2, cinco2, uni2, num2;
			num2 = Convert.ToInt32(num);
			label5.Text = "";
			label4.Text = Convert.ToString(num);
			if (num < 1000000 && num > 1)
			{

				MessageBox.Show("Transformando "+num+ " a numeros mayas...\nLa letra O equivale a 0\n");

				for (j = 4; j >= 0; j--)
				{
					potencia = Math.Pow(20, j);
					pot2 = Convert.ToInt32(potencia);
					if (num2 >= pot2)
					{
						res = num2 / (pot2);
						res2 = Convert.ToInt32(res);
						cinco = Math.Floor(res / 5);
						cinco2 = Convert.ToInt32(cinco);
						uni = res - (5 * cinco2);
						uni2 = Convert.ToInt32(uni);
						for (i = 0; i < uni2; i++)
						{
							label5.Text+="*";
						}
						for (i = 0; i < cinco2; i++)
						{
							label5.Text +="\n---";
						}
						num2 = (num2 - (res2 * pot2));
						if (res2 == 0)
						{
							label5.Text +="O";
						}
					}
					label5.Text+="\n";
					button1.Enabled = false;
					textBox2.Enabled = false;
				}
			}
			else
			{
				MessageBox.Show("Numero incorrecto, debe ser entre 1 y 1000000");
			}
		}

        private void button2_Click(object sender, EventArgs e)
        {
			label5.Text = "Resultado:";
            textBox2.Clear();
            label2.Text = "Decimal:";
            label4.Text = "";
			button1.Enabled = true;
			textBox2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
/*listBox1.Items.Add(resultado+="O");
 * listBox1.Items.Add(resultado+="-");
 * listBox1.Items.Add(resultado+="*"); 
 listBox1.Items.Add(resultado+="\n\n"); */
