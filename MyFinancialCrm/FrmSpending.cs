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
    public partial class FrmSpending : Form
    {
        public FrmSpending()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        private void FrmBills_Load(object sender, EventArgs e)
        {
          
        }

        private void FrmSpending_Load(object sender, EventArgs e)
        {
            var values = db.Spendings
                .Include("dbo_Categories")
                .Select(s => new
                {
                    s.SpendingId,
                    s.SpendingTitle,
                    s.SpendingAmount,
                    s.SpendingDate,
                    CategoryName = s.dbo_Categories.CategoryName
                }).ToList();
            dataGridView1.DataSource = values;
                
             
            var maxSpending = db.Spendings.Max(x => x.SpendingAmount);
            lblMaxSpending.Text = maxSpending.Value.ToString("N2")+"₺";

            var avgSpending = db.Spendings.Average(x => x.SpendingAmount);
            lblAvgSpending.Text = avgSpending.Value.ToString("N2") + " ₺";

            var maxSpendingCategory = db.Spendings.OrderByDescending(x=> x.SpendingAmount).Select(x=>x.dbo_Categories.CategoryName).FirstOrDefault();

            lblMaxSpendingCategory.Text = maxSpendingCategory.ToString();

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();

        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBills frmBills = new FrmBills();
            frmBills.Show();
            this.Hide();
        }

        private void btnDashorard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frm = new FrmBankProcesses();
            frm.Show();
            this.Hide();
        }
    }
}
