namespace C_FA3
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
            this.salesLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.salesTaxAmnt = new System.Windows.Forms.NumericUpDown();
            this.salesAmnt = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesTaxAmnt)).BeginInit();
            this.SuspendLayout();
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.Location = new System.Drawing.Point(38, 58);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(74, 13);
            this.salesLabel.TabIndex = 0;
            this.salesLabel.Text = "Sales amount:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(38, 88);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(57, 13);
            this.taxLabel.TabIndex = 1;
            this.taxLabel.Text = "Sales Tax:";
            // 
            // salesTaxAmnt
            // 
            this.salesTaxAmnt.Location = new System.Drawing.Point(149, 88);
            this.salesTaxAmnt.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.salesTaxAmnt.Name = "salesTaxAmnt";
            this.salesTaxAmnt.Size = new System.Drawing.Size(120, 20);
            this.salesTaxAmnt.TabIndex = 2;
            // 
            // salesAmnt
            // 
            this.salesAmnt.Location = new System.Drawing.Point(149, 51);
            this.salesAmnt.Name = "salesAmnt";
            this.salesAmnt.Size = new System.Drawing.Size(120, 20);
            this.salesAmnt.TabIndex = 3;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(132, 129);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 4;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(213, 129);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(311, 129);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 188);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.salesAmnt);
            this.Controls.Add(this.salesTaxAmnt);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.salesLabel);
            this.Name = "Form1";
            this.Text = "Tax Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.salesTaxAmnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salesLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.NumericUpDown salesTaxAmnt;
        private System.Windows.Forms.TextBox salesAmnt;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

