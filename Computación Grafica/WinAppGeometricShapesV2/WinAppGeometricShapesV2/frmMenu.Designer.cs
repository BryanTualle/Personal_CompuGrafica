namespace WinAppGeometricShapesV2
{
    partial class frmMenu
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
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbmenu = new System.Windows.Forms.GroupBox();
            this.grbmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(6, 21);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(391, 41);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "Círculo";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(6, 66);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(391, 41);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Text = "Rectángulo";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(6, 113);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(391, 41);
            this.btnSquare.TabIndex = 2;
            this.btnSquare.Text = "Cuadrado";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(6, 160);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(391, 41);
            this.btnTriangle.TabIndex = 3;
            this.btnTriangle.Text = "Triángulo";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(6, 207);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(391, 41);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbmenu
            // 
            this.grbmenu.Controls.Add(this.btnExit);
            this.grbmenu.Controls.Add(this.btnTriangle);
            this.grbmenu.Controls.Add(this.btnSquare);
            this.grbmenu.Controls.Add(this.btnRectangle);
            this.grbmenu.Controls.Add(this.btnCircle);
            this.grbmenu.Location = new System.Drawing.Point(12, 12);
            this.grbmenu.Name = "grbmenu";
            this.grbmenu.Size = new System.Drawing.Size(403, 264);
            this.grbmenu.TabIndex = 0;
            this.grbmenu.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 309);
            this.Controls.Add(this.grbmenu);
            this.Name = "frmMenu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.grbmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grbmenu;
    }
}