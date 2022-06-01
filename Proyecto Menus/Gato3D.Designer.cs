namespace Proyecto_Menus
{
    partial class Gato3D
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Jugador = new System.Windows.Forms.Label();
            this.PvP = new System.Windows.Forms.Button();
            this.PvCPU = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.gatolab = new System.Windows.Forms.Label();
            this.tresdlab = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.J1_victorias = new System.Windows.Forms.Label();
            this.J2_victorias = new System.Windows.Forms.Label();
            this.Turno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Jugador
            // 
            this.Jugador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Jugador.AutoSize = true;
            this.Jugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Jugador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Jugador.Location = new System.Drawing.Point(611, 12);
            this.Jugador.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Jugador.Name = "Jugador";
            this.Jugador.Size = new System.Drawing.Size(152, 31);
            this.Jugador.TabIndex = 0;
            this.Jugador.Text = "Jugador: 1";
            this.Jugador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Jugador.Visible = false;
            // 
            // PvP
            // 
            this.PvP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PvP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PvP.Location = new System.Drawing.Point(573, 122);
            this.PvP.Name = "PvP";
            this.PvP.Size = new System.Drawing.Size(160, 62);
            this.PvP.TabIndex = 1;
            this.PvP.Text = "Player vs. Player ";
            this.PvP.UseVisualStyleBackColor = true;
            this.PvP.Click += new System.EventHandler(this.PvP_Click);
            // 
            // PvCPU
            // 
            this.PvCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PvCPU.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PvCPU.Location = new System.Drawing.Point(573, 215);
            this.PvCPU.Name = "PvCPU";
            this.PvCPU.Size = new System.Drawing.Size(160, 62);
            this.PvCPU.TabIndex = 2;
            this.PvCPU.Text = "Player vs. CPU";
            this.PvCPU.UseVisualStyleBackColor = true;
            this.PvCPU.Click += new System.EventHandler(this.PvCPU_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit.Location = new System.Drawing.Point(573, 312);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(160, 62);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // gatolab
            // 
            this.gatolab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gatolab.AutoSize = true;
            this.gatolab.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gatolab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gatolab.Location = new System.Drawing.Point(595, 50);
            this.gatolab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gatolab.Name = "gatolab";
            this.gatolab.Size = new System.Drawing.Size(132, 55);
            this.gatolab.TabIndex = 4;
            this.gatolab.Text = "Gato";
            // 
            // tresdlab
            // 
            this.tresdlab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tresdlab.AutoSize = true;
            this.tresdlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tresdlab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tresdlab.Location = new System.Drawing.Point(722, 50);
            this.tresdlab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tresdlab.Name = "tresdlab";
            this.tresdlab.Size = new System.Drawing.Size(88, 55);
            this.tresdlab.TabIndex = 5;
            this.tresdlab.Text = "3D";
            this.tresdlab.Click += new System.EventHandler(this.tresdlab_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Home.ForeColor = System.Drawing.Color.Transparent;
            this.Home.Image = global::Proyecto_Menus.Properties.Resources.home;
            this.Home.Location = new System.Drawing.Point(1220, 60);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(70, 52);
            this.Home.TabIndex = 7;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Visible = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.Transparent;
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Restart.ForeColor = System.Drawing.Color.Transparent;
            this.Restart.Image = global::Proyecto_Menus.Properties.Resources.restart;
            this.Restart.Location = new System.Drawing.Point(1144, 60);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(70, 52);
            this.Restart.TabIndex = 6;
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // J1_victorias
            // 
            this.J1_victorias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.J1_victorias.AutoSize = true;
            this.J1_victorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.J1_victorias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.J1_victorias.Location = new System.Drawing.Point(102, 12);
            this.J1_victorias.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.J1_victorias.Name = "J1_victorias";
            this.J1_victorias.Size = new System.Drawing.Size(161, 31);
            this.J1_victorias.TabIndex = 8;
            this.J1_victorias.Text = "Puntaje J1:";
            this.J1_victorias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.J1_victorias.Visible = false;
            // 
            // J2_victorias
            // 
            this.J2_victorias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.J2_victorias.AutoSize = true;
            this.J2_victorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.J2_victorias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.J2_victorias.Location = new System.Drawing.Point(354, 12);
            this.J2_victorias.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.J2_victorias.Name = "J2_victorias";
            this.J2_victorias.Size = new System.Drawing.Size(161, 31);
            this.J2_victorias.TabIndex = 9;
            this.J2_victorias.Text = "Puntaje J2:";
            this.J2_victorias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.J2_victorias.Visible = false;
            // 
            // Turno
            // 
            this.Turno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Turno.AutoSize = true;
            this.Turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Turno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Turno.Location = new System.Drawing.Point(830, 12);
            this.Turno.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Turno.Name = "Turno";
            this.Turno.Size = new System.Drawing.Size(123, 31);
            this.Turno.TabIndex = 11;
            this.Turno.Text = "Turno: 1";
            this.Turno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Turno.Visible = false;
            // 
            // Gato3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.Turno);
            this.Controls.Add(this.J2_victorias);
            this.Controls.Add(this.J1_victorias);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.tresdlab);
            this.Controls.Add(this.gatolab);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PvCPU);
            this.Controls.Add(this.PvP);
            this.Controls.Add(this.Jugador);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Gato3D";
            this.ShowIcon = false;
            this.Text = "Gato3D";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Jugador;
        private System.Windows.Forms.Button PvP;
        private System.Windows.Forms.Button PvCPU;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label gatolab;
        private System.Windows.Forms.Label tresdlab;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label J1_victorias;
        private System.Windows.Forms.Label J2_victorias;
        private System.Windows.Forms.Label Turno;
    }
}

