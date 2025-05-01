namespace FormsGraficos
{
    partial class LanzamientoHorizontal
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
            ptbDibujo = new PictureBox();
            btnIniciar = new Button();
            btnPausarReanudar = new Button();
            btnReiniciar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtAlturaInicial = new TextBox();
            txtVelocidadInicial = new TextBox();
            btnAplicarParametros = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbDibujo).BeginInit();
            SuspendLayout();
            // 
            // ptbDibujo
            // 
            ptbDibujo.Dock = DockStyle.Fill;
            ptbDibujo.Location = new Point(0, 0);
            ptbDibujo.Name = "ptbDibujo";
            ptbDibujo.Size = new Size(800, 450);
            ptbDibujo.TabIndex = 0;
            ptbDibujo.TabStop = false;
            ptbDibujo.Paint += ptbDibujo_Paint;
            // 
            // btnIniciar
            // 
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.Location = new Point(590, 119);
            btnIniciar.Margin = new Padding(1);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(51, 23);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnPausarReanudar
            // 
            btnPausarReanudar.Cursor = Cursors.Hand;
            btnPausarReanudar.Enabled = false;
            btnPausarReanudar.Location = new Point(647, 119);
            btnPausarReanudar.Name = "btnPausarReanudar";
            btnPausarReanudar.Size = new Size(72, 23);
            btnPausarReanudar.TabIndex = 2;
            btnPausarReanudar.Text = "Pausar";
            btnPausarReanudar.UseVisualStyleBackColor = true;
            btnPausarReanudar.Click += btnPausarReanudar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = SystemColors.Control;
            btnReiniciar.Cursor = Cursors.Hand;
            btnReiniciar.Location = new Point(725, 119);
            btnReiniciar.Margin = new Padding(0);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(66, 23);
            btnReiniciar.TabIndex = 3;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(575, 15);
            label1.Name = "label1";
            label1.Size = new Size(107, 17);
            label1.TabIndex = 4;
            label1.Text = "Altura inicial (px):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(541, 46);
            label2.Name = "label2";
            label2.Size = new Size(141, 17);
            label2.TabIndex = 5;
            label2.Text = "Velocidad inicial (px/s):";
            // 
            // txtAlturaInicial
            // 
            txtAlturaInicial.Location = new Point(688, 12);
            txtAlturaInicial.Name = "txtAlturaInicial";
            txtAlturaInicial.Size = new Size(100, 25);
            txtAlturaInicial.TabIndex = 6;
            // 
            // txtVelocidadInicial
            // 
            txtVelocidadInicial.Location = new Point(688, 43);
            txtVelocidadInicial.Name = "txtVelocidadInicial";
            txtVelocidadInicial.Size = new Size(100, 25);
            txtVelocidadInicial.TabIndex = 7;
            // 
            // btnAplicarParametros
            // 
            btnAplicarParametros.Location = new Point(708, 74);
            btnAplicarParametros.Name = "btnAplicarParametros";
            btnAplicarParametros.Size = new Size(60, 32);
            btnAplicarParametros.TabIndex = 8;
            btnAplicarParametros.Text = "Aplicar";
            btnAplicarParametros.UseVisualStyleBackColor = true;
            btnAplicarParametros.Click += btnAplicarParametros_Click;
            // 
            // LanzamientoHorizontal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAplicarParametros);
            Controls.Add(txtVelocidadInicial);
            Controls.Add(txtAlturaInicial);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnReiniciar);
            Controls.Add(btnPausarReanudar);
            Controls.Add(btnIniciar);
            Controls.Add(ptbDibujo);
            Name = "LanzamientoHorizontal";
            Text = "LanzamientoHorizontal";
            ((System.ComponentModel.ISupportInitialize)ptbDibujo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbDibujo;
        private Button btnIniciar;
        private Button btnPausarReanudar;
        private Button btnReiniciar;
        private Label label1;
        private Label label2;
        private TextBox txtAlturaInicial;
        private TextBox txtVelocidadInicial;
        private Button btnAplicarParametros;
    }
}