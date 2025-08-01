using MyFinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        private void FrmCategories_Load(object sender, EventArgs e)
        {
            var values = db.dbo_Categories.Select(s => new
            {
                s.CategoryId,
                s.CategoryName,
                SpendingTotal = s.Spendings.Sum(x => (decimal?)x.SpendingAmount) ?? 0,
                BillsTotal = s.Bills.Sum(x => (decimal?)x.BillAmount) ?? 0,
                TotalSpending =
         (s.Spendings.Sum(x => (decimal?)x.SpendingAmount) ?? 0) +
         (s.Bills.Sum(x => (decimal?)x.BillAmount) ?? 0)
            }).ToList();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = values;


        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBills frm = new FrmBills();
            frm.Show();
            this.Hide();
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            FrmSpending frm = new FrmSpending();    
            frm.Show();
            this.Hide();
        }

        private void btnBankProcesses_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frm = new FrmBankProcesses();
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
