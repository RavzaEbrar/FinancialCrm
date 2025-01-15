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
    public partial class Frmgiris : Form
    {
        public Frmgiris()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void Frmgiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            var user = db.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);

            if (user != null)
            {
                MessageBox.Show("Giriş başarılı!");
                FrmCategories frmCategories = new FrmCategories();
                frmCategories.ShowDialog();

            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre!");
            }
        }
    }
}
