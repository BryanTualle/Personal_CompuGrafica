using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppAstericsFigures
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            frmAstericsTriangle objForm = new frmAstericsTriangle();
            objForm.Show();
        }

        private void btnRombus_Click(object sender, EventArgs e)
        {
            frmAstericsRombus objForm = new frmAstericsRombus();
            objForm.Show();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            frmAstericsRectangle objForm = new frmAstericsRectangle();
            objForm.Show();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            frmAstericsSquare objForm = new frmAstericsSquare();
            objForm.Show();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            frmAstericsCircle objForm = new frmAstericsCircle();
            objForm.Show();
        }

        private void btnChessboard_Click(object sender, EventArgs e)
        {
            frmAstericsChessboard objForm = new frmAstericsChessboard();
            objForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
