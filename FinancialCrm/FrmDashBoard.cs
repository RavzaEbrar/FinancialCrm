using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmDashBoard : Form
    {
        public FrmDashBoard()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        int count = 0;
        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString()+"₺";

            var lastBankProcessAmount =db.BankProcess.OrderByDescending(x=>x.BankProcessId).Take(1).Select(y=>y.Amount).FirstOrDefault();
            lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + "₺";

            var bankData = db.Banks.Select(x =>new
            { 
                x.BankTitle,
                x.BankBalance,
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach(var item in bankData)
            {
                series.Points.AddXY(item.BankTitle,item.BankBalance);
            }
            var billData = db.Bills.Select(x=>new
            {
                x.BillTitle,
                x.BillAmount,
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType=System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko; 
            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle,item.BillAmount);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 4==1)
            {
                var elektrikfaturasi = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y=>y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text=elektrikfaturasi.ToString()+"₺";
            }
            if (count % 4 == 2)
            {
                var dogalgazfaturasi = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = dogalgazfaturasi.ToString() + "₺";
            }
            if (count % 4 == 3)
            {
                var sufaturasi = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturası";
                lblBillAmount.Text = sufaturasi.ToString() + "₺";
            }
            if (count % 4 == 0)
            {
                var internetfaturasi = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "İnternet Faturası";
                lblBillAmount.Text = internetfaturasi.ToString() + "₺";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBanks banks = new FrmBanks();
            banks.Show();
           
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmSpending banks = new FrmSpending();
            banks.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış yapılıyor...", "Çıkış", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories categories = new FrmCategories();
            categories.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBilling billing = new FrmBilling();
            billing.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBankProcess bankProcess = new FrmBankProcess();
            bankProcess.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmSettings settings = new FrmSettings();
            settings.Show();
        }
    }
}
