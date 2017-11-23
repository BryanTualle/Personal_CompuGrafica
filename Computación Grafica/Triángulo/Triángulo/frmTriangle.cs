using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triángulo
{
    public partial class frmTriangle : Form
    {
        // ATRIBUTOS
        private float mSideA;
        private float mSideB;
        private float mSideC;
        private float mSemiPerimeter;
        private float mPerimeter;
        private float mArea;


        // METODOS

        public frmTriangle()
        {
            InitializeComponent();
        }

        private bool ReadData()
        {
            try
            {
                mSideA = float.Parse(txtSideA.Text);
                mSideB = float.Parse(txtSideB.Text);
                mSideC = float.Parse(txtSideC.Text);
                return true;
            }catch
            {
                MessageBox.Show("Solo puede ingresar Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private bool VerifyTriangle()
        {
            if (((mSideA + mSideB) > mSideC) && ((mSideB + mSideC) > mSideA) && ((mSideA + mSideC) > mSideB) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PerimeterTriangle()
        {
            mPerimeter = mSideA + mSideB + mSideC;
        }

        private void SemiPerimeterTriangle()
        {
            mSemiPerimeter = (mSideA + mSideB + mSideC)/2;
        }

        private void AreaTriange()
        {
            mArea = (float)Math.Sqrt((mSemiPerimeter*(mSemiPerimeter - mSideA)*(mSemiPerimeter - mSideB)*(mSemiPerimeter - mSideC)));
        }

        private void PrintData()
        {
            txtSemiPerimeter.Text = mSemiPerimeter.ToString();
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        private void InitializeData()
        {
            txtSideA.Focus();

            mSideA = 0.0f;
            mSideB = 0.0f;
            mSideC = 0.0f;
            mSemiPerimeter = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;

            txtSideA.Text = "";
            txtSideB.Text = "";
            txtSideC.Text = "";
            txtSemiPerimeter.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
        }
        
        // -----------------------------------------------------------------------
        private void frmTriangle_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(ReadData()== true)
            {
                if (VerifyTriangle() == true)
                {
                    SemiPerimeterTriangle();
                    PerimeterTriangle();
                    AreaTriange();
                    PrintData();
                }
                else
                {
                    MessageBox.Show("Los datos ingreados No corresponden a un Triángulo", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
