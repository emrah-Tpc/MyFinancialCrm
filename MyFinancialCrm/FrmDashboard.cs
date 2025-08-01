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
    public partial class FrmDashboard : Form
    {
        int  count = 0;    
        public FrmDashboard()
        {
            InitializeComponent();
        }
            FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();    
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + "₺";

            #region chart1 codes 

            var bankdata = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance

            }).ToList();
            chart2.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach (var item in bankdata) { 
            series.Points.AddXY(item.BankTitle,item.BankBalance);
            }

            #endregion
            #region chart2 codes 
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();

            chart2.Series.Clear();

            var series2 = chart2.Series.Add("Bills");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            // 🔹 Etiketleri göster ve dışarı al
            series2.IsValueShownAsLabel = true;
            series2["PieLabelStyle"] = "Outside";

            // 🔹 Smart Label aktif et (üst üste binmeyi engeller)
            series2.SmartLabelStyle.Enabled = true;
            series2.SmartLabelStyle.AllowOutsidePlotArea =
                System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series2.SmartLabelStyle.IsOverlappedHidden = false;

            // 🔹 Küçük dilimleri gruplayabilirsin (Opsiyonel)
            series2["CollectedThreshold"] = "5"; // %5 altını grupla
            series2["CollectedThresholdUsePercent"] = "true";
            series2["CollectedLabel"] = "Other";

            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }


            #endregion
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 4 == 1) 
            { 
            
                var bill1 = db.Bills.Where(x=> x.BillTitle== "Pc Debt").Select(y=> y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Pc Debt";
                lblBillAmount.Text = bill1.ToString()+"₺";
            }

            if (count % 4 == 2)
            {

                var bill2 = db.Bills.Where(x => x.BillTitle == "Natural gas Bill").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Natural gas Bill";
                lblBillAmount.Text = bill2.ToString() + "₺";
            }
            if (count % 4 == 3)
            {

                var bill3 = db.Bills.Where(x => x.BillTitle == "Water Bill").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Water Bill";
                lblBillAmount.Text = bill3.ToString() + "₺";
            }
            if (count % 5 == 4)
            {

                var bill4 = db.Bills.Where(x => x.BillTitle == "Rent a Car Bill").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Rent a Car Bill";
                lblBillAmount.Text = bill4.ToString() + "₺";
            }
            if (count % 5 == 0)
            {

                var bill5 = db.Bills.Where(x => x.BillTitle == "Internet Bill").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Internet Bill";
                lblBillAmount.Text = bill5.ToString() + "₺";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 4 == 1)
            {

                var spend1 = db.Spendings.Where(x => x.SpendingTitle == "Migros Shopping").Select(y => y.SpendingAmount).FirstOrDefault();
                lblSpendsTitle.Text = "Migros Shopping";
                lblSpendsAmount.Text = spend1.ToString() + "₺";
            }

            if (count % 4 == 2)
            {

                var spend2 = db.Spendings.Where(x => x.SpendingTitle == "Bottled Water").Select(y=> y.SpendingAmount).FirstOrDefault();
                lblSpendsTitle.Text = "Bottled Water";
                lblSpendsAmount.Text = spend2.ToString() + "₺";
            }
            if (count % 4 == 3)
            {

                var spend3 = db.Spendings.Where(x => x.SpendingTitle == "Monthly Akbil").Select(y => y.SpendingAmount).FirstOrDefault();
                lblSpendsTitle.Text = "Monthly Akbil";
                lblSpendsAmount.Text = spend3.ToString() + "₺";
            }
            if (count % 5 == 4)
            {

                var spend4 = db.Spendings.Where(x => x.SpendingTitle == "Cup of Coffe").Select(y => y.SpendingAmount).FirstOrDefault();
                lblSpendsTitle.Text = "Cup of Coffe";
                lblSpendsAmount.Text = spend4.ToString() + "₺";
            }
            if (count % 5 == 0)
            {

                var spend5 = db.Spendings.Where(x => x.SpendingTitle == "Clothes Shopping").Select(y => y.SpendingAmount).FirstOrDefault();
                lblSpendsTitle.Text = "Clothes Shopping";
                lblSpendsAmount.Text = spend5.ToString() + "₺";
            }
        }

        private void lblLastBankProcess_Click(object sender, EventArgs e)
        {
            var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Select(y=> y.Amount).FirstOrDefault();
            lblLastBankProcess.Text = lastBankProcessAmount.ToString() + "₺";

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();

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

        private void lblSpendsAmount_Click(object sender, EventArgs e)
        {

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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }
    }
}
