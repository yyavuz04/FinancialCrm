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
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnSpendingList_Click(object sender, EventArgs e)
        {
            var values = db.Spendings.Select(x => new
            {
                x.SpendingId,
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate,
                x.CategoryId,
                x.Categories.CategoryName
            });
            dataGridView1.DataSource = values.ToList();


        }

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            var values = db.Spendings.Select(x => new
            {
                x.SpendingId,
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate,
                x.CategoryId,
                x.Categories.CategoryName
            });
            dataGridView1.DataSource = values.ToList();

            // Kategorileri comboboxda görüntülemek için
            cmbCategory.DataSource = db.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName"; // kullanıcıya görünen
            cmbCategory.ValueMember = "CategoryId";     // arkada tutulan

        }

        private void btnCreateSpending_Click(object sender, EventArgs e)
        {
            Spendings spending = new Spendings();
            spending.SpendingTitle = txtSpendingTitle.Text;
            spending.SpendingAmount = decimal.Parse(txtSpendingAmount.Text);
            spending.SpendingDate = dateTimePicker1.Value.Date;
            spending.CategoryId = (int)cmbCategory.SelectedValue;

            db.Spendings.Add(spending);
            db.SaveChanges();
            MessageBox.Show("Harcama Başarılı Bir Şekilde Sisteme Eklendi", "Harcama & Gider", MessageBoxButtons.OK, MessageBoxIcon.Information);


            var values = db.Spendings.Select(x => new
            {
                x.SpendingId,
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate,
                x.CategoryId,
                x.Categories.CategoryName
            });
            dataGridView1.DataSource = values.ToList();
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

        private void btnRemoveSpending_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Harcama Başarılı Bir Şekilde Sistemden Silindi", "Harcama & Gider", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Spendings.Select(x => new
            {
                x.SpendingId,
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate,
                x.CategoryId,
                x.Categories.CategoryName
            });
            dataGridView1.DataSource = values.ToList();
        }

        private void btnUpdateSpending_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime date = dateTimePicker1.Value.Date;
            int categoryId = (int)cmbCategory.SelectedValue;

            var values = db.Spendings.Find(id);

            values.SpendingTitle = title;
            values.SpendingAmount = amount;
            values.SpendingDate = date;
            values.CategoryId = categoryId;
            db.SaveChanges();
            MessageBox.Show("Harcama Başarılı Bir Şekilde Sistemde Güncellendi", "Harcama & Gider", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Spendings.Select(x => new
            {
                x.SpendingId,
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate,
                x.CategoryId,
                x.Categories.CategoryName
            });
            dataGridView1.DataSource = values2.ToList();

        }

        private void btnBankProcessForm_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
            this.Hide();
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
