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
    public partial class frmAstericsRombus : Form
    {
        CAstericsFigure objRombus = new CAstericsFigure();

        public frmAstericsRombus()
        {
            InitializeComponent();
        }


        private void frmAstericsRombus_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objRombus.ReadData(txtNum);
            objRombus.GraphAstericsRombus(lstFigure);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objRombus.InitializeData(txtNum, lstFigure);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
