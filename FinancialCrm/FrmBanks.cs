using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db =new FinancialCrmDbEntities();
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            var ziraatBankBalance=db.Banks.Where(x =>x.BankTitle=="Ziraat Bankası").Select(y=>y.BankBalance).FirstOrDefault();
            var vakıfBankBalance=db.Banks.Where(x =>x.BankTitle=="Vakıf Bank").Select(y=>y.BankBalance).FirstOrDefault();
            var isBankBalance=db.Banks.Where(x =>x.BankTitle=="İş Bankası").Select(y=>y.BankBalance).FirstOrDefault();

            lblişbankasi.Text=isBankBalance.ToString() + "₺";
            lblvakifbank.Text=vakıfBankBalance.ToString() + "₺";
            lblziraatbank.Text=ziraatBankBalance.ToString() + "₺";

            var bankProcess1=db.BankProcess.OrderByDescending(x=>x.BankProcessId).Take(1).FirstOrDefault();
            lblbankprocess1.Text=bankProcess1.Description+" "+bankProcess1.Amount+" "+bankProcess1.ProcessDate;

            var bankProcess2 = db.BankProcess.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblbankprocess2.Text = bankProcess2.Description + " " + bankProcess2.Amount + " " + bankProcess2.ProcessDate;

            var bankProcess3 = db.BankProcess.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblbankprocess3.Text = bankProcess3.Description + " " + bankProcess3.Amount + " " + bankProcess3.ProcessDate;

            var bankProcess4 = db.BankProcess.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblbankprocess4.Text = bankProcess4.Description + " " + bankProcess4.Amount + " " + bankProcess4.ProcessDate;

            var bankProcess5 = db.BankProcess.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblbankprocess5.Text = bankProcess5.Description + " " + bankProcess5.Amount + " " + bankProcess5.ProcessDate;
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmSpending banks = new FrmSpending();
            banks.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashBoard dashBoard = new FrmDashBoard();
            dashBoard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış yapılıyor...", "Çıkış", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBilling billing = new FrmBilling();
            billing.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories categories = new FrmCategories();
            categories.Show();
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
