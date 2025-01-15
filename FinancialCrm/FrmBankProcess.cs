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
    public partial class FrmBankProcess : Form
    {
        public FrmBankProcess()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories categories = new FrmCategories();
            categories.Show();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks banks = new FrmBanks();
            banks.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBilling billing = new FrmBilling();
            billing.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSpending banks = new FrmSpending();
            banks.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashBoard dashboard = new FrmDashBoard();
            dashboard.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmSettings settings = new FrmSettings();
            settings.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış yapılıyor...", "Çıkış", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void FrmBankProcess_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            var banks = db.Banks.ToList();
            if (banks.Any())
            {
                comboBox1.DisplayMember = "BankTitle"; 
                comboBox1.ValueMember = "BankId";      
                comboBox1.DataSource = banks;          
                comboBox1.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Veritabanında banka kaydı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var values = (from process in db.BankProcess
                          join bank in db.Banks
                          on process.BankId equals bank.BankId
                          select new
                          {
                              process.BankProcessId,
                              process.Description,
                              process.ProcessDate,
                              process.ProcessType,
                              process.Amount,
                              BankName = bank.BankTitle
                          }).ToList();

            dataGridView1.DataSource = values;
        }

        private void BtnBillList_Click(object sender, EventArgs e)
        {
            var values = (from process in db.BankProcess
                          join banks in db.Banks
                          on process.BankId equals banks.BankId
                          select new
                          {
                              process.BankProcessId,
                              process.Description,
                              process.ProcessDate,
                              process.ProcessType,
                              process.Amount,
                              BankName = banks.BankTitle
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void BtnCreateBill_Click(object sender, EventArgs e)
        {
            string description = txt2.Text;
            DateTime date = DateTime.Parse(txt3.Text);
            decimal amount = decimal.Parse(txt4.Text);
            int BankName = int.Parse(comboBox1.SelectedValue.ToString());
            string type = "0";
            if (radioButton1.Checked) { type = radioButton1.Text; }
            else if (radioButton2.Checked) { type = radioButton2.Text; }


            BankProcess BankProces = new BankProcess();
            BankProces.Description = description;
            BankProces.ProcessDate = date;
            BankProces.ProcessType = type;
            BankProces.Amount = amount;
            BankProces.BankId = BankName;
            db.BankProcess.Add(BankProces);
            db.SaveChanges();
            MessageBox.Show("İşlem başarılı bir şekilde sisteme eklendi!", "Banka Hareketleri Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from process in db.BankProcess
                          join banks in db.Banks
                          on process.BankId equals banks.BankId
                          select new
                          {
                              process.BankProcessId,
                              process.Description,
                              process.ProcessDate,
                              process.ProcessType,
                              process.Amount,
                              BankName = banks.BankTitle
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void BtnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt1.Text);
            var removeValue = db.BankProcess.Find(id);
            db.BankProcess.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("İşlem başarılı bir şekilde sistemden silindi!", "Banka Hareketleri Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from process in db.BankProcess
                          join banks in db.Banks
                          on process.BankId equals banks.BankId
                          select new
                          {
                              process.BankProcessId,
                              process.Description,
                              process.ProcessDate,
                              process.ProcessType,
                              process.Amount,
                              BankName = banks.BankTitle
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void BtnUpdateBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt1.Text);
            string description = txt2.Text;
            DateTime date = DateTime.Parse(txt3.Text);
            decimal amount = decimal.Parse(txt4.Text);
            int BankName = int.Parse(comboBox1.SelectedValue.ToString());
            string type = "0";
            if (radioButton1.Checked) { type = radioButton1.Text; }
            else if (radioButton2.Checked) { type = radioButton2.Text; }



            var BankProcess = db.BankProcess.Find(id);
            BankProcess.Description = description;
            BankProcess.ProcessDate = date;
            BankProcess.ProcessType = type;
            BankProcess.Amount = amount;
            BankProcess.BankId = BankName;
            db.SaveChanges();
            MessageBox.Show("İşlem başarılı bir şekilde sistemde güncellendi!", "Banka Hareketleri Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from process in db.BankProcess
                          join banks in db.Banks
                          on process.BankId equals banks.BankId
                          select new
                          {
                              process.BankProcessId,
                              process.Description,
                              process.ProcessDate,
                              process.ProcessType,
                              process.Amount,
                              BankName = banks.BankTitle
                          }).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
