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
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericFx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericFy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAng).BeginInit();
            SuspendLayout();
            // 
            // panelDibujo
            // 
            panelDibujo.BackColor = Color.White;
            panelDibujo.BorderStyle = BorderStyle.FixedSingle;
            panelDibujo.Location = new Point(14, 14);
            panelDibujo.Margin = new Padding(4, 3, 4, 3);
            panelDibujo.Name = "panelDibujo";
            panelDibujo.Size = new Size(700, 461);
            panelDibujo.TabIndex = 0;
            panelDibujo.Paint += panelDibujo_Paint;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(735, 14);
            btnColor.Margin = new Padding(4, 3, 4, 3);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(117, 27);
            btnColor.TabIndex = 1;
            btnColor.Text = "Seleccionar Color";
            btnColor.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(735, 58);
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
            listBoxFiguras.Location = new Point(735, 104);
            listBoxFiguras.Margin = new Padding(4, 3, 4, 3);
            listBoxFiguras.Name = "listBoxFiguras";
            listBoxFiguras.Size = new Size(233, 109);
            listBoxFiguras.TabIndex = 3;
            // 
            // dataGridViewCoord
            // 
            dataGridViewCoord.AllowUserToAddRows = false;
            dataGridViewCoord.AllowUserToDeleteRows = false;
            dataGridViewCoord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCoord.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewCoord.Location = new Point(14, 485);
            dataGridViewCoord.Margin = new Padding(4, 3, 4, 3);
            dataGridViewCoord.Name = "dataGridViewCoord";
            dataGridViewCoord.ReadOnly = true;
            dataGridViewCoord.Size = new Size(583, 231);
            dataGridViewCoord.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Name = "PuntosFigura";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Name = "X Orignial";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.Name = "Y Original";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.Name = "X Nueva";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.Name = "Y Nueva";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // numericDx
            // 
            numericDx.Location = new Point(754, 227);
            numericDx.Margin = new Padding(4, 3, 4, 3);
            numericDx.Name = "numericDx";
            numericDx.Size = new Size(70, 23);
            numericDx.TabIndex = 14;
            numericDx.Minimum = -1000;
            numericDx.Maximum = 1000;
            // 
            // numericDy
            // 
            numericDy.Location = new Point(849, 227);
            numericDy.Margin = new Padding(4, 3, 4, 3);
            numericDy.Name = "numericDy";
            numericDy.Size = new Size(70, 23);
            numericDy.TabIndex = 13;
            numericDy.Minimum = -1000;
            numericDy.Maximum = 1000;
            // 
            // btnTrasladar
            // 
            btnTrasladar.Location = new Point(934, 225);
            btnTrasladar.Margin = new Padding(4, 3, 4, 3);
            btnTrasladar.Name = "btnTrasladar";
            btnTrasladar.Size = new Size(88, 27);
            btnTrasladar.TabIndex = 12;
            btnTrasladar.Text = "Trasladar";
            // 
            // numericSx
            // 
            numericSx.Location = new Point(759, 296);
            numericSx.Margin = new Padding(4, 3, 4, 3);
            numericSx.Name = "numericSx";
            numericSx.Size = new Size(70, 23);
            numericSx.TabIndex = 11;
            // 
            // numericSy
            // 
            numericSy.Location = new Point(860, 296);
            numericSy.Margin = new Padding(4, 3, 4, 3);
            numericSy.Name = "numericSy";
            numericSy.Size = new Size(70, 23);
            numericSy.TabIndex = 10;
            // 
            // checkBoxFijo
            // 
            checkBoxFijo.Location = new Point(735, 472);
            checkBoxFijo.Margin = new Padding(4, 3, 4, 3);
            checkBoxFijo.Name = "checkBoxFijo";
            checkBoxFijo.Size = new Size(86, 28);
            checkBoxFijo.TabIndex = 9;
            checkBoxFijo.Text = "Punto Fijo";
            // 
            // numericFx
            // 
            numericFx.Location = new Point(847, 474);
            numericFx.Margin = new Padding(4, 3, 4, 3);
            numericFx.Name = "numericFx";
            numericFx.Size = new Size(61, 23);
            numericFx.TabIndex = 8;
            // 
            // numericFy
            // 
            numericFy.Location = new Point(940, 474);
            numericFy.Margin = new Padding(4, 3, 4, 3);
            numericFy.Name = "numericFy";
            numericFy.Size = new Size(61, 23);
            numericFy.TabIndex = 7;
            // 
            // btnEscalar
            // 
            btnEscalar.Location = new Point(943, 292);
            btnEscalar.Margin = new Padding(4, 3, 4, 3);
            btnEscalar.Name = "btnEscalar";
            btnEscalar.Size = new Size(75, 27);
            btnEscalar.TabIndex = 6;
            btnEscalar.Text = "Escalar";
            // 
            // numericAng
            // 
            numericAng.Location = new Point(785, 360);
            numericAng.Margin = new Padding(4, 3, 4, 3);
            numericAng.Name = "numericAng";
            numericAng.Size = new Size(70, 23);
            numericAng.TabIndex = 5;
            // 
            // btnRotar
            // 
            btnRotar.Location = new Point(862, 358);
            btnRotar.Margin = new Padding(4, 3, 4, 3);
            btnRotar.Name = "btnRotar";
            btnRotar.Size = new Size(88, 27);
            btnRotar.TabIndex = 4;
            btnRotar.Text = "Rotar";
            // 
            // radioX
            // 
            radioX.Checked = true;
            radioX.Location = new Point(733, 549);
            radioX.Margin = new Padding(4, 3, 4, 3);
            radioX.Name = "radioX";
            radioX.Size = new Size(66, 28);
            radioX.TabIndex = 3;
            radioX.TabStop = true;
            radioX.Text = "Eje X";
            // 
            // radioY
            // 
            radioY.Location = new Point(733, 583);
            radioY.Margin = new Padding(4, 3, 4, 3);
            radioY.Name = "radioY";
            radioY.Size = new Size(66, 28);
            radioY.TabIndex = 2;
            radioY.Text = "Eje Y";
            // 
            // radioOrig
            // 
            radioOrig.Location = new Point(733, 515);
            radioOrig.Margin = new Padding(4, 3, 4, 3);
            radioOrig.Name = "radioOrig";
            radioOrig.Size = new Size(66, 28);
            radioOrig.TabIndex = 1;
            radioOrig.Text = "Origen";
            // 
            // btnReflejar
            // 
            btnReflejar.Location = new Point(807, 550);
            btnReflejar.Margin = new Padding(4, 3, 4, 3);
            btnReflejar.Name = "btnReflejar";
            btnReflejar.Size = new Size(88, 27);
            btnReflejar.TabIndex = 0;
            btnReflejar.Text = "Reflejar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(735, 231);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 15;
            label1.Text = "X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(829, 231);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 16;
            label2.Text = "Y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(735, 300);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 17;
            label3.Text = "Sx:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(836, 300);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 18;
            label4.Text = "Sy:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(823, 478);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 19;
            label5.Text = "Fx:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(915, 478);
            label6.Name = "label6";
            label6.Size = new Size(22, 15);
            label6.TabIndex = 20;
            label6.Text = "Fy:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(735, 364);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 21;
            label7.Text = "Grados:";
            // 
            // FrmGraphics2D
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 750);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnReflejar);
            Controls.Add(radioOrig);
            Controls.Add(radioY);
            Controls.Add(radioX);
            Controls.Add(btnRotar);
            Controls.Add(numericAng);
            Controls.Add(btnEscalar);
            Controls.Add(numericFy);
            Controls.Add(numericFx);
            Controls.Add(checkBoxFijo);
            Controls.Add(numericSy);
            Controls.Add(numericSx);
            Controls.Add(btnTrasladar);
            Controls.Add(numericDy);
            Controls.Add(numericDx);
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
    }
}