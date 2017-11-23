using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuadrado
{
    public partial class frmSquare : Form
    {
        // ATRIBUTOS
        private float mSide;
        private float mPerimeter;
        private float mArea;

        // METODOS

        public frmSquare()
        {
            InitializeComponent();
            InitializeData();
        }


        private bool ReadData()
        {
            try
            {
                mSide = float.Parse(txtSide.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("SOLO DEBE INGRESAR NUMEROS", "Advertencia",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }   
        }

        private void PerimeterSquare()
        {
            mPerimeter = mSide * 4;
        }

        private void AreaSquare()
        {
            mArea = mSide * mSide;
        }


        private void PrintData()
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        private void InitializeData()
        {
            txtSide.Focus();

            mSide = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;

            txtSide.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
        }

        private void grbInputs_Enter(object sender, EventArgs e)
        {

        }

        private void frmSquare_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(ReadData()==true)
            {
                PerimeterSquare();
                AreaSquare();
                PrintData();
            }
            else
            {
                InitializeData();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
