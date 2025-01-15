using System;
using System.Linq;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db =new FinancialCrmDbEntities();
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values =db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void BtnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void BtnCreateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount =decimal.Parse(txtBillAmount.Text);
            string period =txtBillPeriod.Text;

            Bills bills = new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir şekilde sisteme eklendi");

            var values = db.Bills.ToList();
            dataGridView1.DataSource=values;
        }

        private void BtnRemoveBill_Click(object sender, EventArgs e)
        {
            int id =int.Parse( txtBillId.Text);
            var removeValue=db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir şekilde sistemden silindi ");

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void BtnUpdateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;
            int id = int.Parse(txtBillId.Text);

            var values=db.Bills.Find(id);

            values.BillTitle = title;
            values.BillAmount = amount;
            values.BillPeriod = period;
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir şekilde sistemde Güncellendi");

            var values2 = db.Bills.ToList();
            dataGridView1.DataSource = values2;
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks banks = new FrmBanks();
            banks.Show();
         
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashBoard dashBoard = new FrmDashBoard();
            dashBoard.Show();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            
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
