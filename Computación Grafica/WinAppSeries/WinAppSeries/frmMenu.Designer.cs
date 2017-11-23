namespace WinAppSeries
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
            this.btnSucesion1 = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.grbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMenu
            // 
            this.grbMenu.Controls.Add(this.button7);
            this.grbMenu.Controls.Add(this.button6);
            this.grbMenu.Controls.Add(this.button5);
            this.grbMenu.Controls.Add(this.button4);
            this.grbMenu.Controls.Add(this.button3);
            this.grbMenu.Controls.Add(this.btnFactorial);
            this.grbMenu.Controls.Add(this.btnSucesion1);
            this.grbMenu.Location = new System.Drawing.Point(12, 12);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Size = new System.Drawing.Size(343, 420);
            this.grbMenu.TabIndex = 0;
            this.grbMenu.TabStop = false;
            // 
            // btnSucesion1
            // 
            this.btnSucesion1.Location = new System.Drawing.Point(6, 21);
            this.btnSucesion1.Name = "btnSucesion1";
            this.btnSucesion1.Size = new System.Drawing.Size(331, 41);
            this.btnSucesion1.TabIndex = 0;
            this.btnSucesion1.Text = "S(n) = 1 + 2 + 3 + ... + n";
            this.btnSucesion1.UseVisualStyleBackColor = true;
            this.btnSucesion1.Click += new System.EventHandler(this.btnSucesion1_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(6, 68);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(331, 41);
            this.btnFactorial.TabIndex = 1;
            this.btnFactorial.Text = "n! = 1 x 2 x 3 x 4 x ... x n";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(331, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(331, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(331, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 256);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(331, 41);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 303);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(331, 41);
            this.button7.TabIndex = 6;
            this.button7.Text = "Salir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 444);
            this.Controls.Add(this.grbMenu);
            this.Name = "frmMenu";
            this.Text = "Menuú Principal";
            this.grbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMenu;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnSucesion1;
    }
}

