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
    public partial class frmAstericsRectangle : Form
    {
        CAstericsFigure objRectangle = new CAstericsFigure();

        public frmAstericsRectangle()
        {
            InitializeComponent();
        }


        private void frmAstericsRectangle_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objRectangle.ReadData(txtA,txtB);
            objRectangle.GraphAstericsRectangle(lstFigure);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
