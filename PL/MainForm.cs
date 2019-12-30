using System;
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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        string role;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string role)
        {
            InitializeComponent();
            this.role = role;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //BL.Login.InsertButtonName btn = new BL.Login.InsertButtonName();
            //btn.InsertBtnName(this);
            //foreach (var btn in this.Controls.OfType<Bunifu.Framework.UI.BunifuThinButton2>())
            //{
            //    btn.Enabled = false;
            //}
            //foreach (var btn in this.Controls.OfType<Bunifu.Framework.UI.BunifuTileButton>())
            //{
            //    btn.Enabled = false;
            //}
            //foreach (var btn in this.Controls.OfType<Bunifu.Framework.UI.BunifuFlatButton>())
            //{
            //    btn.Enabled = false;
            //}

            //BtnServices.Enabled = false;

            if(role != "admin")
            {
                BtnLogo.Enabled = false;
            }

        }

        private void BtnCash_Click(object sender, EventArgs e)
        {
            PL.DirSales cash = new DirSales();
            cash.Show();
        }

        private void BtnUncash_Click(object sender, EventArgs e)
        {
            PL.documens UnCash = new documens();
            UnCash.Show();
        }

   

        private void BtnInventory_Clic(object sender, EventArgs e)
        {
            PL.Inventory inve = new Inventory();
            inve.ShowDialog();
        }

        private void BtnSupliers_Click(object sender, EventArgs e)
        {
            PL.Companies entry = new Companies();
            entry.ShowDialog();
        }

        private void BtnCash_Click_1(object sender, EventArgs e)
        {
            PL.DirSales frm = new DirSales();
             
            frm.ShowDialog();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            PL.listInvoice frm = new listInvoice();
            frm.ShowDialog();
        }

        private void BtnSummary_Click(object sender, EventArgs e)
        {
            PL.customerForm frm = new customerForm();
            frm.ShowDialog();
        }

        private void BtnStockTackout_Click(object sender, EventArgs e)
        {
            PL.StockTakeout frm = new StockTakeout();
            frm.ShowDialog();
        }

        private void BtnManagement_Click(object sender, EventArgs e)
        {
            PL.stores frm = new stores();
            frm.ShowDialog();
        }

        private void BtnCosts_Click(object sender, EventArgs e)
        {
            PL.services frm = new services();
            frm.ShowDialog();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            PL.Invoice.NurseryDocument frm = new Invoice.NurseryDocument();
            frm.ShowDialog();
        }

        private void Btninsert_Click(object sender, EventArgs e)
        {
            PL.DataEntry frm = new DataEntry();
            frm.ShowDialog();
        }

        private void BtnUncash_Click_1(object sender, EventArgs e)
        {
            PL.OfficeReceipt frm = new OfficeReceipt();
            frm.ShowDialog();
        }

     

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            PL.listDocument frm = new listDocument();
            frm.ShowDialog();
        }

        private void BtnServeQuery_Click(object sender, EventArgs e)
        {
            PL.ServiceList frm = new ServiceList();
            frm.ShowDialog();
        }

        private void BtnLogo_Click(object sender, EventArgs e)
        {
            PL.Cpanel frm = new Cpanel();
            frm.ShowDialog();
        }
    }
}
