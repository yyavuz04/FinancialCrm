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
        private void btnUpdateUserSettings_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUserId.Text);
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string password2 = txtPasswordAgain.Text;



            if (password == password2)
            {
                var values = db.Users.Find(id);
                if (values.UserId == id && values.Username == userName)
                {
                    values.Password = password;
                    db.SaveChanges();
                    MessageBox.Show("Şifreniz başarılı bir şekilde değiştirildi", "Kullanıcı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya id hatalı", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Girdiğiniz şifreler aynı değil", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnSpendingsForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }

        private void btnBankProcessForm_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
            this.Hide();
        }

        private void btnDashBoardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnQuitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
