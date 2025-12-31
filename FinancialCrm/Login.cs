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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text, out int id))
            {
                MessageBox.Show("Kullanıcı ID sayı olmalıdır", "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string password = txtUserPassword.Text;

            var user = db.Users
                .FirstOrDefault(x => x.UserId == id && x.Password == password);

            if (user == null)
            {
                MessageBox.Show(
                    "Kullanıcı ID veya Şifre hatalı!",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }
    }
}

