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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            var values = db.Categories.Select(x => new
            {
                x.CategoryId,
                x.CategoryName
            });
            dataGridView1.DataSource = values.ToList();
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            Categories category = new Categories();
            category.CategoryName = txtCategoryName.Text;

            db.Categories.Add(category);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Sisteme Eklendi", "Kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.Select(x => new
            {
                x.CategoryId,
                x.CategoryName
            });
            dataGridView1.DataSource = values.ToList();
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var removeValue = db.Categories.Find(id);
            db.Categories.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Harcama Başarılı Bir Şekilde Sistemden Silindi", "Kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.Select(x => new
            {
                x.CategoryId,
                x.CategoryName
            });
            dataGridView1.DataSource = values.ToList();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            string categoryName = txtCategoryName.Text;
            
            var values = db.Categories.Find(id);

            values.CategoryName = categoryName;
           
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Sistemde Güncellendi", "Kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Categories.Select(x => new
            {
                x.CategoryId,
                x.CategoryName
            });
            dataGridView1.DataSource = values2.ToList();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            var values = db.Categories.Select(x => new
            {
                x.CategoryId,
                x.CategoryName
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

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnQuitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }
    }
}
