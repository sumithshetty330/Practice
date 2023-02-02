namespace HelloWindows
{
    partial class GreetingForm
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(164, 160);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(138, 53);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Say Hello";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.GreetMe);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(514, 160);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(136, 49);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Say hii";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.GreetMe);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(451, 59);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 3;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GreetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "GreetingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
    }
}

