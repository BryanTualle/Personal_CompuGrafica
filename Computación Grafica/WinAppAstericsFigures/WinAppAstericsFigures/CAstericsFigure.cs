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

        private int mA, mB;

        // Funciones miembro - Métodos
        // Constructor por defecto
        public CAstericsFigure()
        {
            mNum = 0; mRow = 0;
            mA = 0; mB = 0;
            mBlanks = ""; mAsterics = ""; mTotalString = "";
        }

        public void InitializeData(TextBox txtNum, ListBox lstFigure)
        {
            txtNum.Text = ""; lstFigure.Items.Clear();

            // Mantiene el cursor titilando en una caja de texto. 
            txtNum.Focus();
        }

        public void InitializeData(TextBox txtA, TextBox txtB, ListBox lstFigure)
        {
            txtA.Text = ""; txtB.Text = ""; lstFigure.Items.Clear();

            // Mantiene el cursor titilando en una caja de texto. 
            txtA.Focus();
        }


        public void ReadData(TextBox txtNum)
        {
            mNum = int.Parse(txtNum.Text);
        }

        public void ReadData(TextBox txtA, TextBox txtB)
        {
            mA = int.Parse(txtA.Text);
            mB = int.Parse(txtB.Text);
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

        public void GraphAstericsRombus(ListBox lstFigure)
        {
            int contBanks, contAsterics;
            lstFigure.Items.Clear();

            if((mNum + 1) % 2 == 0)
            {
                mNum = mNum + 1;
                mNum = mNum / 2;

                // Bucle externo para controlar las filas
                for (mRow = 1; mRow <= mNum; mRow++)
                {
                    mBlanks = ""; mAsterics = ""; mTotalString = "";

                    //Bucle para controlar los espacios en blanco (Decreciente)
                    for (contBanks = mNum - mRow; contBanks > 0; contBanks--)
                    {
                        mBlanks = mBlanks + " ";
                    }

                    //Bucle para controlar los astericos (Creciente)
                    for (contAsterics = 1; contAsterics < 2 * mRow; contAsterics++)
                    {
                        mAsterics = mAsterics + "*";
                    }

                    mTotalString = mBlanks + mAsterics;
                    lstFigure.Items.Add(mTotalString);
                }

                // Bucle externo para controlar las filas (Decreciente)
                for (mRow = mNum - 1; mRow > 0; mRow--)
                {
                    mBlanks = ""; mAsterics = ""; mTotalString = "";

                    //Bucle para controlar los espacios en blanco (Decreciente)
                    for (contBanks = mNum - mRow; contBanks > 0; contBanks--)
                    {
                        mBlanks = mBlanks + " ";
                    }

                    //Bucle para controlar los astericos (Creciente)
                    for (contAsterics = 1; contAsterics < 2 * mRow; contAsterics++)
                    {
                        mAsterics = mAsterics + "*";
                    }

                    mTotalString = mBlanks + mAsterics;
                    lstFigure.Items.Add(mTotalString);
                }


            }
            else
            {
                MessageBox.Show("NO EXISTE EL ROMBO");

            }



        }

        public void GraphAstericsRectangle(ListBox lstFigure)
        {
            int contBlanks, contAsterics;
            lstFigure.Items.Clear();

            

            for(mRow =1; mRow <=mB; mRow++)
            {
                mBlanks = ""; mAsterics = ""; mTotalString = "";

                if (mRow == 1 || mRow == mB)
                {

                    for (contAsterics = 1; contAsterics <= mA; contAsterics++)
                    {
                        mAsterics = mAsterics + "*";
                    }
                    lstFigure.Items.Add(mAsterics);

                }
                else
                {
                    mAsterics = "*";
                    for (contBlanks = 1; contBlanks <= (mA - 2); contBlanks++)
                    {
                        mBlanks = mBlanks + " ";
                    }
                    mTotalString = mAsterics + mBlanks + mAsterics;
                    lstFigure.Items.Add(mTotalString);
                }
            }
            

        }

    }
}
