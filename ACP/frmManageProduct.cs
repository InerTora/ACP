﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACP
{
    public partial class frmManageProduct : Form
    {
        public frmManageProduct()
        {
            InitializeComponent();
         
        }

        private void btnNewProd_Click(object sender, EventArgs e)
        {
            frmAddProduct addprd = new frmAddProduct();
            addprd.ShowDialog();
        }
    }
}
