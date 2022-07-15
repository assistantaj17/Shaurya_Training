namespace ADO.NET_Connected_Architecture_Demo
{
    partial class Form2
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
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmpSalary = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.btnShowAllEmp = new System.Windows.Forms.Button();
            this.EmpGridView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearchByEmp = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(174, 240);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(111, 20);
            this.txtSalary.TabIndex = 28;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 177);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(111, 20);
            this.txtName.TabIndex = 27;
            // 
            // lblEmpSalary
            // 
            this.lblEmpSalary.AutoSize = true;
            this.lblEmpSalary.Location = new System.Drawing.Point(56, 247);
            this.lblEmpSalary.Name = "lblEmpSalary";
            this.lblEmpSalary.Size = new System.Drawing.Size(60, 13);
            this.lblEmpSalary.TabIndex = 26;
            this.lblEmpSalary.Text = "Emp Salary";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(56, 177);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(59, 13);
            this.lblEmpName.TabIndex = 25;
            this.lblEmpName.Text = "Emp Name";
            // 
            // btnShowAllEmp
            // 
            this.btnShowAllEmp.Location = new System.Drawing.Point(545, 349);
            this.btnShowAllEmp.Name = "btnShowAllEmp";
            this.btnShowAllEmp.Size = new System.Drawing.Size(146, 23);
            this.btnShowAllEmp.TabIndex = 24;
            this.btnShowAllEmp.Text = "Show All Emp";
            this.btnShowAllEmp.UseVisualStyleBackColor = true;
            this.btnShowAllEmp.Click += new System.EventHandler(this.btnShowAllEmp_Click);
            // 
            // EmpGridView
            // 
            this.EmpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGridView.Location = new System.Drawing.Point(473, 79);
            this.EmpGridView.Name = "EmpGridView";
            this.EmpGridView.Size = new System.Drawing.Size(271, 209);
            this.EmpGridView.TabIndex = 23;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(59, 323);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearchByEmp
            // 
            this.btnSearchByEmp.Location = new System.Drawing.Point(331, 101);
            this.btnSearchByEmp.Name = "btnSearchByEmp";
            this.btnSearchByEmp.Size = new System.Drawing.Size(105, 23);
            this.btnSearchByEmp.TabIndex = 21;
            this.btnSearchByEmp.Text = "Search By Emp";
            this.btnSearchByEmp.UseVisualStyleBackColor = true;
            this.btnSearchByEmp.Click += new System.EventHandler(this.btnSearchByEmp_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(288, 323);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(174, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(174, 108);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(111, 20);
            this.txtId.TabIndex = 18;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(56, 111);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(67, 13);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "Employee ID";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmpSalary);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.btnShowAllEmp);
            this.Controls.Add(this.EmpGridView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearchByEmp);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "Form2";
            this.Text = "Disconnected Demo";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmpSalary;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Button btnShowAllEmp;
        private System.Windows.Forms.DataGridView EmpGridView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearchByEmp;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
    }
}