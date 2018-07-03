namespace Examen
{
    partial class Bienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenida));
            this.label1 = new System.Windows.Forms.Label();
            this.button_PartidaNueva = new System.Windows.Forms.Button();
            this.button_Posiciones = new System.Windows.Forms.Button();
            this.button_partidasGuardadas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Bienvenido!";
            // 
            // button_PartidaNueva
            // 
            this.button_PartidaNueva.BackColor = System.Drawing.Color.Blue;
            this.button_PartidaNueva.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PartidaNueva.Location = new System.Drawing.Point(280, 191);
            this.button_PartidaNueva.Name = "button_PartidaNueva";
            this.button_PartidaNueva.Size = new System.Drawing.Size(228, 43);
            this.button_PartidaNueva.TabIndex = 1;
            this.button_PartidaNueva.Text = "Partida Nueva";
            this.button_PartidaNueva.UseVisualStyleBackColor = false;
            this.button_PartidaNueva.Click += new System.EventHandler(this.button_PartidaNueva_Click);
            // 
            // button_Posiciones
            // 
            this.button_Posiciones.BackColor = System.Drawing.Color.Blue;
            this.button_Posiciones.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Posiciones.Location = new System.Drawing.Point(280, 289);
            this.button_Posiciones.Name = "button_Posiciones";
            this.button_Posiciones.Size = new System.Drawing.Size(228, 43);
            this.button_Posiciones.TabIndex = 2;
            this.button_Posiciones.Text = "Tabla Posiciones";
            this.button_Posiciones.UseVisualStyleBackColor = false;
            this.button_Posiciones.Click += new System.EventHandler(this.button_Posiciones_Click);
            // 
            // button_partidasGuardadas
            // 
            this.button_partidasGuardadas.BackColor = System.Drawing.Color.Blue;
            this.button_partidasGuardadas.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_partidasGuardadas.Location = new System.Drawing.Point(280, 240);
            this.button_partidasGuardadas.Name = "button_partidasGuardadas";
            this.button_partidasGuardadas.Size = new System.Drawing.Size(228, 43);
            this.button_partidasGuardadas.TabIndex = 3;
            this.button_partidasGuardadas.Text = "Partidas Guardadas";
            this.button_partidasGuardadas.UseVisualStyleBackColor = false;
            this.button_partidasGuardadas.Click += new System.EventHandler(this.button_partidasGuardadas_Click);
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_partidasGuardadas);
            this.Controls.Add(this.button_Posiciones);
            this.Controls.Add(this.button_PartidaNueva);
            this.Controls.Add(this.label1);
            this.Name = "Bienvenida";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_PartidaNueva;
        private System.Windows.Forms.Button button_Posiciones;
        private System.Windows.Forms.Button button_partidasGuardadas;
    }
}

