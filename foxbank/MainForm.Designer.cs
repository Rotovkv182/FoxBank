namespace foxbank
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.maintabc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.createbtn = new System.Windows.Forms.Button();
            this.summtb = new System.Windows.Forms.TextBox();
            this.saldotb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.banknumtb = new System.Windows.Forms.TextBox();
            this.idtb = new System.Windows.Forms.TextBox();
            this.balancebtn = new System.Windows.Forms.Button();
            this.MainDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.foxbankDataFOX = new foxbank.foxbankDataFOX();
            this.MainDGV2 = new System.Windows.Forms.DataGridView();
            this.bankaccountsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bankaccountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKsaldosbankaccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKsaldosbankaccountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saldosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foxbankDSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saldoDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsaldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceviewerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.balanceviewerTableAdapter = new foxbank.foxbankDataFOXTableAdapters.balanceviewerTableAdapter();
            this.usersTableAdapter = new foxbank.foxbankDataFOXTableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.maintabc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foxbankDataFOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaccountsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaccountsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKsaldosbankaccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKsaldosbankaccountsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saldosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foxbankDSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saldoDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceviewerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // InfoBtn
            // 
            this.InfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.InfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoBtn.ForeColor = System.Drawing.Color.LightGray;
            this.InfoBtn.Location = new System.Drawing.Point(12, 197);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(113, 42);
            this.InfoBtn.TabIndex = 7;
            this.InfoBtn.Text = "Сведения об аккаунте";
            this.InfoBtn.UseVisualStyleBackColor = false;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // maintabc
            // 
            this.maintabc.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.maintabc.Controls.Add(this.tabPage1);
            this.maintabc.Location = new System.Drawing.Point(170, 219);
            this.maintabc.Multiline = true;
            this.maintabc.Name = "maintabc";
            this.maintabc.SelectedIndex = 0;
            this.maintabc.Size = new System.Drawing.Size(618, 219);
            this.maintabc.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.createbtn);
            this.tabPage1.Controls.Add(this.summtb);
            this.tabPage1.Controls.Add(this.saldotb);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(610, 190);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить кредит";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.textBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(6, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 33);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "ID Статуса";
            // 
            // createbtn
            // 
            this.createbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createbtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createbtn.ForeColor = System.Drawing.Color.LightGray;
            this.createbtn.Location = new System.Drawing.Point(18, 123);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(113, 36);
            this.createbtn.TabIndex = 10;
            this.createbtn.Text = "Отправить";
            this.createbtn.UseVisualStyleBackColor = false;
            // 
            // summtb
            // 
            this.summtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.summtb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.summtb.ForeColor = System.Drawing.Color.LightGray;
            this.summtb.Location = new System.Drawing.Point(6, 6);
            this.summtb.Multiline = true;
            this.summtb.Name = "summtb";
            this.summtb.Size = new System.Drawing.Size(146, 33);
            this.summtb.TabIndex = 2;
            this.summtb.Text = "Сумма";
            // 
            // saldotb
            // 
            this.saldotb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.saldotb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.saldotb.ForeColor = System.Drawing.Color.LightGray;
            this.saldotb.Location = new System.Drawing.Point(6, 45);
            this.saldotb.Multiline = true;
            this.saldotb.Name = "saldotb";
            this.saldotb.Size = new System.Drawing.Size(146, 33);
            this.saldotb.TabIndex = 1;
            this.saldotb.Text = "ID Сальдо";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(183, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Процентная ставка по депозиту: 5% от суммы в день";
            // 
            // banknumtb
            // 
            this.banknumtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.banknumtb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.banknumtb.ForeColor = System.Drawing.Color.LightGray;
            this.banknumtb.Location = new System.Drawing.Point(12, 150);
            this.banknumtb.Multiline = true;
            this.banknumtb.Name = "banknumtb";
            this.banknumtb.Size = new System.Drawing.Size(113, 33);
            this.banknumtb.TabIndex = 4;
            this.banknumtb.Text = "Банковский счет";
            // 
            // idtb
            // 
            this.idtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.idtb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.idtb.ForeColor = System.Drawing.Color.LightGray;
            this.idtb.Location = new System.Drawing.Point(12, 104);
            this.idtb.Multiline = true;
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(113, 33);
            this.idtb.TabIndex = 3;
            this.idtb.Text = "ID Пользователя";
            // 
            // balancebtn
            // 
            this.balancebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.balancebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.balancebtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balancebtn.ForeColor = System.Drawing.Color.LightGray;
            this.balancebtn.Location = new System.Drawing.Point(12, 245);
            this.balancebtn.Name = "balancebtn";
            this.balancebtn.Size = new System.Drawing.Size(113, 42);
            this.balancebtn.TabIndex = 10;
            this.balancebtn.Text = "Сведения об счете";
            this.balancebtn.UseVisualStyleBackColor = false;
            this.balancebtn.Click += new System.EventHandler(this.balancebtn_Click);
            // 
            // MainDGV
            // 
            this.MainDGV.AllowUserToAddRows = false;
            this.MainDGV.AllowUserToDeleteRows = false;
            this.MainDGV.AutoGenerateColumns = false;
            this.MainDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.MainDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn10});
            this.MainDGV.DataSource = this.bindingSource1;
            this.MainDGV.Location = new System.Drawing.Point(170, 12);
            this.MainDGV.Name = "MainDGV";
            this.MainDGV.ReadOnly = true;
            this.MainDGV.Size = new System.Drawing.Size(618, 192);
            this.MainDGV.TabIndex = 11;
            this.MainDGV.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_user";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_user";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "address_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "address_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn6.HeaderText = "name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn7.HeaderText = "surname";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "phone_number";
            this.dataGridViewTextBoxColumn8.HeaderText = "phone_number";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "date_of_birth";
            this.dataGridViewTextBoxColumn9.HeaderText = "date_of_birth";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "enabled";
            this.dataGridViewCheckBoxColumn1.HeaderText = "enabled";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "disabled";
            this.dataGridViewCheckBoxColumn2.HeaderText = "disabled";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn10.HeaderText = "password";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "users";
            this.bindingSource1.DataSource = this.foxbankDataFOX;
            // 
            // foxbankDataFOX
            // 
            this.foxbankDataFOX.DataSetName = "foxbankDataFOX";
            this.foxbankDataFOX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainDGV2
            // 
            this.MainDGV2.AllowUserToAddRows = false;
            this.MainDGV2.AllowUserToDeleteRows = false;
            this.MainDGV2.AutoGenerateColumns = false;
            this.MainDGV2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.MainDGV2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainDGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDGV2.DataSource = this.bankaccountsBindingSource2;
            this.MainDGV2.Location = new System.Drawing.Point(170, 21);
            this.MainDGV2.Name = "MainDGV2";
            this.MainDGV2.ReadOnly = true;
            this.MainDGV2.Size = new System.Drawing.Size(618, 192);
            this.MainDGV2.TabIndex = 12;
            this.MainDGV2.Visible = false;
            // 
            // bankaccountsBindingSource2
            // 
            this.bankaccountsBindingSource2.DataMember = "bank_accounts";
            // 
            // bankaccountsBindingSource1
            // 
            this.bankaccountsBindingSource1.DataMember = "bank_accounts";
            // 
            // fKsaldosbankaccountsBindingSource
            // 
            this.fKsaldosbankaccountsBindingSource.AllowNew = true;
            // 
            // fKsaldosbankaccountsBindingSource1
            // 
            this.fKsaldosbankaccountsBindingSource1.DataMember = "FK_saldos_bank_accounts";
            this.fKsaldosbankaccountsBindingSource1.DataSource = this.bankaccountsBindingSource1;
            // 
            // saldosBindingSource
            // 
            this.saldosBindingSource.DataMember = "saldos";
            // 
            // saldoDGV
            // 
            this.saldoDGV.AllowUserToAddRows = false;
            this.saldoDGV.AllowUserToDeleteRows = false;
            this.saldoDGV.AutoGenerateColumns = false;
            this.saldoDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.saldoDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saldoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saldoDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.idsaldoDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn});
            this.saldoDGV.DataSource = this.balanceviewerBindingSource;
            this.saldoDGV.Location = new System.Drawing.Point(170, 21);
            this.saldoDGV.Name = "saldoDGV";
            this.saldoDGV.ReadOnly = true;
            this.saldoDGV.Size = new System.Drawing.Size(618, 192);
            this.saldoDGV.TabIndex = 13;
            this.saldoDGV.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_bank_acc";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_bank_acc";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "number";
            this.dataGridViewTextBoxColumn2.HeaderText = "number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_user";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_user";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // idsaldoDataGridViewTextBoxColumn
            // 
            this.idsaldoDataGridViewTextBoxColumn.DataPropertyName = "id_saldo";
            this.idsaldoDataGridViewTextBoxColumn.HeaderText = "id_saldo";
            this.idsaldoDataGridViewTextBoxColumn.Name = "idsaldoDataGridViewTextBoxColumn";
            this.idsaldoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsaldoDataGridViewTextBoxColumn.Visible = false;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Expr1";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.Visible = false;
            // 
            // balanceviewerBindingSource
            // 
            this.balanceviewerBindingSource.DataMember = "balanceviewer";
            this.balanceviewerBindingSource.DataSource = this.foxbankDataFOX;
            // 
            // balanceviewerTableAdapter
            // 
            this.balanceviewerTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(this.saldoDGV);
            this.Controls.Add(this.MainDGV2);
            this.Controls.Add(this.MainDGV);
            this.Controls.Add(this.balancebtn);
            this.Controls.Add(this.banknumtb);
            this.Controls.Add(this.maintabc);
            this.Controls.Add(this.idtb);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Главная - FoxBank";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.maintabc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foxbankDataFOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaccountsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaccountsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKsaldosbankaccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKsaldosbankaccountsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saldosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foxbankDSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saldoDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceviewerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.TabControl maintabc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.TextBox summtb;
        private System.Windows.Forms.TextBox saldotb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox banknumtb;
        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button balancebtn;
        private System.Windows.Forms.DataGridView MainDGV;
        private System.Windows.Forms.BindingSource bankaccountsBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.DataGridView MainDGV2;
        private System.Windows.Forms.BindingSource bankaccountsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn disabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKsaldosbankaccountsBindingSource;
        private System.Windows.Forms.BindingSource fKsaldosbankaccountsBindingSource1;
        private System.Windows.Forms.BindingSource saldosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbankaccDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bankaccountsBindingSource2;
        private System.Windows.Forms.BindingSource foxbankDSBindingSource1;
        private System.Windows.Forms.DataGridView saldoDGV;
        private foxbankDataFOX foxbankDataFOX;
        private System.Windows.Forms.BindingSource balanceviewerBindingSource;
        private foxbankDataFOXTableAdapters.balanceviewerTableAdapter balanceviewerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsaldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private foxbankDataFOXTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}