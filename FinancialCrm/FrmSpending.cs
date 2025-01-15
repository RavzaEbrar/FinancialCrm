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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FinancialCrm
{
    public partial class FrmSpending : Form
    {
        public FrmSpending()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db=new FinancialCrmDbEntities();

        private void FrmSpending_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            var categorys = db.Categories.ToList();
            if (categorys.Any())
            {
                comboBox1.DisplayMember = "CategoryName";
                comboBox1.ValueMember = "CategoryId";
                comboBox1.DataSource = categorys;
                comboBox1.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Veritabanında banka kaydı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //this.categoriesTableAdapter.Fill(this.dBFinancialCRMDataSet.Categories);
            var values = (from spending in db.Spending
                          join category in db.Categories
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingAmount,
                              spending.SpendingDate,
                              CategoryName = category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;

            //this.categoriesTableAdapter.Fill(this.dBFinancialCRMDataSet.Categories);
            //var values = (from spending in db.Spending
            //              join category in db.Categories
            //              on spending.CategoryId equals category.CategoryId
            //              select new
            //              {
            //                  spending.SpendingId,
            //                  spending.SpendingTitle,
            //                  spending.SpendingAmount,
            //                  spending.SpendingDate,
            //                  CategoryName = category.CategoryName
            //              }).ToList();
            //dataGridView1.DataSource = values;
        }

        private void BtnBillList_Click(object sender, EventArgs e)
        {
            var values = (from spending in db.Spending
                          join category in db.Categories
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingAmount,
                              spending.SpendingDate,
                              CategoryName = category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;
        }
        private void BtnCreateBill_Click(object sender, EventArgs e)
        {
            
            string title = txt2.Text;
            decimal amount = decimal.Parse(txt3.Text);
            int CategoryName = int.Parse(comboBox1.SelectedValue.ToString());
            DateTime date = Convert.ToDateTime(txt4.Text);
            int categoryName = int.Parse(comboBox1.SelectedValue.ToString());

            Spending spendings = new Spending();
            spendings.SpendingTitle = title;
            spendings.SpendingAmount = amount;
            spendings.SpendingDate = date;
            spendings.CategoryId = categoryName;
            db.Spending.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Harcama başarılı bir şekilde sisteme eklendi!", "Giderler Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from spending in db.Spending
                          join category in db.Categories
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingAmount,
                              spending.SpendingDate,
                              CategoryName = category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;
        }
        private void BtnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt1.Text);
            var removeValue = db.Spending.Find(id);
            db.Spending.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Harcama başarılı bir şekilde sistemden silindi!", "Giderler Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from spending in db.Spending
                          join category in db.Categories
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingAmount,
                              spending.SpendingDate,
                              CategoryName = category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void BtnUpdateBill_Click(object sender, EventArgs e)
        {
          
            int id = int.Parse(txt1.Text);
            string title = txt2.Text;
            decimal amount = decimal.Parse(txt3.Text); 
            DateTime date = Convert.ToDateTime(txt4.Text);
            int categoryName = int.Parse(comboBox1.SelectedValue.ToString());


            var spendings = db.Spending.Find(id);
            spendings.SpendingTitle = title;
            spendings.SpendingAmount = amount;
            spendings.SpendingDate = date;
            spendings.CategoryId = categoryName;
            db.SaveChanges();
            MessageBox.Show("Harcama başarılı bir şekilde sistemde güncellendi!", "Giderler Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from spending in db.Spending
                          join category in db.Categories
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingAmount,
                              spending.SpendingDate,
                              CategoryName = category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;
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
