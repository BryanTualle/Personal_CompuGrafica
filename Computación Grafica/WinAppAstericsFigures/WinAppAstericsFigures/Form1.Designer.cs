namespace WinAppAstericsFigures
{
    partial class frmMenu
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
            this.grbMenu = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnRombus = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnChessboard = new System.Windows.Forms.Button();
            this.grbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMenu
            // 
            this.grbMenu.Controls.Add(this.btnChessboard);
            this.grbMenu.Controls.Add(this.btnCircle);
            this.grbMenu.Controls.Add(this.btnExit);
            this.grbMenu.Controls.Add(this.btnSquare);
            this.grbMenu.Controls.Add(this.btnRectangle);
            this.grbMenu.Controls.Add(this.btnRombus);
            this.grbMenu.Controls.Add(this.btnTriangle);
            this.grbMenu.Location = new System.Drawing.Point(16, 14);
            this.grbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Padding = new System.Windows.Forms.Padding(4);
            this.grbMenu.Size = new System.Drawing.Size(347, 402);
            this.grbMenu.TabIndex = 1;
            this.grbMenu.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(28, 334);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(293, 44);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(28, 178);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(4);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(293, 44);
            this.btnSquare.TabIndex = 3;
            this.btnSquare.Text = "Cuadrado";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(28, 127);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(4);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(293, 44);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.Text = "Rectángulo";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnRombus
            // 
            this.btnRombus.Location = new System.Drawing.Point(28, 75);
            this.btnRombus.Margin = new System.Windows.Forms.Padding(4);
            this.btnRombus.Name = "btnRombus";
            this.btnRombus.Size = new System.Drawing.Size(293, 44);
            this.btnRombus.TabIndex = 1;
            this.btnRombus.Text = "Rombo";
            this.btnRombus.UseVisualStyleBackColor = true;
            this.btnRombus.Click += new System.EventHandler(this.btnRombus_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(28, 23);
            this.btnTriangle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(293, 44);
            this.btnTriangle.TabIndex = 0;
            this.btnTriangle.Text = "Triángulo";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(28, 230);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(4);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(293, 44);
            this.btnCircle.TabIndex = 5;
            this.btnCircle.Text = "Círculo";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnChessboard
            // 
            this.btnChessboard.Location = new System.Drawing.Point(28, 282);
            this.btnChessboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnChessboard.Name = "btnChessboard";
            this.btnChessboard.Size = new System.Drawing.Size(293, 44);
            this.btnChessboard.TabIndex = 6;
            this.btnChessboard.Text = "Tablero de Ajedrez";
            this.btnChessboard.UseVisualStyleBackColor = true;
            this.btnChessboard.Click += new System.EventHandler(this.btnChessboard_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 430);
            this.Controls.Add(this.grbMenu);
            this.Name = "frmMenu";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.grbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMenu;
        private System.Windows.Forms.Button btnChessboard;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnRombus;
        private System.Windows.Forms.Button btnTriangle;
    }
}

