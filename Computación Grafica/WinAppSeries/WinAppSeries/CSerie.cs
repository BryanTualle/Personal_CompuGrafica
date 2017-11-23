using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppSeries
{
    class CSerie
    {
        // Datos Miembro - Atributos
        private float mNum;         // Numero de términos de la serie
        private float mX;           // Variable Independiente
        private float mResult;      // Variable para el resultado

        // Funciones Miembro - Métodos

        // Función Constructor
        public CSerie ()
        {
            mNum = 0.0F; mX = 0.0f;
        }

        public void ReadData (TextBox txtNum)
        {
            mNum = float.Parse(txtNum.Text);
        }

        public void PrintData(TextBox txtResult)
        {
            txtResult.Text = mResult.ToString();
        }

        public void Sucesion1()
        {
            float i;                // Contador
            float sum=0;              // Acumulador

            for(i=1; i<=mNum; i++)
            {
                sum = sum + i;
            }
            mResult = sum;
        }
    }
}
