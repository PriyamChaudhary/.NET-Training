namespace WinSerializeDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBinSerialization = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSoapSerialization = new System.Windows.Forms.Button();
            this.btnBinDeserialization = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSoapDeserialization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpId.Location = new System.Drawing.Point(304, 61);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(100, 27);
            this.txtEmpId.TabIndex = 1;
            this.txtEmpId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(304, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 27);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(304, 142);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 27);
            this.txtSalary.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salary";
            // 
            // btnBinSerialization
            // 
            this.btnBinSerialization.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinSerialization.Location = new System.Drawing.Point(145, 210);
            this.btnBinSerialization.Name = "btnBinSerialization";
            this.btnBinSerialization.Size = new System.Drawing.Size(135, 40);
            this.btnBinSerialization.TabIndex = 6;
            this.btnBinSerialization.Text = "Bin Serialize";
            this.btnBinSerialization.UseVisualStyleBackColor = true;
            this.btnBinSerialization.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(290, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "XML Serialize";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSoapSerialization
            // 
            this.btnSoapSerialization.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoapSerialization.Location = new System.Drawing.Point(517, 214);
            this.btnSoapSerialization.Name = "btnSoapSerialization";
            this.btnSoapSerialization.Size = new System.Drawing.Size(151, 32);
            this.btnSoapSerialization.TabIndex = 8;
            this.btnSoapSerialization.Text = "Soap Serialization";
            this.btnSoapSerialization.UseVisualStyleBackColor = true;
            this.btnSoapSerialization.Click += new System.EventHandler(this.btnSoapSerialization_Click);
            // 
            // btnBinDeserialization
            // 
            this.btnBinDeserialization.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinDeserialization.Location = new System.Drawing.Point(145, 261);
            this.btnBinDeserialization.Name = "btnBinDeserialization";
            this.btnBinDeserialization.Size = new System.Drawing.Size(158, 40);
            this.btnBinDeserialization.TabIndex = 9;
            this.btnBinDeserialization.Text = "Bin Deserialize";
            this.btnBinDeserialization.UseVisualStyleBackColor = true;
            this.btnBinDeserialization.Click += new System.EventHandler(this.btnBinDeserialization_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(318, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 45);
            this.button5.TabIndex = 10;
            this.button5.Text = "XML Deserialize";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSoapDeserialization
            // 
            this.btnSoapDeserialization.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoapDeserialization.Location = new System.Drawing.Point(517, 256);
            this.btnSoapDeserialization.Name = "btnSoapDeserialization";
            this.btnSoapDeserialization.Size = new System.Drawing.Size(151, 34);
            this.btnSoapDeserialization.TabIndex = 11;
            this.btnSoapDeserialization.Text = "Soap Deserialize";
            this.btnSoapDeserialization.UseVisualStyleBackColor = true;
            this.btnSoapDeserialization.Click += new System.EventHandler(this.btnSoapDeserialization_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 514);
            this.Controls.Add(this.btnSoapDeserialization);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnBinDeserialization);
            this.Controls.Add(this.btnSoapSerialization);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBinSerialization);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBinSerialization;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSoapSerialization;
        private System.Windows.Forms.Button btnBinDeserialization;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSoapDeserialization;
    }
}

