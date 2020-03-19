namespace AlgebraStringSolve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(124, 63);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtEquation
            // 
            this.txtEquation.Location = new System.Drawing.Point(12, 34);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(310, 20);
            this.txtEquation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the equation you wouls like to evaluate";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(12, 98);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(310, 20);
            this.txtAnswer.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(247, 131);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 166);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEquation);
            this.Controls.Add(this.btnCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Algebra Strings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtEquation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnExit;
    }
}

