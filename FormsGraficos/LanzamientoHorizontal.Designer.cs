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
            btnIniciar.Location = new Point(587, 12);
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
            btnPausarReanudar.Location = new Point(644, 12);
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
            btnReiniciar.Location = new Point(722, 12);
            btnReiniciar.Margin = new Padding(0);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(66, 23);
            btnReiniciar.TabIndex = 3;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // LanzamientoHorizontal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReiniciar);
            Controls.Add(btnPausarReanudar);
            Controls.Add(btnIniciar);
            Controls.Add(ptbDibujo);
            Name = "LanzamientoHorizontal";
            Text = "LanzamientoHorizontal";
            ((System.ComponentModel.ISupportInitialize)ptbDibujo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptbDibujo;
        private Button btnIniciar;
        private Button btnPausarReanudar;
        private Button btnReiniciar;
    }
}