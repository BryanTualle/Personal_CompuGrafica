﻿namespace WinAppAstericsFigures
{
    partial class frmAstericsTriangle
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
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbOutput = new System.Windows.Forms.GroupBox();
            this.lstFigure = new System.Windows.Forms.ListBox();
            this.lblFigura = new System.Windows.Forms.Label();
            this.grbInput.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.txtNum);
            this.grbInput.Controls.Add(this.lblNum);
            this.grbInput.Location = new System.Drawing.Point(16, 15);
            this.grbInput.Margin = new System.Windows.Forms.Padding(4);
            this.grbInput.Name = "grbInput";
            this.grbInput.Padding = new System.Windows.Forms.Padding(4);
            this.grbInput.Size = new System.Drawing.Size(347, 70);
            this.grbInput.TabIndex = 10;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Entradas";
            this.grbInput.Enter += new System.EventHandler(this.grbInput_Enter);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(184, 33);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(132, 22);
            this.txtNum.TabIndex = 1;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(36, 33);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(140, 17);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Número de términos:";
            this.lblNum.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Location = new System.Drawing.Point(16, 92);
            this.grbProcess.Margin = new System.Windows.Forms.Padding(4);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Padding = new System.Windows.Forms.Padding(4);
            this.grbProcess.Size = new System.Drawing.Size(347, 68);
            this.grbProcess.TabIndex = 11;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            this.grbProcess.Enter += new System.EventHandler(this.grbProcess_Enter);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(239, 23);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(128, 23);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(20, 23);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.lstFigure);
            this.grbOutput.Controls.Add(this.lblFigura);
            this.grbOutput.Location = new System.Drawing.Point(16, 167);
            this.grbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Padding = new System.Windows.Forms.Padding(4);
            this.grbOutput.Size = new System.Drawing.Size(347, 314);
            this.grbOutput.TabIndex = 12;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Salidas";
            this.grbOutput.Enter += new System.EventHandler(this.grbOutput_Enter);
            // 
            // lstFigure
            // 
            this.lstFigure.FormattingEnabled = true;
            this.lstFigure.ItemHeight = 16;
            this.lstFigure.Location = new System.Drawing.Point(39, 80);
            this.lstFigure.Name = "lstFigure";
            this.lstFigure.Size = new System.Drawing.Size(284, 212);
            this.lstFigure.TabIndex = 3;
            this.lstFigure.SelectedIndexChanged += new System.EventHandler(this.lstFigure_SelectedIndexChanged);
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Location = new System.Drawing.Point(36, 44);
            this.lblFigura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(52, 17);
            this.lblFigura.TabIndex = 2;
            this.lblFigura.Text = "Figura:";
            this.lblFigura.Click += new System.EventHandler(this.lblFigura_Click);
            // 
            // frmAstericsTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 494);
            this.Controls.Add(this.grbInput);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbOutput);
            this.Name = "frmAstericsTriangle";
            this.Text = "frmAstericsTriangle";
            this.Load += new System.EventHandler(this.frmAstericsTriangle_Load);
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOutput.ResumeLayout(false);
            this.grbOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbOutput;
        private System.Windows.Forms.ListBox lstFigure;
        private System.Windows.Forms.Label lblFigura;
    }
}