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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db= new FinancialCrmDbEntities();
        private void FrmCategories_Load(object sender, EventArgs e)
        {
            var values = (from category in db.Categories
                          select new
                          {
                              category.CategoryId,
                              category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;
        }
        private void BtnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }
        private void BtnCreateBill_Click(object sender, EventArgs e)
        {
            string name = text2.Text;

            Categories categories = new Categories();
            categories.CategoryName = name;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir şekilde sisteme eklendi");

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }
        private void BtnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(text1.Text);
            var removeValue = db.Categories.Find(id);
            db.Categories.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir şekilde sistemden silindi ");

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }
        private void BtnUpdateBill_Click(object sender, EventArgs e)
        {
            string name = text2.Text;
            int id = int.Parse(text1.Text);

            var values = db.Categories.Find(id);

            values.CategoryName = name;

            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir şekilde sistemde Güncellendi");

            var values2 = db.Categories.ToList();
            dataGridView1.DataSource = values2;
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
        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashBoard dashBoard = new FrmDashBoard();
            dashBoard.Show();
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
