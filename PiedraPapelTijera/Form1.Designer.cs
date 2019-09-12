namespace PiedraPapelTijera
{
    partial class FrmPiedraPapelTijera
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
            this.LblJugador = new System.Windows.Forms.Label();
            this.LblComputadora = new System.Windows.Forms.Label();
            this.ImgJugador = new System.Windows.Forms.PictureBox();
            this.ImgComputadora = new System.Windows.Forms.PictureBox();
            this.CmdPiedra = new System.Windows.Forms.Button();
            this.CmdPapel = new System.Windows.Forms.Button();
            this.CmdTijera = new System.Windows.Forms.Button();
            this.LblResultado = new System.Windows.Forms.Label();
            this.LblJugadorScore = new System.Windows.Forms.Label();
            this.LblComputadoraScore = new System.Windows.Forms.Label();
            this.LblScore1 = new System.Windows.Forms.Label();
            this.LblScore2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgJugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgComputadora)).BeginInit();
            this.SuspendLayout();
            // 
            // LblJugador
            // 
            this.LblJugador.AutoSize = true;
            this.LblJugador.Location = new System.Drawing.Point(140, 42);
            this.LblJugador.Name = "LblJugador";
            this.LblJugador.Size = new System.Drawing.Size(45, 13);
            this.LblJugador.TabIndex = 0;
            this.LblJugador.Text = "Jugador";
            // 
            // LblComputadora
            // 
            this.LblComputadora.AutoSize = true;
            this.LblComputadora.Location = new System.Drawing.Point(392, 42);
            this.LblComputadora.Name = "LblComputadora";
            this.LblComputadora.Size = new System.Drawing.Size(70, 13);
            this.LblComputadora.TabIndex = 1;
            this.LblComputadora.Text = "Computadora";
            // 
            // ImgJugador
            // 
            this.ImgJugador.Image = global::PiedraPapelTijera.Properties.Resources.Titulo;
            this.ImgJugador.Location = new System.Drawing.Point(91, 72);
            this.ImgJugador.Name = "ImgJugador";
            this.ImgJugador.Size = new System.Drawing.Size(147, 156);
            this.ImgJugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgJugador.TabIndex = 2;
            this.ImgJugador.TabStop = false;
            // 
            // ImgComputadora
            // 
            this.ImgComputadora.Image = global::PiedraPapelTijera.Properties.Resources.Titulo;
            this.ImgComputadora.Location = new System.Drawing.Point(354, 72);
            this.ImgComputadora.Name = "ImgComputadora";
            this.ImgComputadora.Size = new System.Drawing.Size(147, 156);
            this.ImgComputadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgComputadora.TabIndex = 2;
            this.ImgComputadora.TabStop = false;
            // 
            // CmdPiedra
            // 
            this.CmdPiedra.Location = new System.Drawing.Point(122, 291);
            this.CmdPiedra.Name = "CmdPiedra";
            this.CmdPiedra.Size = new System.Drawing.Size(91, 37);
            this.CmdPiedra.TabIndex = 3;
            this.CmdPiedra.Text = "Piedra";
            this.CmdPiedra.UseVisualStyleBackColor = true;
            this.CmdPiedra.Click += new System.EventHandler(this.CmdPiedra_Click);
            // 
            // CmdPapel
            // 
            this.CmdPapel.Location = new System.Drawing.Point(252, 291);
            this.CmdPapel.Name = "CmdPapel";
            this.CmdPapel.Size = new System.Drawing.Size(91, 37);
            this.CmdPapel.TabIndex = 3;
            this.CmdPapel.Text = "Papel";
            this.CmdPapel.UseVisualStyleBackColor = true;
            this.CmdPapel.Click += new System.EventHandler(this.CmdPapel_Click);
            // 
            // CmdTijera
            // 
            this.CmdTijera.Location = new System.Drawing.Point(371, 291);
            this.CmdTijera.Name = "CmdTijera";
            this.CmdTijera.Size = new System.Drawing.Size(91, 37);
            this.CmdTijera.TabIndex = 3;
            this.CmdTijera.Text = "Tijera";
            this.CmdTijera.UseVisualStyleBackColor = true;
            this.CmdTijera.Click += new System.EventHandler(this.CmdTijera_Click);
            // 
            // LblResultado
            // 
            this.LblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(91, 351);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(410, 45);
            this.LblResultado.TabIndex = 4;
            this.LblResultado.Text = "Resultado";
            this.LblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblJugadorScore
            // 
            this.LblJugadorScore.AutoSize = true;
            this.LblJugadorScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJugadorScore.Location = new System.Drawing.Point(87, 434);
            this.LblJugadorScore.Name = "LblJugadorScore";
            this.LblJugadorScore.Size = new System.Drawing.Size(71, 20);
            this.LblJugadorScore.TabIndex = 5;
            this.LblJugadorScore.Text = "Jugador:";
            // 
            // LblComputadoraScore
            // 
            this.LblComputadoraScore.AutoSize = true;
            this.LblComputadoraScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComputadoraScore.Location = new System.Drawing.Point(87, 473);
            this.LblComputadoraScore.Name = "LblComputadoraScore";
            this.LblComputadoraScore.Size = new System.Drawing.Size(110, 20);
            this.LblComputadoraScore.TabIndex = 5;
            this.LblComputadoraScore.Text = "Computadora:";
            // 
            // LblScore1
            // 
            this.LblScore1.AutoSize = true;
            this.LblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore1.Location = new System.Drawing.Point(391, 434);
            this.LblScore1.Name = "LblScore1";
            this.LblScore1.Size = new System.Drawing.Size(18, 20);
            this.LblScore1.TabIndex = 6;
            this.LblScore1.Text = "0";
            this.LblScore1.Click += new System.EventHandler(this.LblScore1_Click);
            // 
            // LblScore2
            // 
            this.LblScore2.AutoSize = true;
            this.LblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore2.Location = new System.Drawing.Point(391, 473);
            this.LblScore2.Name = "LblScore2";
            this.LblScore2.Size = new System.Drawing.Size(18, 20);
            this.LblScore2.TabIndex = 6;
            this.LblScore2.Text = "0";
            this.LblScore2.Click += new System.EventHandler(this.LblScore1_Click);
            // 
            // FrmPiedraPapelTijera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 542);
            this.Controls.Add(this.LblScore2);
            this.Controls.Add(this.LblScore1);
            this.Controls.Add(this.LblComputadoraScore);
            this.Controls.Add(this.LblJugadorScore);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.CmdTijera);
            this.Controls.Add(this.CmdPapel);
            this.Controls.Add(this.CmdPiedra);
            this.Controls.Add(this.ImgComputadora);
            this.Controls.Add(this.ImgJugador);
            this.Controls.Add(this.LblComputadora);
            this.Controls.Add(this.LblJugador);
            this.Name = "FrmPiedraPapelTijera";
            this.Text = "Piedra, papel o tijera";
            ((System.ComponentModel.ISupportInitialize)(this.ImgJugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgComputadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblJugador;
        private System.Windows.Forms.Label LblComputadora;
        private System.Windows.Forms.PictureBox ImgJugador;
        private System.Windows.Forms.PictureBox ImgComputadora;
        private System.Windows.Forms.Button CmdPiedra;
        private System.Windows.Forms.Button CmdPapel;
        private System.Windows.Forms.Button CmdTijera;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblJugadorScore;
        private System.Windows.Forms.Label LblComputadoraScore;
        private System.Windows.Forms.Label LblScore1;
        private System.Windows.Forms.Label LblScore2;
    }
}

