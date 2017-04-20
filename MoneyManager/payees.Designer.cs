namespace MoneyManager
{
    partial class payees
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
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bReportColour = new System.Windows.Forms.Button();
            this.bDefaultCategory = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(234, 176);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 3;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(315, 176);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bReportColour);
            this.groupBox1.Controls.Add(this.bDefaultCategory);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 149);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payee Details";
            // 
            // bReportColour
            // 
            this.bReportColour.Location = new System.Drawing.Point(112, 92);
            this.bReportColour.Name = "bReportColour";
            this.bReportColour.Size = new System.Drawing.Size(75, 23);
            this.bReportColour.TabIndex = 2;
            this.bReportColour.UseVisualStyleBackColor = true;
            // 
            // bDefaultCategory
            // 
            this.bDefaultCategory.Location = new System.Drawing.Point(112, 58);
            this.bDefaultCategory.Name = "bDefaultCategory";
            this.bDefaultCategory.Size = new System.Drawing.Size(244, 23);
            this.bDefaultCategory.TabIndex = 1;
            this.bDefaultCategory.Text = "Default Category";
            this.bDefaultCategory.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(112, 26);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(244, 20);
            this.tbName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Report Colour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // payees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 215);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "payees";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Payee";
            this.Load += new System.EventHandler(this.payees_Load);
            this.Shown += new System.EventHandler(this.payees_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bReportColour;
        private System.Windows.Forms.Button bDefaultCategory;
        private System.Windows.Forms.TextBox tbName;
    }
}