namespace Proyecto_Menus
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void piedraPapelOTijeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PiePapTij = new PPT();
            PiePapTij.Show();
        }

        private void romanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Roman = new Romanos();
            Roman.Show();
        }

        private void leyendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Leyen = new Leyenda();
            Leyen.Show();
        }

        private void gatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Gato = new Gato3D();
            Gato.Show();
        }

        private void tiendaYEnvíosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form calend = new EnvCalen();
            calend.Show();
        }

        private void cualquierBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form basen = new CualquierBase();
            basen.Show();
        }

        private void mayaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form maya = new Maya();
            maya.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form quienessomos = new Quienes_Somos();
            quienessomos.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Calculadora = new Calculadora();
            Calculadora.Show();
        }
    }
}