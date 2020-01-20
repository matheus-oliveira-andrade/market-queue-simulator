namespace QueueSimulator
{
    partial class FrmQueue
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarFila = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCx5Rest = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCx5Tot = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCx3Rest = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCx3Tot = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCx4Rest = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCx4Tot = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCx2Rest = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCx2Tot = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblCx1Rest = new System.Windows.Forms.Label();
            this.lblCx1Tot = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(444, 16);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(555, 16);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(105, 30);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fila: ";
            // 
            // progressBarFila
            // 
            this.progressBarFila.Location = new System.Drawing.Point(343, 63);
            this.progressBarFila.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarFila.Maximum = 10000;
            this.progressBarFila.Name = "progressBarFila";
            this.progressBarFila.Size = new System.Drawing.Size(413, 30);
            this.progressBarFila.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 359);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblCx5Rest);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lblCx5Tot);
            this.panel4.Location = new System.Drawing.Point(903, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 353);
            this.panel4.TabIndex = 9;
            // 
            // lblCx5Rest
            // 
            this.lblCx5Rest.AutoSize = true;
            this.lblCx5Rest.Location = new System.Drawing.Point(129, 325);
            this.lblCx5Rest.Name = "lblCx5Rest";
            this.lblCx5Rest.Size = new System.Drawing.Size(12, 16);
            this.lblCx5Rest.TabIndex = 4;
            this.lblCx5Rest.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 325);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Itens restantes:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 294);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 16);
            this.label16.TabIndex = 3;
            this.label16.Text = "Total itens: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Caixa 5";
            // 
            // lblCx5Tot
            // 
            this.lblCx5Tot.AutoSize = true;
            this.lblCx5Tot.Location = new System.Drawing.Point(108, 294);
            this.lblCx5Tot.Name = "lblCx5Tot";
            this.lblCx5Tot.Size = new System.Drawing.Size(12, 16);
            this.lblCx5Tot.TabIndex = 4;
            this.lblCx5Tot.Text = "-";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblCx3Rest);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lblCx3Tot);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(453, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 353);
            this.panel3.TabIndex = 6;
            // 
            // lblCx3Rest
            // 
            this.lblCx3Rest.AutoSize = true;
            this.lblCx3Rest.Location = new System.Drawing.Point(135, 325);
            this.lblCx3Rest.Name = "lblCx3Rest";
            this.lblCx3Rest.Size = new System.Drawing.Size(12, 16);
            this.lblCx3Rest.TabIndex = 4;
            this.lblCx3Rest.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Itens restantes:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Total itens: ";
            // 
            // lblCx3Tot
            // 
            this.lblCx3Tot.AutoSize = true;
            this.lblCx3Tot.Location = new System.Drawing.Point(110, 294);
            this.lblCx3Tot.Name = "lblCx3Tot";
            this.lblCx3Tot.Size = new System.Drawing.Size(12, 16);
            this.lblCx3Tot.TabIndex = 4;
            this.lblCx3Tot.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Caixa 3";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblCx4Rest);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.lblCx4Tot);
            this.panel5.Location = new System.Drawing.Point(678, 3);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(225, 353);
            this.panel5.TabIndex = 10;
            // 
            // lblCx4Rest
            // 
            this.lblCx4Rest.AutoSize = true;
            this.lblCx4Rest.Location = new System.Drawing.Point(132, 325);
            this.lblCx4Rest.Name = "lblCx4Rest";
            this.lblCx4Rest.Size = new System.Drawing.Size(12, 16);
            this.lblCx4Rest.TabIndex = 4;
            this.lblCx4Rest.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Itens restantes:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Total itens: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Caixa 4";
            // 
            // lblCx4Tot
            // 
            this.lblCx4Tot.AutoSize = true;
            this.lblCx4Tot.Location = new System.Drawing.Point(107, 294);
            this.lblCx4Tot.Name = "lblCx4Tot";
            this.lblCx4Tot.Size = new System.Drawing.Size(12, 16);
            this.lblCx4Tot.TabIndex = 4;
            this.lblCx4Tot.Text = "-";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblCx2Rest);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblCx2Tot);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(228, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 353);
            this.panel2.TabIndex = 7;
            // 
            // lblCx2Rest
            // 
            this.lblCx2Rest.AutoSize = true;
            this.lblCx2Rest.Location = new System.Drawing.Point(132, 325);
            this.lblCx2Rest.Name = "lblCx2Rest";
            this.lblCx2Rest.Size = new System.Drawing.Size(12, 16);
            this.lblCx2Rest.TabIndex = 4;
            this.lblCx2Rest.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Itens restantes:";
            // 
            // lblCx2Tot
            // 
            this.lblCx2Tot.AutoSize = true;
            this.lblCx2Tot.Location = new System.Drawing.Point(103, 294);
            this.lblCx2Tot.Name = "lblCx2Tot";
            this.lblCx2Tot.Size = new System.Drawing.Size(12, 16);
            this.lblCx2Tot.TabIndex = 4;
            this.lblCx2Tot.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Total itens: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Caixa 2";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblCx1Rest);
            this.panel6.Controls.Add(this.lblCx1Tot);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(225, 353);
            this.panel6.TabIndex = 8;
            // 
            // lblCx1Rest
            // 
            this.lblCx1Rest.AutoSize = true;
            this.lblCx1Rest.Location = new System.Drawing.Point(124, 325);
            this.lblCx1Rest.Name = "lblCx1Rest";
            this.lblCx1Rest.Size = new System.Drawing.Size(12, 16);
            this.lblCx1Rest.TabIndex = 4;
            this.lblCx1Rest.Text = "-";
            // 
            // lblCx1Tot
            // 
            this.lblCx1Tot.AutoSize = true;
            this.lblCx1Tot.Location = new System.Drawing.Point(95, 294);
            this.lblCx1Tot.Name = "lblCx1Tot";
            this.lblCx1Tot.Size = new System.Drawing.Size(12, 16);
            this.lblCx1Tot.TabIndex = 4;
            this.lblCx1Tot.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Itens restantes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total itens: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Caixa 1";
            // 
            // FrmQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBarFila);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQueue";
            this.ShowIcon = false;
            this.Text = "Queue Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarFila;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCx5Rest;
        private System.Windows.Forms.Label lblCx5Tot;
        private System.Windows.Forms.Label lblCx3Rest;
        private System.Windows.Forms.Label lblCx3Tot;
        private System.Windows.Forms.Label lblCx4Rest;
        private System.Windows.Forms.Label lblCx4Tot;
        private System.Windows.Forms.Label lblCx2Rest;
        private System.Windows.Forms.Label lblCx2Tot;
        private System.Windows.Forms.Label lblCx1Rest;
        private System.Windows.Forms.Label lblCx1Tot;
    }
}

