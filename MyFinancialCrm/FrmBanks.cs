using MyFinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Globalization; // Eklenen kısım

namespace MyFinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        private void FrmBanksReal_Load(object sender, EventArgs e)
        {
            try
            {
                var banks = db.Banks.ToList();

                foreach (var bank in banks)
                {
                    string title = bank.BankTitle.ToLower(new CultureInfo("tr-TR")).Trim(); // Türkçe kültürle küçük harfe çevir
                    string balanceText = ((decimal)bank.BankBalance).ToString("C2"); // ₺ formatlı yaz

                    if (title.Contains("ziraat"))
                        lblZiraatBankBalance.Text = balanceText;
                    else if (title.Contains("vakıf"))
                        lblVakıfBankBalance.Text = balanceText;
                    else if (title.Contains("iş") || title.Contains("is")) // her ihtimale karşı
                        lblIsBankBalance.Text = balanceText;
                    else if (title.Contains("akbank"))
                        lblAkbankBalance.Text = balanceText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // opsiyonel buton
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // opsiyonel buton
        }

        private FinancialCrmDbEntities1 GetDb()
        {
            return db;
        }

        private void panel5_Paint(object sender, PaintEventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void panel6_Paint(object sender, PaintEventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void lblZiraatBankBalance_Click(object sender, EventArgs e) { }

        private void lblAkbankBalance_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void button7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {

            FrmBills frm = new FrmBills();
            frm.Show();
            this.Hide();
        }

        private void btnDashorard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSpendingForm_Click(object sender, EventArgs e)
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

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }
    }
}
