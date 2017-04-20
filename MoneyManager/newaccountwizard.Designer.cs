namespace MoneyManager
{
    partial class newaccountwizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newaccountwizard));
            this.bPrevious = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.tpAccountType = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tbAccountName = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbNameofAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpNewAccountDetails = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcAccountWizard = new System.Windows.Forms.TabControl();
            this.cbTypeAccount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpAccountType.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tbAccountName.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tpNewAccountDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcAccountWizard.SuspendLayout();
            this.SuspendLayout();
            // 
            // bPrevious
            // 
            this.bPrevious.Location = new System.Drawing.Point(243, 381);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(75, 23);
            this.bPrevious.TabIndex = 0;
            this.bPrevious.Text = "< Previous";
            this.bPrevious.UseVisualStyleBackColor = true;
            this.bPrevious.Click += new System.EventHandler(this.bPrevious_Click);
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(324, 381);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(75, 23);
            this.bNext.TabIndex = 1;
            this.bNext.Text = "Next >";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(438, 381);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // tpAccountType
            // 
            this.tpAccountType.Controls.Add(this.groupBox4);
            this.tpAccountType.Location = new System.Drawing.Point(4, 22);
            this.tpAccountType.Name = "tpAccountType";
            this.tpAccountType.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccountType.Size = new System.Drawing.Size(493, 327);
            this.tpAccountType.TabIndex = 3;
            this.tpAccountType.Text = "Type of Account";
            this.tpAccountType.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.cbTypeAccount);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 321);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "New Account Details";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox4.Size = new System.Drawing.Size(130, 302);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // tbAccountName
            // 
            this.tbAccountName.Controls.Add(this.groupBox2);
            this.tbAccountName.Location = new System.Drawing.Point(4, 22);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Padding = new System.Windows.Forms.Padding(3);
            this.tbAccountName.Size = new System.Drawing.Size(493, 327);
            this.tbAccountName.TabIndex = 1;
            this.tbAccountName.Text = "Account Name";
            this.tbAccountName.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbNameofAccount);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 321);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Account Details";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox2.Size = new System.Drawing.Size(130, 302);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // tbNameofAccount
            // 
            this.tbNameofAccount.Location = new System.Drawing.Point(159, 55);
            this.tbNameofAccount.Name = "tbNameofAccount";
            this.tbNameofAccount.Size = new System.Drawing.Size(305, 20);
            this.tbNameofAccount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name of the account";
            // 
            // tpNewAccountDetails
            // 
            this.tpNewAccountDetails.Controls.Add(this.groupBox1);
            this.tpNewAccountDetails.Location = new System.Drawing.Point(4, 22);
            this.tpNewAccountDetails.Name = "tpNewAccountDetails";
            this.tpNewAccountDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpNewAccountDetails.Size = new System.Drawing.Size(493, 327);
            this.tpNewAccountDetails.TabIndex = 0;
            this.tpNewAccountDetails.Text = "New Account Details";
            this.tpNewAccountDetails.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Account Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(130, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tcAccountWizard
            // 
            this.tcAccountWizard.Controls.Add(this.tpNewAccountDetails);
            this.tcAccountWizard.Controls.Add(this.tbAccountName);
            this.tcAccountWizard.Controls.Add(this.tpAccountType);
            this.tcAccountWizard.Location = new System.Drawing.Point(12, 12);
            this.tcAccountWizard.Name = "tcAccountWizard";
            this.tcAccountWizard.SelectedIndex = 0;
            this.tcAccountWizard.Size = new System.Drawing.Size(501, 353);
            this.tcAccountWizard.TabIndex = 3;
            // 
            // cbTypeAccount
            // 
            this.cbTypeAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeAccount.FormattingEnabled = true;
            this.cbTypeAccount.Items.AddRange(new object[] {
            "Current",
            "Term",
            "Investment"});
            this.cbTypeAccount.Location = new System.Drawing.Point(159, 55);
            this.cbTypeAccount.Name = "cbTypeAccount";
            this.cbTypeAccount.Size = new System.Drawing.Size(283, 21);
            this.cbTypeAccount.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type of account";
            // 
            // newaccountwizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 416);
            this.Controls.Add(this.tcAccountWizard);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bPrevious);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newaccountwizard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Account Wizard";
            this.Shown += new System.EventHandler(this.newaccountwizard_Shown);
            this.tpAccountType.ResumeLayout(false);
            this.tpAccountType.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tbAccountName.ResumeLayout(false);
            this.tbAccountName.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tpNewAccountDetails.ResumeLayout(false);
            this.tpNewAccountDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcAccountWizard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bPrevious;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TabPage tpAccountType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbTypeAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TabPage tbAccountName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameofAccount;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tpNewAccountDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tcAccountWizard;
    }
}