namespace TypedDataset
{
    partial class Typeddataset
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
            this.UpdateUnTyped = new System.Windows.Forms.Button();
            this.UnTyped = new System.Windows.Forms.Button();
            this.Typed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateUnTyped
            // 
            this.UpdateUnTyped.Location = new System.Drawing.Point(414, 264);
            this.UpdateUnTyped.Name = "UpdateUnTyped";
            this.UpdateUnTyped.Size = new System.Drawing.Size(97, 23);
            this.UpdateUnTyped.TabIndex = 0;
            this.UpdateUnTyped.Text = "UpdateUntyped";
            this.UpdateUnTyped.UseVisualStyleBackColor = true;
            // 
            // UnTyped
            // 
            this.UnTyped.Location = new System.Drawing.Point(258, 264);
            this.UnTyped.Name = "UnTyped";
            this.UnTyped.Size = new System.Drawing.Size(97, 23);
            this.UnTyped.TabIndex = 1;
            this.UnTyped.Text = "DisplayUntyped";
            this.UnTyped.UseVisualStyleBackColor = true;
            // 
            // Typed
            // 
            this.Typed.Location = new System.Drawing.Point(107, 264);
            this.Typed.Name = "Typed";
            this.Typed.Size = new System.Drawing.Size(82, 23);
            this.Typed.TabIndex = 2;
            this.Typed.Text = "DisplayTyped";
            this.Typed.UseVisualStyleBackColor = true;
            this.Typed.Click += new System.EventHandler(this.UnTyped_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(107, 120);
            this.textName.Multiline = true;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 5;
            this.textName.TextChanged += new System.EventHandler(this.Typed_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(341, 37);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(240, 150);
            this.dgvEmployee.TabIndex = 6;
            // 
            // Typeddataset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Typed);
            this.Controls.Add(this.UnTyped);
            this.Controls.Add(this.UpdateUnTyped);
            this.Name = "Typeddataset";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateUnTyped;
        private System.Windows.Forms.Button UnTyped;
        private System.Windows.Forms.Button Typed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.DataGridView dgvEmployee;
    }
}

