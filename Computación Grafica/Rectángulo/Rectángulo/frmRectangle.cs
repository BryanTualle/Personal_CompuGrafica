using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectángulo
{
    public partial class frmRectangle : Form
    {
        // Atributos de la clase
        private float mBase;
        private float mHeight;
        private float mPerimeter;
        private float mArea;

        // Metodos de la Clase

        public frmRectangle()
        {
            InitializeComponent();
            InitializeData();
        }

        private void ReadData()
        {
            try
            {
                mBase = float.Parse( txtBase.Text);
                mHeight = float.Parse(txtHeight.Text);
            }catch
            {
                MessageBox.Show("SOLO SE PERMITEN NUMERO","ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
            }
            
        }

        private void PerimeterRectangle()
        {
            mPerimeter = (mBase * 2) + (mHeight * 2);
        }

        private void AreaRectangle()
        {
            mArea = mBase * mHeight;
        }

        private void PrintData()
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        private void InitializeData()
        {
            txtBase.Focus();
            txtBase.Text = "";
            txtHeight.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            mBase = 0.0f;
            mHeight = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ReadData();
            PerimeterRectangle();
            AreaRectangle();
            PrintData();
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
