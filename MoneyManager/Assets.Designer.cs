namespace MoneyManager
{
    partial class assets
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbAssetType = new System.Windows.Forms.ComboBox();
            this.cbChangeValue = new System.Windows.Forms.ComboBox();
            this.nudRate = new System.Windows.Forms.NumericUpDown();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtbNotes);
            this.groupBox1.Controls.Add(this.nudRate);
            this.groupBox1.Controls.Add(this.cbChangeValue);
            this.groupBox1.Controls.Add(this.cbAssetType);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.tbValue);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asset Details";
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(304, 421);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(223, 421);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 7;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(110, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(239, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(110, 152);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(100, 20);
            this.tbValue.TabIndex = 3;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(110, 72);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // cbAssetType
            // 
            this.cbAssetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAssetType.FormattingEnabled = true;
            this.cbAssetType.Location = new System.Drawing.Point(110, 112);
            this.cbAssetType.Name = "cbAssetType";
            this.cbAssetType.Size = new System.Drawing.Size(239, 21);
            this.cbAssetType.TabIndex = 2;
            // 
            // cbChangeValue
            // 
            this.cbChangeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChangeValue.FormattingEnabled = true;
            this.cbChangeValue.Items.AddRange(new object[] {
            "None",
            "Appreciates",
            "Depreciates"});
            this.cbChangeValue.Location = new System.Drawing.Point(110, 193);
            this.cbChangeValue.Name = "cbChangeValue";
            this.cbChangeValue.Size = new System.Drawing.Size(239, 21);
            this.cbChangeValue.TabIndex = 4;
            // 
            // nudRate
            // 
            this.nudRate.Location = new System.Drawing.Point(110, 233);
            this.nudRate.Name = "nudRate";
            this.nudRate.Size = new System.Drawing.Size(69, 20);
            this.nudRate.TabIndex = 5;
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(111, 269);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(238, 101);
            this.rtbNotes.TabIndex = 6;
            this.rtbNotes.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Asset Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Change in Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "% Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Notes";
            // 
            // assets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 456);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "assets";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Asset";
            this.Shown += new System.EventHandler(this.Assets_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.NumericUpDown nudRate;
        private System.Windows.Forms.ComboBox cbChangeValue;
        private System.Windows.Forms.ComboBox cbAssetType;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}