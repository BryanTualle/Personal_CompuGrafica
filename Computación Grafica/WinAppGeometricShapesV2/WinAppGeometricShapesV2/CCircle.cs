using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppGeometricShapesV2
{
    class CCircle
    {
        // Datos Miembro - Atributos de la Clase
        private float mRadius;
        private float mPerimeter;
        private float mArea;

        //Objeto que activa el modo grafico de windows
        private Graphics mGraph;

        // SF -> Scale Factor (Constante) para manear
        // un Zoom In y un Zoom Out del dibujo
        private const float SF = 20;
        // Objeto de tipo Pluma (Lápiz, esfero, marcador) para dibujar en el linezo
        private Pen mPen;


        // Funciones Miembro - Metodos de la clase
        
        // Constructor por defecto sin parametros
        public CCircle ()
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtRadius)
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

        public void PerimeterCircle()
        {
            mPerimeter = 2 * (float)Math.PI * mRadius;

        }

        public void AreaCircle()
        {
            //mArea = (float)Math.PI * mRadius * mRadius;
            mArea = (float)Math.PI * (float)Math.Pow(mRadius, 2);

        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtRadius, TextBox txtPerimeter, TextBox txtArea)
        {
            txtRadius.Focus();              //Cursor titilando a la caja de texto
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtRadius.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";
        }

        public void InitializeData(TextBox txtRadius, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            txtRadius.Focus();              //Cursor titilando a la caja de texto
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtRadius.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";
            picCanvas.Refresh();
        }


        public void DrawShape(PictureBox picCanvas)
        {
            // asignar al objeto mGraaph la funcionalidad de crear graficos del pinCanvas
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.DarkOliveGreen, 3);

            //Graficar un circulo en fuuncion de una elipse
            mGraph.DrawEllipse(mPen, 0, 0, 2 * mRadius * SF, 2 * mRadius * SF);
            //mGraph.DrawRectangle(mPen, );
        }

        public void DrawRectangle()
        {

        }


    }
}
