using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCircle : Form
    {
        // Datos Miembro  Atributos de la Clase
        private float mRadius;
        private float mPerimeter;
        private float mArea;


        // Funciones Miembre - Metodos de la clase
        // Constructor de la clase


        public frmCircle()
        {
            InitializeComponent();
            /*
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            */
            InitializeData();
        }

        private void ReadData()
        {
            try
            {
                mRadius = float.Parse(txtRadius.Text);
                mRadius = float.Parse(txtRadius.Text);
            }
            catch
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }

        private void PerimeterCircle()
        {
            mPerimeter =  2 * (float)Math.PI * mRadius;

        }

        private void AreaCircle()
        {
            //mArea = (float)Math.PI * mRadius * mRadius;
            mArea = (float)Math.PI * (float)Math.Pow(mRadius,2);

        }

        private void PrintData()
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        private void  InitializeData()
        {
            txtRadius.Focus();              //Cursor titilando a la caja de texto
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtRadius.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";

        }
        /*
        private void txtCaracter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        */


        private void lblRadius_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ReadData();
            PerimeterCircle();
            AreaCircle();
            PrintData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnExtit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCircle_Load(object sender, EventArgs e)
        {
            
        }

        private void grbInputs_Enter(object sender, EventArgs e)
        {

        }

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
