namespace WindowsFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.Button();
            this.dgvEmploee = new System.Windows.Forms.DataGridView();
            this.te = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploee)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(319, 257);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(75, 23);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "Next";
            this.txtID.UseVisualStyleBackColor = true;
            // 
            // dgvEmploee
            // 
            this.dgvEmploee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmploee.Location = new System.Drawing.Point(319, 37);
            this.dgvEmploee.Name = "dgvEmploee";
            this.dgvEmploee.Size = new System.Drawing.Size(240, 150);
            this.dgvEmploee.TabIndex = 2;
            // 
            // te
            // 
            this.te.Location = new System.Drawing.Point(50, 37);
            this.te.Multiline = true;
            this.te.Name = "te";
            this.te.Size = new System.Drawing.Size(100, 20);
            this.te.TabIndex = 3;
            this.te.TextChanged += new System.EventHandler(this.te_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(50, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(50, 152);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 5;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(50, 207);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(100, 20);
            this.txtDept.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.te);
            this.Controls.Add(this.dgvEmploee);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtID;
        private System.Windows.Forms.DataGridView dgvEmploee;
        private System.Windows.Forms.TextBox te;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtDept;
    }
}

