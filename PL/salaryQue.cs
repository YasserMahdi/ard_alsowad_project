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
    public partial class salaryQue : Form
    {
        BL.Expenses exp = new BL.Expenses();
        public salaryQue()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = exp.selSalary();
        }
    }
}
