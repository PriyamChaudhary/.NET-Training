namespace WinForm
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNumResult = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNumResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(140, 53);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(42, 16);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Num1";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(140, 83);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(42, 16);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Num2";
            // 
            // lblNumResult
            // 
            this.lblNumResult.AutoSize = true;
            this.lblNumResult.Location = new System.Drawing.Point(140, 113);
            this.lblNumResult.Name = "lblNumResult";
            this.lblNumResult.Size = new System.Drawing.Size(73, 16);
            this.lblNumResult.TabIndex = 2;
            this.lblNumResult.Text = "NumResult";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(219, 50);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 22);
            this.txtNum1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(176, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(219, 83);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 22);
            this.txtNum2.TabIndex = 1;
            // 
            // txtNumResult
            // 
            this.txtNumResult.Location = new System.Drawing.Point(219, 113);
            this.txtNumResult.Name = "txtNumResult";
            this.txtNumResult.Size = new System.Drawing.Size(100, 22);
            this.txtNumResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumResult);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNumResult);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.Text = "My Simple App";
            this.Load += new System.EventHandler(this.btnAdd_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNumResult;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNumResult;
    }
}

