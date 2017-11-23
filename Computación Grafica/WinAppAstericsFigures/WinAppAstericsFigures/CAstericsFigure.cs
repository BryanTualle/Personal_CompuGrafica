using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppAstericsFigures
{
    class CAstericsFigure
    {
        // Datos Miembro - Atributos
        private int mNum;
        private int mRow;
        private String mBlanks;
        private string mAsterics;
        private string mTotalString;


        // Funciones miembro - Métodos
        public CAstericsFigure()
        {
            mNum = 0; mRow = 0;
            mBlanks = ""; mAsterics = ""; mTotalString = "";
        }
        public void InitializeData(TextBox txtNum, ListBox lstFigure)
        {
            txtNum.Text = ""; lstFigure.Items.Clear();

            // Mantiene el cursor titilando en una caja de texto. 
            txtNum.Focus();


        }

        public void ReadData(TextBox txtNum)
        {
            mNum = int.Parse(txtNum.Text);
        }

        public void GraphAstericsTriangle(ListBox lstFigure)
        {
            int contBanks, contAsterics;
            lstFigure.Items.Clear();

            // Bucle externo para controlar las filas
            for(mRow = 1; mRow<= mNum; mRow++)
            {
                mBlanks = ""; mAsterics = ""; mTotalString = "";

                //Bucle para controlar los espacios en blanco
                for(contBanks = mNum - mRow; contBanks > 0; contBanks--)
                {
                    mBlanks = mBlanks + " ";
                }

                //Bucle para controlar los astericos
                for (contAsterics = 1; contAsterics < 2 * mRow ; contAsterics++)
                {
                    mAsterics = mAsterics + "*";
                }

                mTotalString = mBlanks + mAsterics;
                lstFigure.Items.Add(mTotalString);
            }


        }



    }
}
