﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    public partial class frmMain : frmInheritance
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts = new frmProducts();
            frmProducts.Show();
            this.Hide();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers frmUsers = new frmUsers();
            frmUsers.Show();
            this.Hide();
        }

        private void bntLogOff_Click(object sender, EventArgs e)
        {
            frmLogin frmLogOff = new frmLogin();
            frmLogOff.Show();
            this.Hide();
        }
    }
}
