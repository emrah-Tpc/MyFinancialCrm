using System;
using System.Linq;
using System.Windows.Forms;
using MyFinancialCrm.Models;
namespace MyFinancialCrm
{
    public partial class FrmBills : Form
    {
        public FrmBills()
        {
            InitializeComponent();
        } 
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmBills_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillPayment_Click(object sender, EventArgs e)
        {
             string title = txtBıllTitle.Text;
            decimal amount = decimal.Parse(txtBıllAmount.Text);
            string period = txtBıllPeriot.Text;

            
            Bills bills = new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Payment Inserting Procces is succesfull!","Payment & Bills" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBıllId.Text);
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Payment Deleting Procces is succesfull!", "Payment & Bills", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            string title = txtBıllTitle.Text;
            decimal amount = decimal.Parse(txtBıllAmount.Text);
            string period = txtBıllPeriot.Text;

            int id = int.Parse(txtBıllId.Text);
            var values = db.Bills.Find(id);
            values.BillTitle = title;
            values.BillAmount = amount;
            values.BillPeriod = period;
            db.SaveChanges();
            MessageBox.Show("Payment Updating Procces is succesfull!", "Payment & Bills", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values2 = db.Bills.ToList();
            dataGridView1.DataSource = values2;
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnDashborad_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSpending frm = new FrmSpending();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frm = new FrmBankProcesses();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }
    }
}
