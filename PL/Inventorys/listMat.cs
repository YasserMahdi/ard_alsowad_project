﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFarmer.PL
{
    public partial class listMat : MetroFramework.Forms.MetroForm
    {
        BL.inputClass sam = new BL.inputClass();
        public listMat()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = sam.getMatirialInfo();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void listMat_Load(object sender, EventArgs e)
        {

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = sam.searchMat(TxtSearch.Text);
        }
    }
}
