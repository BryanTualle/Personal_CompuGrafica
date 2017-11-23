using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSeries
{
    public partial class frmSucesion1 : Form
    {
        CSerie objSerie = new CSerie();
        public frmSucesion1()
        {
            InitializeComponent();
        }

        private void frmSucesion1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objSerie.ReadData(txtNum);
            objSerie.Sucesion1();
            objSerie.PrintData(txtResult);
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
