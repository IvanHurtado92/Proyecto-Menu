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
    public partial class Gato3D : Form
    {
        public void Form1_Load(object sender, EventArgs e)
        {

        }


        //Variables para el tablero
        int JugadorTurn = 1;
        int index = 1;
        Button[,] boton = new Button[9, 9];
        public int[] solucionesHechas = new int[25];
        int x = 300;
        int y = 100;
        int Compu = 0;
        int victoriasJ1=0, victoriasJ2=0;
        int FichaPuestaIA=1;

        //Imprimir tablero
        public void Tablero()
        {
            boton[0, 0] = new Button();
            int xPosc = 300;
            int NumBoton = 0;
            int CambiodeTablero = 0;
            Jugador.Visible = true;
            gatolab.Visible = false;
            tresdlab.Visible = false;
            Home.Visible = true;
            Home.Enabled = true;
            Restart.Visible = true;
            Restart.Enabled = true;

            //Turno
            Turno.Visible = true;

            //Contador de victorias
            J1_victorias.Visible = true;
            J2_victorias.Visible = true;
            J1_victorias.Text = "Puntaje J1: " + victoriasJ1;
            J2_victorias.Text = "Puntaje J2: " + victoriasJ2;

            for(int k = 0; k < 3; k++)
            {
                for (int i = CambiodeTablero; i <(CambiodeTablero+3); i++)
                {
                    for (int j = CambiodeTablero; j < (CambiodeTablero+3); j++)
                    {
                        NumBoton++;
                        boton[i, j] = new Button();
                        this.Controls.Add(boton[i, j]);
                        boton[i,j].ForeColor=Color.White;
                        boton[i, j].Width = 70;
                        boton[i, j].Height = 70;
                        boton[i, j].Location = new Point(x, y);
                        if (NumBoton != 14)
                            boton[i, j].BackColor = Color.White;
                        else
                            boton[i, j].BackColor = Color.DarkGray;
                        x += 70;
                        boton[i, j].Click += new System.EventHandler(this.button_Clicked);
                    }
                    y += 70;
                    x = xPosc;
                }
                xPosc += 210;
                x = xPosc;
                CambiodeTablero += 3;
            }
        }

        //Inicializar forma
        public Gato3D()
        {
            InitializeComponent();
            Home.Visible = false;
            Home.Enabled = false;
            Restart.Visible = false;
            Restart.Enabled = false;
            J1_victorias.Visible = false;
            J2_victorias.Visible = false;
            Turno.Visible = false;
        }

        //Click en botones del gato
        private void button_Clicked(object sender, EventArgs e)
        {
            Button clickd = sender as Button;
            if (clickd.Text != "O" && clickd.Text != "X" && clickd.BackColor != Color.DarkGray)
            {
                if (index % 2 == 0 && Compu == 0)
                {
                    clickd.ForeColor = Color.Green;
                    clickd.Text = "O";
                    index++;
                    JugadorTurn = 1;
                    Jugador.Text = "Jugador: " + JugadorTurn;
                    Turno.Text = "Turno: " + index;
                }
                else if(index % 2 == 1)
                {
                    clickd.ForeColor = Color.Coral;
                    clickd.Text = "X";
                    index++;
                    JugadorTurn = 2;
                    Jugador.Text = "Jugador: " + JugadorTurn;
                    Turno.Text = "Turno: " + index;
                    if (Compu==1 && !condicionGanar())
                    {
                        IA();
                    }
                }
                if(condicionGanar() && index % 2 == 0)
                {
                    MessageBox.Show("Ganó el jugador 1");
                    victoriasJ1++;
                    Reinicio();
                }else if(condicionGanar() && index % 2 == 1)
                {
                    if(Compu==0)
                        MessageBox.Show("Ganó el jugador 2");
                    else
                        MessageBox.Show("Ganó la CPU 🤖");
                    victoriasJ2++;
                    Reinicio();
                }else if (index == 27)
                {
                    MessageBox.Show("!!EMPATE!!");
                    Reinicio();
                }
            }
        }
 
        //Click en jugador vs jugador
        private void PvP_Click(object sender, EventArgs e)
        {
            PvP.Visible = false;
            PvP.Enabled = false;
            PvCPU.Visible = false;
            PvCPU.Enabled = false;
            Exit.Visible = false;
            Exit.Enabled = false;
            Tablero();

        }

        //Click en jugador vs CPU
        private void PvCPU_Click(object sender, EventArgs e)
        {
            PvP.Visible = false;
            PvP.Enabled = false;
            PvCPU.Visible = false;
            PvCPU.Enabled = false;
            Exit.Visible = false;
            Exit.Enabled = false;
            //Bandera
            Compu = 1;
            Tablero();
        }

        //Click en exit
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tresdlab_Click(object sender, EventArgs e)
        {

        }

        //Click en home (dentro del juego)
        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
            Form gato = new Gato3D();
            gato.Show();
        }
        public void Reinicio()
        {
            //Turno 
            Turno.Text = "Turno: 1";

            //Contador de victorias
            J1_victorias.Text = "Puntaje J1: " + victoriasJ1;
            J2_victorias.Text = "Puntaje J2: " + victoriasJ2;

            int CambiodeTablero = 0;
            for (int k = 0; k < 3; k++)
            {
                for (int i = CambiodeTablero; i < (CambiodeTablero + 3); i++)
                {
                    for (int j = CambiodeTablero; j < (CambiodeTablero + 3); j++)
                    {
                        boton[i, j].Text = "";
                        boton[i, j].ForeColor = Color.White;
                    }
                }
                CambiodeTablero += 3;
            }
            index = 1;
            Jugador.Text = "Jugador: 1";

            for(int i = 1; i < 25; i++)
            {
                solucionesHechas[i] = 0;
            }
        }
        //Click en restart (dentro del juego)
        private void Restart_Click(object sender, EventArgs e)
        {
            Reinicio();
        }

        //Comprobar si se puede poner en una fila IA 🤖
        public bool CompFilasIA(string ficha, int k)
        {
            int col0, col1, col2;
            col0 = col1 = col2 = 0;
            if(k==0 || k==1 || k == 2)
            {
                col0 = 0;
                col1 = 1;
                col2 = 2;
            }
            else if(k == 3 || k == 5)
            {
                col0 = 3;
                col1 = 4;
                col2 = 5;
            }
            else
            {
                col0 = 6;
                col1 = 7;
                col2 = 8;
            }

            if ((boton[k, col0].Text == boton[k,col1].Text) && boton[k, col0].Text == ficha && boton[k, col2].Text == "")
            {
                boton[k, col2].Text = "O";
                boton[k, col2].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else if((boton[k, col0].Text == boton[k, col2].Text) && (boton[k, col0].Text == ficha) && (boton[k, col1].Text == ""))
            {
                boton[k, col1].Text = "O";
                boton[k, col1].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else if ((boton[k, col1].Text == boton[k, col2].Text) && (boton[k, col1].Text == ficha) && (boton[k, col0].Text == ""))
            {
                boton[k, col0].Text = "O";
                boton[k, col0].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Comprobar si se puede poner en una fila IA 🤖
        public bool CompColumnasIA(string ficha, int k)
        {
            int fil0, fil1, fil2;
            fil0 = fil1 = fil2 = 0;
            if (k == 0 || k == 1 || k == 2)
            {
                fil0 = 0;
                fil1 = 1;
                fil2 = 2;
            }
            else if (k == 3 || k == 5)
            {
                fil0 = 3;
                fil1 = 4;
                fil2 = 5;
            }
            else
            {
                fil0 = 6;
                fil1 = 7;
                fil2 = 8;
            }

            if ((boton[fil0, k].Text == boton[fil1, k].Text) && boton[fil0, k].Text == ficha && boton[fil2, k].Text == "")
            {
                boton[fil2, k].Text = "O";
                boton[fil2, k].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else if ((boton[fil0, k].Text == boton[fil2, k].Text) && (boton[fil0, k].Text == ficha) && (boton[fil1, k].Text == ""))
            {
                boton[fil1, k].Text = "O";
                boton[fil1, k].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else if ((boton[fil1, k].Text == boton[fil2, k].Text) && (boton[fil1, k].Text == ficha) && (boton[fil0, k].Text == ""))
            {
                boton[fil0, k].Text = "O";
                boton[fil0, k].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Comprobar si se puede poner en una diagonal noroeste-sureste ↘ IA 🤖
        public bool CompDiaNW_SE_IA(string ficha, int k)
        {
            if((boton[k,k].Text== boton[k+1, k+1].Text) && (boton[k, k].Text ==ficha) && (boton[k+2, k+2].Text == ""))
            {
                boton[k+2,k+2].Text = "O";
                boton[k + 2, k + 2].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else if ((boton[k, k].Text == boton[k + 2, k + 2].Text) && (boton[k, k].Text == ficha) && (boton[k + 1, k + 1].Text == ""))
            {
                boton[k + 1, k + 1].Text = "O";
                boton[k + 1, k + 1].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else if ((boton[k+1, k+1].Text == boton[k + 2, k + 2].Text) && (boton[k+1, k+1].Text == ficha) && (boton[k, k].Text == ""))
            {
                boton[k, k].Text = "O";
                boton[k, k].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Comprobar si se puede poner en una diagonal noreste-suroeste ↙ IA 🤖
        public bool CompDiaNE_SW_IA(string ficha, int k)
        {
            if ((boton[k - 2, k].Text == boton[k - 1, k - 1].Text) && (boton[k-2, k].Text == ficha) && (boton[k, k - 2].Text == ""))
            {
                boton[k, k - 2].Text = "O";
                boton[k, k - 2].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else if ((boton[k - 2, k].Text == boton[k, k - 2].Text) && (boton[k-2, k].Text == ficha) && (boton[k - 1, k - 1].Text == ""))
            {
                boton[k - 1, k - 1].Text = "O";
                boton[k - 1, k - 1].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else if ((boton[k - 1, k - 1].Text == boton[k, k - 2].Text) && (boton[k - 1, k - 1].Text == ficha) && (boton[k-2, k].Text == ""))
            {
                boton[k-2, k].Text = "O";
                boton[k-2, k].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Comprobar si se puede poner en 1, 11, 21 IA 🤖
        public bool Solucion3D_1(string ficha)
        {
            if((boton[0,0].Text==boton[3,4].Text) && (boton[0, 0].Text == ficha) && (boton[6, 8].Text == ""))
            {
                boton[6, 8].Text = "O";
                boton[6, 8].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else if((boton[0, 0].Text == boton[6, 8].Text) && (boton[0, 0].Text == ficha) && (boton[3, 4].Text == ""))
            {
                boton[3, 4].Text = "O";
                boton[3, 4].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else if((boton[3, 4].Text == boton[6, 8].Text) && (boton[3, 4].Text == ficha) && (boton[0, 0].Text == ""))
            {
                boton[0, 0].Text = "O";
                boton[0, 0].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Comprobar si se puede poner en 1, 13, 25 IA 🤖
        public bool Solucion3D_2(string ficha)
        {
            if ((boton[0, 0].Text == boton[4, 3].Text) && (boton[0, 0].Text == ficha) && (boton[8, 6].Text == ""))
            {
                boton[8, 6].Text = "O";
                boton[8, 6].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else if ((boton[0, 0].Text == boton[8, 6].Text) && (boton[0, 0].Text == ficha) && (boton[4, 3].Text == ""))
            {
                boton[4, 3].Text = "O";
                boton[4, 3].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else if ((boton[4, 3].Text == boton[8, 6].Text) && (boton[4, 3].Text == ficha) && (boton[0, 0].Text == ""))
            {
                boton[0, 0].Text = "O";
                boton[0, 0].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Comprobar si se puede poner en 3, 15, 27 IA 🤖
        public bool Solucion3D_3(string ficha)
        {
            if ((boton[0, 2].Text == boton[4, 5].Text) && (boton[0, 2].Text == ficha) && (boton[8, 8].Text == ""))
            {
                boton[8, 8].Text = "O";
                boton[8, 8].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else if ((boton[0, 2].Text == boton[8, 8].Text) && (boton[0, 2].Text == ficha) && (boton[4, 5].Text == ""))
            {
                boton[4, 5].Text = "O";
                boton[4, 5].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else if ((boton[4, 5].Text == boton[8, 8].Text) && (boton[4, 5].Text == ficha) && (boton[0, 2].Text == ""))
            {
                boton[0, 2].Text = "O";
                boton[0, 2].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Comprobar si se puede poner en 7, 17, 27 IA 🤖
        public bool Solucion3D_4(string ficha)
        {
            if ((boton[2, 0].Text == boton[5, 4].Text) && (boton[2, 0].Text == ficha) && (boton[8, 8].Text == ""))
            {
                boton[8, 8].Text = "O";
                boton[8, 8].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else if ((boton[2, 0].Text == boton[8, 8].Text) && (boton[2, 0].Text == ficha) && (boton[5, 4].Text == ""))
            {
                boton[5, 4].Text = "O";
                boton[5, 4].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else if ((boton[5, 4].Text == boton[8, 8].Text) && (boton[5, 4].Text == ficha) && (boton[2, 0].Text == ""))
            {
                boton[2, 0].Text = "O";
                boton[2, 0].ForeColor = Color.Green;
                FichaPuestaIA = 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Posicionar la ficha IA 🤖
        public void FichaIA(string ficha)
        {
            //Comprobar soluciones filas
            if (!CompFilasIA(ficha, 0))
                if (!CompFilasIA(ficha, 1))
                    if (!CompFilasIA(ficha, 2))
                        if (!CompFilasIA(ficha, 3))
                            if (!CompFilasIA(ficha, 5))
                                if (!CompFilasIA(ficha, 6))
                                    if (!CompFilasIA(ficha, 7))
                                        if (!CompFilasIA(ficha, 8))

            //Comprobar soluciones columnas
            if (!CompColumnasIA(ficha, 0))
                if (!CompColumnasIA(ficha, 1))
                    if (!CompColumnasIA(ficha, 2))
                        if (!CompColumnasIA(ficha, 3))
                            if (!CompColumnasIA(ficha, 5))
                                if (!CompColumnasIA(ficha, 6))
                                    if (!CompColumnasIA(ficha, 7))
                                        if (!CompColumnasIA(ficha, 8))
            
            //Comprobar soluciones diagonal ↘
            if (!CompDiaNW_SE_IA(ficha, 0))
                if (!CompDiaNW_SE_IA(ficha, 6))

            //Comprobar soluciones diagonal ↙
            if (!CompDiaNE_SW_IA(ficha, 2))
                if (!CompDiaNE_SW_IA(ficha, 8))

            //Comprobar soluciones 3D
            if (!Solucion3D_1(ficha))
                if (!Solucion3D_2(ficha))
                    if (!Solucion3D_3(ficha))
                        if (!Solucion3D_4(ficha))
                            FichaPuestaIA =0;
        }

        //Poner ficha aleatoria IA 🤖
        public void AleatorioIA()
        {
            Random rand= new Random();
            int posx, posy;

            do
            {
                posx = rand.Next(0, 9);
                switch (posx)
                {
                    case 0:
                    case 1:
                    case 2:
                        posy = rand.Next(0, 3);
                        break;
                    case 3:
                    case 4:
                    case 5:
                        posy = rand.Next(3, 6);
                        break;
                    default:
                        posy = rand.Next(6, 9);
                        break;
                }
                
            } while (boton[posy, posx].ForeColor != Color.White || boton[posy, posx].BackColor==Color.DarkGray);

            boton[posy, posx].ForeColor = Color.Green;
            boton[posy, posx].Text = "O";
            FichaPuestaIA = 1;
        }

        //IA 🤖
        public void IA()
        {

            if (index == 4)
            {
                FichaIA("X"); //Bloquear
                if (FichaPuestaIA == 0)
                    AleatorioIA();
            }
            else if (index > 4)
            {
                FichaIA("O"); //Ganar
                if (FichaPuestaIA == 0)
                {
                    FichaIA("X"); //Bloquear
                    if (FichaPuestaIA == 0)
                        AleatorioIA();
                }
            }
            else
                AleatorioIA();

            index++;
            JugadorTurn = 1;
            Jugador.Text = "Jugador: " + JugadorTurn;
        }

        public bool condicionGanar()
        {   //matriz 1: horizontal 1
            if (boton[0, 0].ForeColor == boton[0, 1].ForeColor && boton[0, 1].ForeColor == boton[0, 2].ForeColor && boton[0, 0].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 1: horizontal 2
            else if (boton[1, 0].ForeColor == boton[1, 1].ForeColor && boton[1, 1].ForeColor == boton[1, 2].ForeColor && boton[1, 0].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 1: horizontal 3
            else if (boton[2, 0].ForeColor == boton[2, 1].ForeColor && boton[2, 1].ForeColor == boton[2, 2].ForeColor && boton[2, 0].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 1: vertical 1
            else if (boton[0, 0].ForeColor == boton[1, 0].ForeColor && boton[1, 0].ForeColor == boton[2, 0].ForeColor && boton[0, 0].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 1: vertical 2
            else if (boton[0, 1].ForeColor == boton[1, 1].ForeColor && boton[1, 1].ForeColor == boton[2, 1].ForeColor && boton[0, 1].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 1: vertical 3
            else if (boton[0, 2].ForeColor == boton[1, 2].ForeColor && boton[1, 2].ForeColor == boton[2, 2].ForeColor && boton[0, 2].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 1: diagonal abajo
            else if (boton[0, 0].ForeColor == boton[1, 1].ForeColor && boton[1, 1].ForeColor == boton[2, 2].ForeColor && boton[0, 0].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 1: diagonal arriba
            else if (boton[2, 0].ForeColor == boton[1, 1].ForeColor && boton[1, 1].ForeColor == boton[0, 2].ForeColor && boton[2, 0].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 3: horizontal 1
            if (boton[6, 6].ForeColor == boton[6, 7].ForeColor && boton[6, 7].ForeColor == boton[6, 8].ForeColor && boton[6, 6].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 3: horizontal 2
            else if (boton[7, 6].ForeColor == boton[7,7].ForeColor && boton[7,7].ForeColor == boton[7,8].ForeColor && boton[7,7].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 3: horizontal 3
            else if (boton[8,6].ForeColor == boton[8,7].ForeColor && boton[8,7].ForeColor == boton[8,8].ForeColor && boton[8,8].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 3: vertical 1
            else if (boton[6,6].ForeColor == boton[7,6].ForeColor && boton[7,6].ForeColor == boton[8,6].ForeColor && boton[6,6].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 3: vertical 2
            else if (boton[6,7].ForeColor == boton[7,7].ForeColor && boton[6,7].ForeColor == boton[8,7].ForeColor && boton[7,7].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 3: vertical 3
            else if (boton[6,8].ForeColor == boton[7,8].ForeColor && boton[6,8].ForeColor == boton[8,8].ForeColor && boton[8,8].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 3: diagonal abajo
            else if (boton[6,6].ForeColor == boton[7,7].ForeColor && boton[7,7].ForeColor == boton[8,8].ForeColor && boton[6,6].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 3: diagonal arriba
            else if (boton[8,6].ForeColor == boton[7,7].ForeColor && boton[7,7].ForeColor == boton[6,8].ForeColor && boton[7,7].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 2: horizontal 1
            else if (boton[3,3].ForeColor == boton[3,4].ForeColor && boton[3,3].ForeColor == boton[3,5].ForeColor && boton[3,3].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 2: horizontal 3
            else if (boton[5,3].ForeColor == boton[5,4].ForeColor && boton[5,4].ForeColor == boton[5,5].ForeColor && boton[5,5].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 2: vertical 1
            else if (boton[3,3].ForeColor == boton[4,3].ForeColor && boton[3,3].ForeColor == boton[5,3].ForeColor && boton[3,3].ForeColor != Color.White)
            {
                return true;
            }
            //matriz 2: vertical 3
            else if (boton[3, 5].ForeColor == boton[4, 5].ForeColor && boton[4,5].ForeColor == boton[5, 5].ForeColor && boton[5,5].ForeColor != Color.White)
            {
                return true;
            }
            //multimatriz loca 1
            else if (boton[0,0].ForeColor == boton[3,4].ForeColor && boton[3,4].ForeColor == boton[6,8].ForeColor && boton[0,0].ForeColor != Color.White)
            {
                return true;
            }
            //multimatriz loca 2
            else if (boton[0, 0].ForeColor == boton[4,3].ForeColor && boton[4,3].ForeColor == boton[8,6].ForeColor && boton[0, 0].ForeColor != Color.White)
            {
                return true;
            }
            //multimatriz loca 3
            else if (boton[0, 2].ForeColor == boton[4, 5].ForeColor && boton[4, 5].ForeColor == boton[8, 8].ForeColor && boton[8,8].ForeColor != Color.White)
            {
                return true;
            }
            //multimatriz loca 4
            else if (boton[2,0].ForeColor == boton[5,4].ForeColor && boton[5,4].ForeColor == boton[8, 8].ForeColor && boton[8, 8].ForeColor != Color.White)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
