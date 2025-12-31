using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private void FrmBankProcess_Load(object sender, EventArgs e)
        {
            var values = db.BankProcesses.Select(x => new
            {
                x.BankProcessId,
                x.Description,
                x.ProcessDate,
                x.ProcessType,
                x.Amount,
                x.Banks.BankId,
                x.Banks.BankTitle
            });
            dataGridView1.DataSource = values.ToList();

            // Bankaları comboboxda görüntülemek için
            cmbBanks.DataSource = db.Banks.ToList();
            cmbBanks.DisplayMember = "bankTitle"; // kullanıcıya görünen
            cmbBanks.ValueMember = "BankId";     // arkada tutulan
        }

        private void btnBankProcessList_Click(object sender, EventArgs e)
        {
            var values = db.BankProcesses.Select(x => new
            {
                x.BankProcessId,
                x.Description,
                x.ProcessDate,
                x.ProcessType,
                x.Amount,
                x.Banks.BankId,
                x.Banks.BankTitle
            });
            dataGridView1.DataSource = values.ToList();
        }

        private void btnCreateBankProcess_Click(object sender, EventArgs e)
        {
            BankProcesses process = new BankProcesses();
            process.Description = txtBankProcessDescription.Text;
            process.Amount = decimal.Parse(txtBankProcessAmount.Text);
            process.ProcessDate = dateTimePicker1.Value.Date;
            if (rdBtnGelenHavale.Checked) process.ProcessType = "Gelen Havale";
            if (rdBtnGidenHavale.Checked) process.ProcessType = "Giden Havale";
            process.BankId = (int)cmbBanks.SelectedValue;

            db.BankProcesses.Add(process);
            db.SaveChanges();
            
            MessageBox.Show("Hareket Başarılı Bir Şekilde Sisteme Eklendi", "Banka Hareketleri", MessageBoxButtons.OK, MessageBoxIcon.Information);


            var values = db.BankProcesses.Select(x => new
            {
                x.BankProcessId,
                x.Description,
                x.ProcessDate,
                x.ProcessType,
                x.Amount,
                x.Banks.BankId,
                x.Banks.BankTitle
            });
            dataGridView1.DataSource = values.ToList();
        }

        private void btnRemoveBankProcess_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBankProcessId.Text);
            var removeValue = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Hareket Başarılı Bir Şekilde Sistemden Silindi", "Banka Hareketleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.BankProcesses.Select(x => new
            {
                x.BankProcessId,
                x.Description,
                x.ProcessDate,
                x.ProcessType,
                x.Amount,
                x.Banks.BankId,
                x.Banks.BankTitle
            });
            dataGridView1.DataSource = values.ToList();
        }

        private void btnUpdateBankProcess_Click(object sender, EventArgs e)
        {
            string processType;
            int id = int.Parse(txtBankProcessId.Text);
            string description = txtBankProcessDescription.Text;
            decimal amount = decimal.Parse(txtBankProcessAmount.Text);
            DateTime date = dateTimePicker1.Value.Date;
            if (rdBtnGidenHavale.Checked)
            {
                processType = "Giden Havale";
            }
            else 
            {
                processType = "Gelen Havale"; //Varsayılan olarak Gelen Havale
            }
            int bankId = (int)cmbBanks.SelectedValue;

            var values = db.BankProcesses.Find(id);

            values.Description = description;
            values.Amount = amount;
            values.ProcessDate = date;
            values.ProcessType = processType;
            values.BankId = bankId;
            db.SaveChanges();
            MessageBox.Show("Hareket Başarılı Bir Şekilde Sistemde Güncellendi", "Harcama & Gider", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.BankProcesses.Select(x => new
            {
                x.BankProcessId,
                x.Description,
                x.ProcessDate,
                x.ProcessType,
                x.Amount,
                x.Banks.BankId,
                x.Banks.BankTitle
            });
            dataGridView1.DataSource = values2.ToList();
        }

        private void btnFilterByDate_Click(object sender, EventArgs e)
        {
            var values2 = db.BankProcesses.Select(x => new
            {
                x.BankProcessId,
                x.Description,
                x.ProcessDate,
                x.ProcessType,
                x.Amount,
                x.Banks.BankId,
                x.Banks.BankTitle
            }).Where(y=>y.ProcessDate >= dateTimePicker1.Value.Date && y.ProcessDate <= dateTimePicker2.Value.Date);
            dataGridView1.DataSource = values2.ToList();
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

        private void BtnSpendingsForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
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

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Show();
            this.Hide();
        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }
    }
}
