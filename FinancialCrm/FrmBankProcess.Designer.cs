namespace FinancialCrm
{
    partial class FrmBankProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSettingsForm = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbBanks = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateBankProcess = new System.Windows.Forms.Button();
            this.btnRemoveBankProcess = new System.Windows.Forms.Button();
            this.btnCreateBankProcess = new System.Windows.Forms.Button();
            this.btnBankProcessList = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBankProcessForm = new System.Windows.Forms.Button();
            this.BtnSpendingsForm = new System.Windows.Forms.Button();
            this.btnBillsForm = new System.Windows.Forms.Button();
            this.txtBankProcessAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBankProcessDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDashBoardForm = new System.Windows.Forms.Button();
            this.txtBankProcessId = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuitForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategoryForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFilterByDate = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.rdBtnGelenHavale = new System.Windows.Forms.RadioButton();
            this.rdBtnGidenHavale = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSettingsForm
            // 
            this.btnSettingsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnSettingsForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettingsForm.ForeColor = System.Drawing.Color.White;
            this.btnSettingsForm.Location = new System.Drawing.Point(21, 482);
            this.btnSettingsForm.Name = "btnSettingsForm";
            this.btnSettingsForm.Size = new System.Drawing.Size(208, 61);
            this.btnSettingsForm.TabIndex = 3;
            this.btnSettingsForm.Text = "Ayarlar";
            this.btnSettingsForm.UseVisualStyleBackColor = false;
            this.btnSettingsForm.Click += new System.EventHandler(this.btnSettingsForm_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(324, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // cmbBanks
            // 
            this.cmbBanks.BackColor = System.Drawing.SystemColors.Window;
            this.cmbBanks.DisplayMember = "BankTitle";
            this.cmbBanks.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBanks.FormattingEnabled = true;
            this.cmbBanks.Location = new System.Drawing.Point(632, 223);
            this.cmbBanks.Name = "cmbBanks";
            this.cmbBanks.Size = new System.Drawing.Size(324, 29);
            this.cmbBanks.TabIndex = 16;
            this.cmbBanks.ValueMember = "BankId";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(527, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Banka Adı:";
            // 
            // btnUpdateBankProcess
            // 
            this.btnUpdateBankProcess.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateBankProcess.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateBankProcess.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateBankProcess.Location = new System.Drawing.Point(559, 274);
            this.btnUpdateBankProcess.Name = "btnUpdateBankProcess";
            this.btnUpdateBankProcess.Size = new System.Drawing.Size(194, 51);
            this.btnUpdateBankProcess.TabIndex = 11;
            this.btnUpdateBankProcess.Text = "Hareketleri Güncelle";
            this.btnUpdateBankProcess.UseVisualStyleBackColor = false;
            this.btnUpdateBankProcess.Click += new System.EventHandler(this.btnUpdateBankProcess_Click);
            // 
            // btnRemoveBankProcess
            // 
            this.btnRemoveBankProcess.BackColor = System.Drawing.Color.Silver;
            this.btnRemoveBankProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveBankProcess.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveBankProcess.Location = new System.Drawing.Point(401, 274);
            this.btnRemoveBankProcess.Name = "btnRemoveBankProcess";
            this.btnRemoveBankProcess.Size = new System.Drawing.Size(152, 51);
            this.btnRemoveBankProcess.TabIndex = 10;
            this.btnRemoveBankProcess.Text = "Hareket Sil";
            this.btnRemoveBankProcess.UseVisualStyleBackColor = false;
            this.btnRemoveBankProcess.Click += new System.EventHandler(this.btnRemoveBankProcess_Click);
            // 
            // btnCreateBankProcess
            // 
            this.btnCreateBankProcess.BackColor = System.Drawing.Color.Silver;
            this.btnCreateBankProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateBankProcess.ForeColor = System.Drawing.Color.Black;
            this.btnCreateBankProcess.Location = new System.Drawing.Point(243, 274);
            this.btnCreateBankProcess.Name = "btnCreateBankProcess";
            this.btnCreateBankProcess.Size = new System.Drawing.Size(152, 51);
            this.btnCreateBankProcess.TabIndex = 9;
            this.btnCreateBankProcess.Text = "Yeni Hareket";
            this.btnCreateBankProcess.UseVisualStyleBackColor = false;
            this.btnCreateBankProcess.Click += new System.EventHandler(this.btnCreateBankProcess_Click);
            // 
            // btnBankProcessList
            // 
            this.btnBankProcessList.BackColor = System.Drawing.Color.Silver;
            this.btnBankProcessList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcessList.ForeColor = System.Drawing.Color.Black;
            this.btnBankProcessList.Location = new System.Drawing.Point(70, 274);
            this.btnBankProcessList.Name = "btnBankProcessList";
            this.btnBankProcessList.Size = new System.Drawing.Size(167, 51);
            this.btnBankProcessList.TabIndex = 8;
            this.btnBankProcessList.Text = "Hareket Listesi";
            this.btnBankProcessList.UseVisualStyleBackColor = false;
            this.btnBankProcessList.Click += new System.EventHandler(this.btnBankProcessList_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 48);
            this.label5.TabIndex = 6;
            this.label5.Text = "Başlangıç/İşlem \r\n                Tarihi:";
            // 
            // btnBankProcessForm
            // 
            this.btnBankProcessForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnBankProcessForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcessForm.ForeColor = System.Drawing.Color.White;
            this.btnBankProcessForm.Location = new System.Drawing.Point(21, 330);
            this.btnBankProcessForm.Name = "btnBankProcessForm";
            this.btnBankProcessForm.Size = new System.Drawing.Size(208, 61);
            this.btnBankProcessForm.TabIndex = 2;
            this.btnBankProcessForm.Text = "Banka Hareketleri";
            this.btnBankProcessForm.UseVisualStyleBackColor = false;
            // 
            // BtnSpendingsForm
            // 
            this.BtnSpendingsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.BtnSpendingsForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSpendingsForm.ForeColor = System.Drawing.Color.White;
            this.BtnSpendingsForm.Location = new System.Drawing.Point(21, 254);
            this.BtnSpendingsForm.Name = "BtnSpendingsForm";
            this.BtnSpendingsForm.Size = new System.Drawing.Size(208, 61);
            this.BtnSpendingsForm.TabIndex = 2;
            this.BtnSpendingsForm.Text = "Giderler";
            this.BtnSpendingsForm.UseVisualStyleBackColor = false;
            this.BtnSpendingsForm.Click += new System.EventHandler(this.BtnSpendingsForm_Click);
            // 
            // btnBillsForm
            // 
            this.btnBillsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnBillsForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillsForm.ForeColor = System.Drawing.Color.White;
            this.btnBillsForm.Location = new System.Drawing.Point(21, 178);
            this.btnBillsForm.Name = "btnBillsForm";
            this.btnBillsForm.Size = new System.Drawing.Size(208, 61);
            this.btnBillsForm.TabIndex = 2;
            this.btnBillsForm.Text = "Faturalar";
            this.btnBillsForm.UseVisualStyleBackColor = false;
            this.btnBillsForm.Click += new System.EventHandler(this.btnBillsForm_Click);
            // 
            // txtBankProcessAmount
            // 
            this.txtBankProcessAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtBankProcessAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBankProcessAmount.Location = new System.Drawing.Point(161, 115);
            this.txtBankProcessAmount.Name = "txtBankProcessAmount";
            this.txtBankProcessAmount.Size = new System.Drawing.Size(795, 32);
            this.txtBankProcessAmount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(85, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Miktar:";
            // 
            // txtBankProcessDescription
            // 
            this.txtBankProcessDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtBankProcessDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBankProcessDescription.Location = new System.Drawing.Point(161, 62);
            this.txtBankProcessDescription.Name = "txtBankProcessDescription";
            this.txtBankProcessDescription.Size = new System.Drawing.Size(795, 32);
            this.txtBankProcessDescription.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(65, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Açıklama:";
            // 
            // btnDashBoardForm
            // 
            this.btnDashBoardForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnDashBoardForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashBoardForm.ForeColor = System.Drawing.Color.White;
            this.btnDashBoardForm.Location = new System.Drawing.Point(21, 406);
            this.btnDashBoardForm.Name = "btnDashBoardForm";
            this.btnDashBoardForm.Size = new System.Drawing.Size(208, 61);
            this.btnDashBoardForm.TabIndex = 2;
            this.btnDashBoardForm.Text = "DashBoard";
            this.btnDashBoardForm.UseVisualStyleBackColor = false;
            this.btnDashBoardForm.Click += new System.EventHandler(this.btnDashBoardForm_Click);
            // 
            // txtBankProcessId
            // 
            this.txtBankProcessId.BackColor = System.Drawing.SystemColors.Window;
            this.txtBankProcessId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBankProcessId.Location = new System.Drawing.Point(161, 14);
            this.txtBankProcessId.Name = "txtBankProcessId";
            this.txtBankProcessId.Size = new System.Drawing.Size(795, 32);
            this.txtBankProcessId.TabIndex = 1;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(123, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnQuitForm);
            this.panel1.Controls.Add(this.btnSettingsForm);
            this.panel1.Controls.Add(this.btnDashBoardForm);
            this.panel1.Controls.Add(this.btnBankProcessForm);
            this.panel1.Controls.Add(this.BtnSpendingsForm);
            this.panel1.Controls.Add(this.btnBillsForm);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategoryForm);
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 668);
            this.panel1.TabIndex = 9;
            // 
            // btnQuitForm
            // 
            this.btnQuitForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnQuitForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQuitForm.ForeColor = System.Drawing.Color.White;
            this.btnQuitForm.Location = new System.Drawing.Point(21, 559);
            this.btnQuitForm.Name = "btnQuitForm";
            this.btnQuitForm.Size = new System.Drawing.Size(208, 61);
            this.btnQuitForm.TabIndex = 3;
            this.btnQuitForm.Text = "Çıkış Yap";
            this.btnQuitForm.UseVisualStyleBackColor = false;
            this.btnQuitForm.Click += new System.EventHandler(this.btnQuitForm_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(21, 101);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(208, 61);
            this.btnBanksForm.TabIndex = 2;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = false;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // btnCategoryForm
            // 
            this.btnCategoryForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnCategoryForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryForm.ForeColor = System.Drawing.Color.White;
            this.btnCategoryForm.Location = new System.Drawing.Point(21, 22);
            this.btnCategoryForm.Name = "btnCategoryForm";
            this.btnCategoryForm.Size = new System.Drawing.Size(208, 61);
            this.btnCategoryForm.TabIndex = 1;
            this.btnCategoryForm.Text = "Kategoriler";
            this.btnCategoryForm.UseVisualStyleBackColor = false;
            this.btnCategoryForm.Click += new System.EventHandler(this.btnCategoryForm_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 57);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banka Hareketleri Formu";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnFilterByDate);
            this.panel3.Controls.Add(this.btnUpdateBankProcess);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.btnRemoveBankProcess);
            this.panel3.Controls.Add(this.btnCreateBankProcess);
            this.panel3.Controls.Add(this.btnBankProcessList);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.rdBtnGelenHavale);
            this.panel3.Controls.Add(this.cmbBanks);
            this.panel3.Controls.Add(this.rdBtnGidenHavale);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtBankProcessAmount);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtBankProcessDescription);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtBankProcessId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(258, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(991, 339);
            this.panel3.TabIndex = 11;
            // 
            // btnFilterByDate
            // 
            this.btnFilterByDate.BackColor = System.Drawing.Color.Silver;
            this.btnFilterByDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilterByDate.ForeColor = System.Drawing.Color.Black;
            this.btnFilterByDate.Location = new System.Drawing.Point(759, 274);
            this.btnFilterByDate.Name = "btnFilterByDate";
            this.btnFilterByDate.Size = new System.Drawing.Size(197, 51);
            this.btnFilterByDate.TabIndex = 22;
            this.btnFilterByDate.Text = "Tarih Aralığında Göster";
            this.btnFilterByDate.UseVisualStyleBackColor = false;
            this.btnFilterByDate.Click += new System.EventHandler(this.btnFilterByDate_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker2.Location = new System.Drawing.Point(632, 184);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(324, 22);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(525, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Bitiş Tarihi:";
            // 
            // rdBtnGelenHavale
            // 
            this.rdBtnGelenHavale.AutoSize = true;
            this.rdBtnGelenHavale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnGelenHavale.Location = new System.Drawing.Point(161, 225);
            this.rdBtnGelenHavale.Name = "rdBtnGelenHavale";
            this.rdBtnGelenHavale.Size = new System.Drawing.Size(141, 28);
            this.rdBtnGelenHavale.TabIndex = 19;
            this.rdBtnGelenHavale.TabStop = true;
            this.rdBtnGelenHavale.Text = "Gelen Havale";
            this.rdBtnGelenHavale.UseVisualStyleBackColor = true;
            // 
            // rdBtnGidenHavale
            // 
            this.rdBtnGidenHavale.AutoSize = true;
            this.rdBtnGidenHavale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnGidenHavale.Location = new System.Drawing.Point(343, 225);
            this.rdBtnGidenHavale.Name = "rdBtnGidenHavale";
            this.rdBtnGidenHavale.Size = new System.Drawing.Size(142, 28);
            this.rdBtnGidenHavale.TabIndex = 18;
            this.rdBtnGidenHavale.TabStop = true;
            this.rdBtnGidenHavale.Text = "Giden Havale";
            this.rdBtnGidenHavale.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(258, 402);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(991, 314);
            this.panel4.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(991, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmBankProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1251, 719);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBankProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBankProcess";
            this.Load += new System.EventHandler(this.FrmBankProcess_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSettingsForm;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbBanks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateBankProcess;
        private System.Windows.Forms.Button btnRemoveBankProcess;
        private System.Windows.Forms.Button btnCreateBankProcess;
        private System.Windows.Forms.Button btnBankProcessList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBankProcessForm;
        private System.Windows.Forms.Button BtnSpendingsForm;
        private System.Windows.Forms.Button btnBillsForm;
        private System.Windows.Forms.TextBox txtBankProcessAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBankProcessDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDashBoardForm;
        private System.Windows.Forms.TextBox txtBankProcessId;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuitForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategoryForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdBtnGelenHavale;
        private System.Windows.Forms.RadioButton rdBtnGidenHavale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnFilterByDate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}