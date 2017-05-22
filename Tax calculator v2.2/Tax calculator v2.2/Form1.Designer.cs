namespace Tax_calculator_v2._2
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
            this.inputText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Label();
            this.row = new System.Windows.Forms.Label();
            this.perc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.afterTax = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "put all the munies here";
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(34, 69);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(417, 20);
            this.inputText.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate tax";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Location = new System.Drawing.Point(6, 34);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(13, 13);
            this.sum.TabIndex = 1;
            this.sum.Text = "$";
            // 
            // row
            // 
            this.row.AutoSize = true;
            this.row.Location = new System.Drawing.Point(6, 47);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(44, 13);
            this.row.TabIndex = 2;
            this.row.Text = "Bracket";
            // 
            // perc
            // 
            this.perc.AutoSize = true;
            this.perc.Location = new System.Drawing.Point(6, 60);
            this.perc.Name = "perc";
            this.perc.Size = new System.Drawing.Size(15, 13);
            this.perc.TabIndex = 3;
            this.perc.Text = "%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.afterTax);
            this.groupBox1.Controls.Add(this.perc);
            this.groupBox1.Controls.Add(this.sum);
            this.groupBox1.Controls.Add(this.row);
            this.groupBox1.Location = new System.Drawing.Point(503, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 99);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Answers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1016, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SheiTofu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1014, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "v2.2 beta";
            // 
            // afterTax
            // 
            this.afterTax.AutoSize = true;
            this.afterTax.Location = new System.Drawing.Point(203, 34);
            this.afterTax.Name = "afterTax";
            this.afterTax.Size = new System.Drawing.Size(19, 13);
            this.afterTax.TabIndex = 4;
            this.afterTax.Text = "$a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 182);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Boring tax calculator v2.2 (Made by SheiTofu)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label perc;
        private System.Windows.Forms.Label row;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label afterTax;
    }
}

