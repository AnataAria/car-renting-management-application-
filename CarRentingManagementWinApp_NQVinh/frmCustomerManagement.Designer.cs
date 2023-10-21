namespace CarRentingManagementWinApp_NQVinh
{
    partial class frmCustomerManagement
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
            dataGridView1 = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            Telephone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            CustomerBirthday = new DataGridViewTextBoxColumn();
            CustomerStatus = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            tbCustomerID = new TextBox();
            tbCustomerName = new TextBox();
            tbTelephone = new TextBox();
            tbEmail = new TextBox();
            tbStatus = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dpDOB = new DateTimePicker();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CustomerID, CustomerName, Telephone, Email, CustomerBirthday, CustomerStatus });
            dataGridView1.Location = new Point(12, 302);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(962, 350);
            dataGridView1.TabIndex = 0;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "Customer ID";
            CustomerID.MinimumWidth = 8;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            CustomerID.Width = 150;
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "Customer Name";
            CustomerName.MinimumWidth = 8;
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            CustomerName.Width = 150;
            // 
            // Telephone
            // 
            Telephone.HeaderText = "Telephone";
            Telephone.MinimumWidth = 8;
            Telephone.Name = "Telephone";
            Telephone.ReadOnly = true;
            Telephone.Width = 150;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 150;
            // 
            // CustomerBirthday
            // 
            CustomerBirthday.HeaderText = "Customer Birthday";
            CustomerBirthday.MinimumWidth = 8;
            CustomerBirthday.Name = "CustomerBirthday";
            CustomerBirthday.ReadOnly = true;
            CustomerBirthday.Width = 150;
            // 
            // CustomerStatus
            // 
            CustomerStatus.HeaderText = "Customer Status";
            CustomerStatus.MinimumWidth = 8;
            CustomerStatus.Name = "CustomerStatus";
            CustomerStatus.ReadOnly = true;
            CustomerStatus.Width = 150;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1064, 322);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1064, 389);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1064, 454);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1064, 531);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // tbCustomerID
            // 
            tbCustomerID.Location = new Point(56, 54);
            tbCustomerID.Name = "tbCustomerID";
            tbCustomerID.Size = new Size(288, 31);
            tbCustomerID.TabIndex = 5;
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(56, 131);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(288, 31);
            tbCustomerName.TabIndex = 6;
            // 
            // tbTelephone
            // 
            tbTelephone.Location = new Point(56, 211);
            tbTelephone.Name = "tbTelephone";
            tbTelephone.Size = new Size(288, 31);
            tbTelephone.TabIndex = 7;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(452, 54);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(288, 31);
            tbEmail.TabIndex = 8;
            // 
            // tbStatus
            // 
            tbStatus.Location = new Point(452, 211);
            tbStatus.Name = "tbStatus";
            tbStatus.Size = new Size(288, 31);
            tbStatus.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 26);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 11;
            label1.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 103);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 12;
            label2.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 183);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 13;
            label3.Text = "Telephone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(452, 26);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 14;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(452, 103);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 15;
            label5.Text = "Dob";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(452, 183);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 16;
            label6.Text = "Status";
            // 
            // dpDOB
            // 
            dpDOB.Location = new Point(452, 131);
            dpDOB.Name = "dpDOB";
            dpDOB.Size = new Size(300, 31);
            dpDOB.TabIndex = 17;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(1064, 592);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 18;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // frmCustomerManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(btnLoad);
            Controls.Add(dpDOB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbStatus);
            Controls.Add(tbEmail);
            Controls.Add(tbTelephone);
            Controls.Add(tbCustomerName);
            Controls.Add(tbCustomerID);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "frmCustomerManagement";
            Text = "frmCustomerManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn Telephone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn CustomerBirthday;
        private DataGridViewTextBoxColumn CustomerStatus;
        private Button btnAdd;
        private Button btnSave;
        private Button btnDelete;
        private Button btnBack;
        private TextBox tbCustomerID;
        private TextBox tbCustomerName;
        private TextBox tbTelephone;
        private TextBox tbEmail;
        private TextBox tbStatus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dpDOB;
        private Button btnLoad;
    }
}