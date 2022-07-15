namespace ADO.NET_Connected_Architecture_Demo
{
    partial class Form4
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
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearchRollNo = new System.Windows.Forms.Button();
            this.StudentGridView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRollno = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRollNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(544, 341);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(176, 23);
            this.btnShowAll.TabIndex = 23;
            this.btnShowAll.Text = "Show All Student List";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearchRollNo
            // 
            this.btnSearchRollNo.Location = new System.Drawing.Point(327, 89);
            this.btnSearchRollNo.Name = "btnSearchRollNo";
            this.btnSearchRollNo.Size = new System.Drawing.Size(105, 23);
            this.btnSearchRollNo.TabIndex = 22;
            this.btnSearchRollNo.Text = "Search By Roll No";
            this.btnSearchRollNo.UseVisualStyleBackColor = true;
            this.btnSearchRollNo.Click += new System.EventHandler(this.btnSearchRollNo_Click);
            // 
            // StudentGridView
            // 
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Location = new System.Drawing.Point(456, 87);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.Size = new System.Drawing.Size(297, 192);
            this.StudentGridView.TabIndex = 21;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(349, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(200, 341);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(48, 341);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRollno
            // 
            this.txtRollno.Location = new System.Drawing.Point(175, 87);
            this.txtRollno.Name = "txtRollno";
            this.txtRollno.Size = new System.Drawing.Size(100, 20);
            this.txtRollno.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 163);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 16;
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(175, 240);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(100, 20);
            this.txtPercentage.TabIndex = 15;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(67, 240);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(62, 13);
            this.lblPercentage.TabIndex = 14;
            this.lblPercentage.Text = "Percentage";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(67, 170);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            // 
            // lblRollNo
            // 
            this.lblRollNo.AutoSize = true;
            this.lblRollNo.Location = new System.Drawing.Point(67, 94);
            this.lblRollNo.Name = "lblRollNo";
            this.lblRollNo.Size = new System.Drawing.Size(42, 13);
            this.lblRollNo.TabIndex = 12;
            this.lblRollNo.Text = "Roll No";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearchRollNo);
            this.Controls.Add(this.StudentGridView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRollno);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRollNo);
            this.Name = "Form4";
            this.Text = "Connected Demo2";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearchRollNo;
        private System.Windows.Forms.DataGridView StudentGridView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRollno;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRollNo;
    }
}