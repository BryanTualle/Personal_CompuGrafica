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
    public partial class frmAstericsTriangle : Form
    {
        CAstericsFigure objAstericsFigure = new CAstericsFigure();

        public frmAstericsTriangle()
        {
            InitializeComponent();
        }

        private void frmAstericsTriangle_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objAstericsFigure.ReadData(txtNum);
            objAstericsFigure.GraphAstericsTriangle(lstFigure);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objAstericsFigure.InitializeData(txtNum, lstFigure);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstFigure_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
