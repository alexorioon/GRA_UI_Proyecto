﻿namespace FormsMenu
{
    partial class FrmMenuPrincipal
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(301, 43);
            button1.Name = "button1";
            button1.Size = new Size(170, 23);
            button1.TabIndex = 0;
            button1.Text = "Menu 1 Consola";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(301, 82);
            button2.Name = "button2";
            button2.Size = new Size(170, 23);
            button2.TabIndex = 1;
            button2.Text = "Menu 2 Consola";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(301, 121);
            button3.Name = "button3";
            button3.Size = new Size(170, 23);
            button3.TabIndex = 2;
            button3.Text = "Menu Fractales";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(301, 159);
            button4.Name = "button4";
            button4.Size = new Size(170, 23);
            button4.TabIndex = 3;
            button4.Text = "Graficación 2D";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(301, 198);
            button5.Name = "button5";
            button5.Size = new Size(170, 23);
            button5.TabIndex = 4;
            button5.Text = "Graficación 3D";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(301, 237);
            button6.Name = "button6";
            button6.Size = new Size(170, 23);
            button6.TabIndex = 5;
            button6.Text = "Tiro Parabólico 3D Unity";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(301, 277);
            button7.Name = "button7";
            button7.Size = new Size(170, 23);
            button7.TabIndex = 6;
            button7.Text = "Gráficos";
            button7.UseVisualStyleBackColor = true;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}