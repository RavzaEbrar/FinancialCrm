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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
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

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBankProcess bankProcess = new FrmBankProcess();
            bankProcess.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashBoard dashboard = new FrmDashBoard();
            dashboard.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış yapılıyor...", "Çıkış", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt1.Text);
            string username = txt2.Text;
            string password1 = txt3.Text;
            string password2 = txt4.Text;

            if (password1 == password2)
            {
                var users = db.Users.Find(id);
                if (users.UserId == id && users.UserName == username)
                {
                    users.Password = password1;
                    db.SaveChanges();
                    MessageBox.Show("Kullanıcı bilgileri başarılı bir şekilde güncellendi!", "Kullanıcı Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya ID hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
