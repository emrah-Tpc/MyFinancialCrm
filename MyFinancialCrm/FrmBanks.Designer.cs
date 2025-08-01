using System;
using System.Linq;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    partial class FrmBanks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblBankProcess5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBankProcess4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBankProcess3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBankProcess2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBankProcess1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.btnDashorard = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSpendingForm = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblVakıfBankBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblZiraatBankBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAkbankBalance = new System.Windows.Forms.Label();
            this.lblakbank = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblIsBankBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1621, 68);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Form";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblBankProcess5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblBankProcess4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblBankProcess3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblBankProcess2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblBankProcess1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(216, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 368);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Last 5 Bank Process";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(2, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1069, 28);
            this.label14.TabIndex = 0;
            this.label14.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------------------------";
            this.label14.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblBankProcess5
            // 
            this.lblBankProcess5.AutoSize = true;
            this.lblBankProcess5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankProcess5.Location = new System.Drawing.Point(6, 270);
            this.lblBankProcess5.Name = "lblBankProcess5";
            this.lblBankProcess5.Size = new System.Drawing.Size(64, 28);
            this.lblBankProcess5.TabIndex = 0;
            this.lblBankProcess5.Text = "Text5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(2, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1069, 28);
            this.label12.TabIndex = 0;
            this.label12.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------------------------";
            this.label12.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblBankProcess4
            // 
            this.lblBankProcess4.AutoSize = true;
            this.lblBankProcess4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankProcess4.Location = new System.Drawing.Point(6, 215);
            this.lblBankProcess4.Name = "lblBankProcess4";
            this.lblBankProcess4.Size = new System.Drawing.Size(64, 28);
            this.lblBankProcess4.TabIndex = 0;
            this.lblBankProcess4.Text = "Text4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(2, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1069, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------------------------";
            this.label10.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblBankProcess3
            // 
            this.lblBankProcess3.AutoSize = true;
            this.lblBankProcess3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankProcess3.Location = new System.Drawing.Point(6, 160);
            this.lblBankProcess3.Name = "lblBankProcess3";
            this.lblBankProcess3.Size = new System.Drawing.Size(64, 28);
            this.lblBankProcess3.TabIndex = 0;
            this.lblBankProcess3.Text = "Text3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(2, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1069, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------------------------";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblBankProcess2
            // 
            this.lblBankProcess2.AutoSize = true;
            this.lblBankProcess2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankProcess2.Location = new System.Drawing.Point(6, 103);
            this.lblBankProcess2.Name = "lblBankProcess2";
            this.lblBankProcess2.Size = new System.Drawing.Size(64, 28);
            this.lblBankProcess2.TabIndex = 0;
            this.lblBankProcess2.Text = "Text2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(2, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1069, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------------------------";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblBankProcess1
            // 
            this.lblBankProcess1.AutoSize = true;
            this.lblBankProcess1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankProcess1.Location = new System.Drawing.Point(6, 45);
            this.lblBankProcess1.Name = "lblBankProcess1";
            this.lblBankProcess1.Size = new System.Drawing.Size(64, 28);
            this.lblBankProcess1.TabIndex = 0;
            this.lblBankProcess1.Text = "Text1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btnDashorard);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnSpendingForm);
            this.panel1.Controls.Add(this.btnBills);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 728);
            this.panel1.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 5;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(18, 505);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(176, 53);
            this.button7.TabIndex = 0;
            this.button7.Text = "Exit";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // btnDashorard
            // 
            this.btnDashorard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDashorard.FlatAppearance.BorderSize = 5;
            this.btnDashorard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashorard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashorard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashorard.Location = new System.Drawing.Point(18, 430);
            this.btnDashorard.Name = "btnDashorard";
            this.btnDashorard.Size = new System.Drawing.Size(176, 53);
            this.btnDashorard.TabIndex = 0;
            this.btnDashorard.Text = "Dashboard";
            this.btnDashorard.UseVisualStyleBackColor = true;
            this.btnDashorard.Click += new System.EventHandler(this.btnDashorard_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 5;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(18, 351);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 53);
            this.button5.TabIndex = 0;
            this.button5.Text = "Bank Processes";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSpendingForm
            // 
            this.btnSpendingForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSpendingForm.FlatAppearance.BorderSize = 5;
            this.btnSpendingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpendingForm.Location = new System.Drawing.Point(18, 272);
            this.btnSpendingForm.Name = "btnSpendingForm";
            this.btnSpendingForm.Size = new System.Drawing.Size(176, 53);
            this.btnSpendingForm.TabIndex = 0;
            this.btnSpendingForm.Text = "Spendings";
            this.btnSpendingForm.UseVisualStyleBackColor = true;
            this.btnSpendingForm.Click += new System.EventHandler(this.btnSpendingForm_Click);
            // 
            // btnBills
            // 
            this.btnBills.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBills.FlatAppearance.BorderSize = 5;
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBills.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBills.Location = new System.Drawing.Point(18, 191);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(176, 53);
            this.btnBills.TabIndex = 0;
            this.btnBills.Text = "Bills";
            this.btnBills.UseVisualStyleBackColor = true;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBanksForm.FlatAppearance.BorderSize = 5;
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBanksForm.Location = new System.Drawing.Point(18, 112);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(176, 53);
            this.btnBanksForm.TabIndex = 0;
            this.btnBanksForm.Text = "Banks";
            this.btnBanksForm.UseVisualStyleBackColor = true;
            // 
            // btnCategories
            // 
            this.btnCategories.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCategories.FlatAppearance.BorderSize = 5;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCategories.Location = new System.Drawing.Point(18, 33);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(176, 53);
            this.btnCategories.TabIndex = 0;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel8.Controls.Add(this.panel6);
            this.panel8.Controls.Add(this.panel3);
            this.panel8.Controls.Add(this.panel5);
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Location = new System.Drawing.Point(220, 75);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1005, 158);
            this.panel8.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gold;
            this.panel6.Controls.Add(this.lblVakıfBankBalance);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(755, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 132);
            this.panel6.TabIndex = 7;
            // 
            // lblVakıfBankBalance
            // 
            this.lblVakıfBankBalance.AutoSize = true;
            this.lblVakıfBankBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVakıfBankBalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVakıfBankBalance.Location = new System.Drawing.Point(19, 57);
            this.lblVakıfBankBalance.Name = "lblVakıfBankBalance";
            this.lblVakıfBankBalance.Size = new System.Drawing.Size(136, 46);
            this.lblVakıfBankBalance.TabIndex = 0;
            this.lblVakıfBankBalance.Text = "0.00 ₺";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "VakıfBank";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.lblZiraatBankBalance);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 132);
            this.panel3.TabIndex = 10;
            // 
            // lblZiraatBankBalance
            // 
            this.lblZiraatBankBalance.AutoSize = true;
            this.lblZiraatBankBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZiraatBankBalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblZiraatBankBalance.Location = new System.Drawing.Point(63, 57);
            this.lblZiraatBankBalance.Name = "lblZiraatBankBalance";
            this.lblZiraatBankBalance.Size = new System.Drawing.Size(136, 46);
            this.lblZiraatBankBalance.TabIndex = 0;
            this.lblZiraatBankBalance.Text = "0.00 ₺";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ziraat Bank";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Chocolate;
            this.panel5.Controls.Add(this.lblAkbankBalance);
            this.panel5.Controls.Add(this.lblakbank);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(512, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 132);
            this.panel5.TabIndex = 8;
            // 
            // lblAkbankBalance
            // 
            this.lblAkbankBalance.AutoSize = true;
            this.lblAkbankBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAkbankBalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAkbankBalance.Location = new System.Drawing.Point(3, 57);
            this.lblAkbankBalance.Name = "lblAkbankBalance";
            this.lblAkbankBalance.Size = new System.Drawing.Size(136, 46);
            this.lblAkbankBalance.TabIndex = 0;
            this.lblAkbankBalance.Text = "0.00 ₺";
            // 
            // lblakbank
            // 
            this.lblakbank.AutoSize = true;
            this.lblakbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblakbank.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblakbank.Location = new System.Drawing.Point(3, 7);
            this.lblakbank.Name = "lblakbank";
            this.lblakbank.Size = new System.Drawing.Size(115, 32);
            this.lblakbank.TabIndex = 0;
            this.lblakbank.Text = "Akbank";
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(-252, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(246, 132);
            this.panel7.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Controls.Add(this.lblIsBankBalance);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(260, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(246, 132);
            this.panel4.TabIndex = 9;
            // 
            // lblIsBankBalance
            // 
            this.lblIsBankBalance.AutoSize = true;
            this.lblIsBankBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsBankBalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIsBankBalance.Location = new System.Drawing.Point(28, 57);
            this.lblIsBankBalance.Name = "lblIsBankBalance";
            this.lblIsBankBalance.Size = new System.Drawing.Size(136, 46);
            this.lblIsBankBalance.TabIndex = 0;
            this.lblIsBankBalance.Text = "0.00 ₺";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "İş Bank";
            // 
            // FrmBanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1252, 635);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmBanks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banks Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBanks_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            #region BankBalance
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bank").Select(y => y.BankBalance).FirstOrDefault();
            var vakıfBankBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıf Bank").Select(y => y.BankBalance).FirstOrDefault();
            var isBankBankBalance = db.Banks.Where(x => x.BankTitle == "İş Bank").Select(y => y.BankBalance).FirstOrDefault();
            var akBankBankBalance = db.Banks.Where(x => x.BankTitle == "Akbank").Select(y => y.BankBalance).FirstOrDefault();

            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + "₺";
            lblVakıfBankBalance.Text = vakıfBankBankBalance.ToString() + "₺";
            lblIsBankBalance.Text = isBankBankBalance.ToString() + "₺";
            lblAkbankBalance.Text = akBankBankBalance.ToString() + "₺";
            #endregion

            #region BankProcesses

            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = "1." + bankProcess1.Description + " / " + bankProcess1.Amount+" ₺" + " / " + bankProcess1.ProcesDate;

            var bankProcess2 =  db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = "2." + bankProcess2.Description + " / " + bankProcess2.Amount +" ₺"+" / " + bankProcess2.ProcesDate;

            var bankProcess3 =  db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = "3." + bankProcess3.Description + " / " + bankProcess3.Amount + " ₺" + " / " + bankProcess3.ProcesDate;

            var bankProcess4 =  db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = "4." + bankProcess4.Description + " / " + bankProcess4.Amount + " ₺" + " / " + bankProcess4.ProcesDate;

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = "5." + bankProcess5.Description + " / " + bankProcess5.Amount + " ₺" + " / " + bankProcess5.ProcesDate;

            #endregion
        }




        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Label label6;
        private Label lblBankProcess1;
        private Label label14;
        private Label lblBankProcess5;
        private Label label12;
        private Label lblBankProcess4;
        private Label label10;
        private Label lblBankProcess3;
        private Label label8;
        private Label lblBankProcess2;
        private Panel panel1;
        private Button button7;
        private Button btnDashorard;
        private Button button5;
        private Button btnSpendingForm;
        private Button btnBills;
        private Button btnBanksForm;
        private Button btnCategories;
        private Panel panel8;
        private Panel panel6;
        private Label lblVakıfBankBalance;
        private Label label5;
        private Panel panel3;
        private Label lblZiraatBankBalance;
        private Label label2;
        private Panel panel5;
        private Label lblAkbankBalance;
        private Label lblakbank;
        private Panel panel7;
        private Panel panel4;
        private Label lblIsBankBalance;
        private Label label4;
    }
}