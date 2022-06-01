namespace Proyecto_Menus
{
    partial class Leyenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numtexto = new System.Windows.Forms.TextBox();
            this.numorig = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(292, 97);
            this.OK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(88, 27);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(163, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "El numero en letras es igual a: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Honeydew;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(119, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa una cantidad escrita en numeros";
            // 
            // numtexto
            // 
            this.numtexto.Location = new System.Drawing.Point(14, 163);
            this.numtexto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numtexto.Name = "numtexto";
            this.numtexto.ReadOnly = true;
            this.numtexto.Size = new System.Drawing.Size(650, 23);
            this.numtexto.TabIndex = 3;
            // 
            // numorig
            // 
            this.numorig.Location = new System.Drawing.Point(276, 61);
            this.numorig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numorig.Name = "numorig";
            this.numorig.Size = new System.Drawing.Size(116, 23);
            this.numorig.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Leyenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Proyecto_Menus.Properties.Resources.sky_green_clear_white_wallpaper_preview;
            this.ClientSize = new System.Drawing.Size(679, 201);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numorig);
            this.Controls.Add(this.numtexto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Leyenda";
            this.Text = "Convertidor de decimal a texto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numtexto;
        private System.Windows.Forms.TextBox numorig;
        private Button button1;
    }
}

