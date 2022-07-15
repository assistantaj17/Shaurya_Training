namespace ADO.NET_Connected_Architecture_Demo
{
    partial class Form1
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
            this.lblId = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearchByEmp = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.EmpGridView = new System.Windows.Forms.DataGridView();
            this.btnShowAllEmp = new System.Windows.Forms.Button();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpSalary = new System.Windows.Forms.Label();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.EmpSalary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(60, 53);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(67, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Employee ID";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmployeeID
            // 
            this.EmployeeID.Location = new System.Drawing.Point(178, 50);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(111, 20);
            this.EmployeeID.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(178, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(292, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSearchByEmp
            // 
            this.btnSearchByEmp.Location = new System.Drawing.Point(335, 43);
            this.btnSearchByEmp.Name = "btnSearchByEmp";
            this.btnSearchByEmp.Size = new System.Drawing.Size(105, 23);
            this.btnSearchByEmp.TabIndex = 9;
            this.btnSearchByEmp.Text = "Search By Emp";
            this.btnSearchByEmp.UseVisualStyleBackColor = true;
            this.btnSearchByEmp.Click += new System.EventHandler(this.btnSearchByEmp_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(63, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // EmpGridView
            // 
            this.EmpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGridView.Location = new System.Drawing.Point(477, 21);
            this.EmpGridView.Name = "EmpGridView";
            this.EmpGridView.Size = new System.Drawing.Size(271, 209);
            this.EmpGridView.TabIndex = 11;
            // 
            // btnShowAllEmp
            // 
            this.btnShowAllEmp.Location = new System.Drawing.Point(549, 291);
            this.btnShowAllEmp.Name = "btnShowAllEmp";
            this.btnShowAllEmp.Size = new System.Drawing.Size(146, 23);
            this.btnShowAllEmp.TabIndex = 12;
            this.btnShowAllEmp.Text = "Show All Emp";
            this.btnShowAllEmp.UseVisualStyleBackColor = true;
            this.btnShowAllEmp.Click += new System.EventHandler(this.btnShowAllEmp_Click);
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(60, 119);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(59, 13);
            this.lblEmpName.TabIndex = 13;
            this.lblEmpName.Text = "Emp Name";
            // 
            // lblEmpSalary
            // 
            this.lblEmpSalary.AutoSize = true;
            this.lblEmpSalary.Location = new System.Drawing.Point(60, 189);
            this.lblEmpSalary.Name = "lblEmpSalary";
            this.lblEmpSalary.Size = new System.Drawing.Size(60, 13);
            this.lblEmpSalary.TabIndex = 14;
            this.lblEmpSalary.Text = "Emp Salary";
            // 
            // EmpName
            // 
            this.EmpName.Location = new System.Drawing.Point(178, 119);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(111, 20);
            this.EmpName.TabIndex = 15;
            // 
            // EmpSalary
            // 
            this.EmpSalary.Location = new System.Drawing.Point(178, 182);
            this.EmpSalary.Name = "EmpSalary";
            this.EmpSalary.Size = new System.Drawing.Size(111, 20);
            this.EmpSalary.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmpSalary);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.lblEmpSalary);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.btnShowAllEmp);
            this.Controls.Add(this.EmpGridView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearchByEmp);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox EmployeeID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearchByEmp;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView EmpGridView;
        private System.Windows.Forms.Button btnShowAllEmp;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpSalary;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.TextBox EmpSalary;
    }
}

