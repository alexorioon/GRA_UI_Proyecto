namespace FormsGraficos
{
    partial class FrmGraphics2D
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controles de la UI
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox listBoxFiguras;
        private System.Windows.Forms.DataGridView dataGridViewCoord;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown numericDx;
        private System.Windows.Forms.NumericUpDown numericDy;
        private System.Windows.Forms.Button btnTrasladar;
        private System.Windows.Forms.NumericUpDown numericSx;
        private System.Windows.Forms.NumericUpDown numericSy;
        private System.Windows.Forms.CheckBox checkBoxFijo;
        private System.Windows.Forms.NumericUpDown numericFx;
        private System.Windows.Forms.NumericUpDown numericFy;
        private System.Windows.Forms.Button btnEscalar;
        private System.Windows.Forms.NumericUpDown numericAng;
        private System.Windows.Forms.Button btnRotar;
        private System.Windows.Forms.RadioButton radioX;
        private System.Windows.Forms.RadioButton radioY;
        private System.Windows.Forms.RadioButton radioOrig;
        private System.Windows.Forms.Button btnReflejar;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            panelDibujo = new Panel();
            btnColor = new Button();
            btnLimpiar = new Button();
            listBoxFiguras = new ListBox();
            dataGridViewCoord = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            colorDialog1 = new ColorDialog();
            numericDx = new NumericUpDown();
            numericDy = new NumericUpDown();
            btnTrasladar = new Button();
            numericSx = new NumericUpDown();
            numericSy = new NumericUpDown();
            checkBoxFijo = new CheckBox();
            numericFx = new NumericUpDown();
            numericFy = new NumericUpDown();
            btnEscalar = new Button();
            numericAng = new NumericUpDown();
            btnRotar = new Button();
            radioX = new RadioButton();
            radioY = new RadioButton();
            radioOrig = new RadioButton();
            btnReflejar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            lblCoordenadas = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericFx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericFy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAng).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panelDibujo
            // 
            panelDibujo.BackColor = Color.White;
            panelDibujo.BorderStyle = BorderStyle.FixedSingle;
            panelDibujo.Location = new Point(14, 14);
            panelDibujo.Margin = new Padding(4, 3, 4, 3);
            panelDibujo.Name = "panelDibujo";
            panelDibujo.Size = new Size(1033, 500);
            panelDibujo.TabIndex = 0;
            panelDibujo.Paint += panelDibujo_Paint;
            panelDibujo.MouseMove += panelDibujo_MouseMove;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(581, 553);
            btnColor.Margin = new Padding(4, 3, 4, 3);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(117, 27);
            btnColor.TabIndex = 1;
            btnColor.Text = "Seleccionar Color";
            btnColor.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(581, 520);
            btnLimpiar.Margin = new Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(117, 27);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar Plano";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // listBoxFiguras
            // 
            listBoxFiguras.FormattingEnabled = true;
            listBoxFiguras.ItemHeight = 15;
            listBoxFiguras.Location = new Point(564, 584);
            listBoxFiguras.Margin = new Padding(4, 3, 4, 3);
            listBoxFiguras.Name = "listBoxFiguras";
            listBoxFiguras.Size = new Size(150, 154);
            listBoxFiguras.TabIndex = 3;
            // 
            // dataGridViewCoord
            // 
            dataGridViewCoord.AllowUserToAddRows = false;
            dataGridViewCoord.AllowUserToDeleteRows = false;
            dataGridViewCoord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCoord.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewCoord.Location = new Point(13, 520);
            dataGridViewCoord.Margin = new Padding(4, 3, 4, 3);
            dataGridViewCoord.Name = "dataGridViewCoord";
            dataGridViewCoord.ReadOnly = true;
            dataGridViewCoord.Size = new Size(543, 218);
            dataGridViewCoord.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Name = "Puntos";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Name = "X";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.Name = "Y";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.Name = "New X";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.Name = "New Y";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // numericDx
            // 
            numericDx.Location = new Point(30, 20);
            numericDx.Margin = new Padding(4, 3, 4, 3);
            numericDx.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericDx.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numericDx.Name = "numericDx";
            numericDx.Size = new Size(70, 23);
            numericDx.TabIndex = 14;
            numericDx.Maximum = 100;
            numericDx.Minimum = -100;
            // 
            // numericDy
            // 
            numericDy.Location = new Point(137, 20);
            numericDy.Margin = new Padding(4, 3, 4, 3);
            numericDy.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericDy.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numericDy.Name = "numericDy";
            numericDy.Size = new Size(70, 23);
            numericDy.TabIndex = 13;
            numericDy.Maximum = 100;
            numericDy.Minimum = -100;
            // 
            // btnTrasladar
            // 
            btnTrasladar.Location = new Point(215, 18);
            btnTrasladar.Margin = new Padding(4, 3, 4, 3);
            btnTrasladar.Name = "btnTrasladar";
            btnTrasladar.Size = new Size(88, 27);
            btnTrasladar.TabIndex = 12;
            btnTrasladar.Text = "Trasladar";
            // 
            // numericSx
            // 
            numericSx.Location = new Point(39, 48);
            numericSx.Margin = new Padding(4, 3, 4, 3);
            numericSx.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericSx.Minimum = new decimal(new int[] { 5, 0, 0, int.MinValue });
            numericSx.Name = "numericSx";
            numericSx.Size = new Size(70, 23);
            numericSx.Maximum = 5;
            numericSx.DecimalPlaces = 2;
            numericSx.Minimum = 0.1m;
            // 
            // numericSy
            // 
            numericSy.Location = new Point(146, 48);
            numericSy.Margin = new Padding(4, 3, 4, 3);
            numericSy.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericSy.Minimum = new decimal(new int[] { 5, 0, 0, int.MinValue });
            numericSy.Name = "numericSy";
            numericSy.Size = new Size(70, 23);
            numericSy.TabIndex = 10;
            numericSy.Maximum = 5;
            numericSy.DecimalPlaces = 2;
            numericSy.Minimum = 0.1m;
            // 
            // checkBoxFijo
            // 
            checkBoxFijo.Location = new Point(14, 17);
            checkBoxFijo.Margin = new Padding(4, 3, 4, 3);
            checkBoxFijo.Name = "checkBoxFijo";
            checkBoxFijo.Size = new Size(86, 28);
            checkBoxFijo.TabIndex = 9;
            checkBoxFijo.Text = "Punto Fijo";
            // 
            // numericFx
            // 
            numericFx.Enabled = false;
            numericFx.Location = new Point(131, 19);
            numericFx.Margin = new Padding(4, 3, 4, 3);
            numericFx.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericFx.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numericFx.Name = "numericFx";
            numericFx.Size = new Size(61, 23);
            numericFx.TabIndex = 8;
            numericFx.Maximum = 100;
            numericFx.Minimum = -100;
            // 
            // numericFy
            // 
            numericFy.Enabled = false;
            numericFy.Location = new Point(224, 19);
            numericFy.Margin = new Padding(4, 3, 4, 3);
            numericFy.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericFy.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numericFy.Name = "numericFy";
            numericFy.Size = new Size(61, 23);
            numericFy.TabIndex = 7;
            numericFy.Maximum = 100;
            numericFy.Minimum = -100;
            // 
            // btnEscalar
            // 
            btnEscalar.Location = new Point(232, 48);
            btnEscalar.Margin = new Padding(4, 3, 4, 3);
            btnEscalar.Name = "btnEscalar";
            btnEscalar.Size = new Size(75, 27);
            btnEscalar.TabIndex = 6;
            btnEscalar.Text = "Escalar";
            // 
            // numericAng
            // 
            numericAng.Location = new Point(68, 81);
            numericAng.Margin = new Padding(4, 3, 4, 3);
            numericAng.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numericAng.Minimum = new decimal(new int[] { 360, 0, 0, int.MinValue });
            numericAng.Name = "numericAng";
            numericAng.Size = new Size(70, 23);
            numericAng.TabIndex = 5;
            numericAng.Maximum = 360;
            numericAng.Minimum = -360;
            // 
            // btnRotar
            // 
            btnRotar.Location = new Point(232, 81);
            btnRotar.Margin = new Padding(4, 3, 4, 3);
            btnRotar.Name = "btnRotar";
            btnRotar.Size = new Size(75, 27);
            btnRotar.TabIndex = 4;
            btnRotar.Text = "Rotar";
            // 
            // radioX
            // 
            radioX.Checked = true;
            radioX.Location = new Point(78, 15);
            radioX.Margin = new Padding(4, 3, 4, 3);
            radioX.Name = "radioX";
            radioX.Size = new Size(50, 22);
            radioX.TabIndex = 3;
            radioX.TabStop = true;
            radioX.Text = "Eje X";
            // 
            // radioY
            // 
            radioY.Location = new Point(139, 15);
            radioY.Margin = new Padding(4, 3, 4, 3);
            radioY.Name = "radioY";
            radioY.Size = new Size(66, 22);
            radioY.TabIndex = 2;
            radioY.Text = "Eje Y";
            // 
            // radioOrig
            // 
            radioOrig.Location = new Point(8, 15);
            radioOrig.Margin = new Padding(4, 3, 4, 3);
            radioOrig.Name = "radioOrig";
            radioOrig.Size = new Size(62, 22);
            radioOrig.TabIndex = 1;
            radioOrig.Text = "Origen";
            // 
            // btnReflejar
            // 
            btnReflejar.Location = new Point(230, 13);
            btnReflejar.Margin = new Padding(4, 3, 4, 3);
            btnReflejar.Name = "btnReflejar";
            btnReflejar.Size = new Size(75, 27);
            btnReflejar.TabIndex = 0;
            btnReflejar.Text = "Reflejar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 15;
            label1.Text = "X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 24);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 16;
            label2.Text = "Y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 52);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 17;
            label3.Text = "Sx:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 52);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 18;
            label4.Text = "Sy:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 23);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 19;
            label5.Text = "Fx:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(199, 23);
            label6.Name = "label6";
            label6.Size = new Size(22, 15);
            label6.TabIndex = 20;
            label6.Text = "Fy:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 85);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 21;
            label7.Text = "Grados:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericDx);
            groupBox1.Controls.Add(numericDy);
            groupBox1.Controls.Add(btnTrasladar);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(725, 520);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 51);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trasladar";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioOrig);
            groupBox2.Controls.Add(radioX);
            groupBox2.Controls.Add(radioY);
            groupBox2.Controls.Add(btnReflejar);
            groupBox2.Location = new Point(725, 577);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(312, 44);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Reflejar";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBoxFijo);
            groupBox3.Controls.Add(numericSx);
            groupBox3.Controls.Add(numericSy);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(numericFx);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(numericFy);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(btnEscalar);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(numericAng);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btnRotar);
            groupBox3.Location = new Point(725, 627);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(312, 111);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Escalar y/o Rotar";
            // 
            // lblCoordenadas
            // 
            lblCoordenadas.AutoSize = true;
            lblCoordenadas.Location = new Point(3, 3);
            lblCoordenadas.Name = "lblCoordenadas";
            lblCoordenadas.Size = new Size(35, 15);
            lblCoordenadas.TabIndex = 25;
            lblCoordenadas.Text = "(X, Y)";
            // 
            // FrmGraphics2D
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 750);
            Controls.Add(lblCoordenadas);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewCoord);
            Controls.Add(listBoxFiguras);
            Controls.Add(btnLimpiar);
            Controls.Add(btnColor);
            Controls.Add(panelDibujo);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmGraphics2D";
            Text = "Gráficos 2D";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoord).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDx).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDy).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSx).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSy).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericFx).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericFy).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAng).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblCoordenadas;
    }
}