﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinAppGeometricShapesV2
{
    public partial class frmCircle : Form
    {
        // Composicion -> Incluyendo un objeto de tipo CCircle
        private CCircle ObjCircle = new CCircle();

        public frmCircle()
        {
            InitializeComponent();
        }

        private void frmCircle_Load(object sender, EventArgs e)
        {
            ObjCircle.InitializeData(txtRadius, txtPerimeter, txtArea);

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCircle.ReadData(txtRadius);
            ObjCircle.PerimeterCircle();
            ObjCircle.AreaCircle();
            ObjCircle.PrintData(txtPerimeter, txtArea);
            ObjCircle.DrawShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCircle.InitializeData(txtRadius, txtPerimeter, txtArea);
            ObjCircle.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExtit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
