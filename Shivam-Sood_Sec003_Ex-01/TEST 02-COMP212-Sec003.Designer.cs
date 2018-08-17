namespace Shivam_Sood_Sec003_Ex_01
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDisplay = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.tbBankerName = new System.Windows.Forms.TextBox();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.tbAccNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnMax = new System.Windows.Forms.Button();
            this.BtnRemoveFront = new System.Windows.Forms.Button();
            this.BtnAddBack = new System.Windows.Forms.Button();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.LbLinkedList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbOutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDisplay);
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.BtnInsert);
            this.groupBox1.Controls.Add(this.tbBankerName);
            this.groupBox1.Controls.Add(this.tbBalance);
            this.groupBox1.Controls.Add(this.tbCustName);
            this.groupBox1.Controls.Add(this.tbAccNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank Account Info-Sorted Dictionary";
            // 
            // BtnDisplay
            // 
            this.BtnDisplay.Location = new System.Drawing.Point(271, 191);
            this.BtnDisplay.Name = "BtnDisplay";
            this.BtnDisplay.Size = new System.Drawing.Size(75, 23);
            this.BtnDisplay.TabIndex = 19;
            this.BtnDisplay.Text = "Display";
            this.BtnDisplay.UseVisualStyleBackColor = true;
            this.BtnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(271, 135);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 18;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(271, 80);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 17;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(271, 32);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 16;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // tbBankerName
            // 
            this.tbBankerName.Location = new System.Drawing.Point(138, 191);
            this.tbBankerName.Name = "tbBankerName";
            this.tbBankerName.Size = new System.Drawing.Size(100, 20);
            this.tbBankerName.TabIndex = 15;
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(138, 136);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(100, 20);
            this.tbBalance.TabIndex = 14;
            // 
            // tbCustName
            // 
            this.tbCustName.Location = new System.Drawing.Point(138, 82);
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(100, 20);
            this.tbCustName.TabIndex = 13;
            // 
            // tbAccNo
            // 
            this.tbAccNo.Location = new System.Drawing.Point(138, 34);
            this.tbAccNo.Name = "tbAccNo";
            this.tbAccNo.Size = new System.Drawing.Size(100, 20);
            this.tbAccNo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Banker Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Balance(CAD):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Account Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnMax);
            this.groupBox2.Controls.Add(this.BtnRemoveFront);
            this.groupBox2.Controls.Add(this.BtnAddBack);
            this.groupBox2.Controls.Add(this.BtnGenerate);
            this.groupBox2.Controls.Add(this.LbLinkedList);
            this.groupBox2.Location = new System.Drawing.Point(415, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 257);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Linked List of Values";
            // 
            // BtnMax
            // 
            this.BtnMax.Location = new System.Drawing.Point(197, 191);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(117, 23);
            this.BtnMax.TabIndex = 7;
            this.BtnMax.Text = "Maximum";
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // BtnRemoveFront
            // 
            this.BtnRemoveFront.Location = new System.Drawing.Point(197, 135);
            this.BtnRemoveFront.Name = "BtnRemoveFront";
            this.BtnRemoveFront.Size = new System.Drawing.Size(117, 23);
            this.BtnRemoveFront.TabIndex = 6;
            this.BtnRemoveFront.Text = "Remove from Front";
            this.BtnRemoveFront.UseVisualStyleBackColor = true;
            this.BtnRemoveFront.Click += new System.EventHandler(this.BtnRemoveFront_Click);
            // 
            // BtnAddBack
            // 
            this.BtnAddBack.Location = new System.Drawing.Point(197, 85);
            this.BtnAddBack.Name = "BtnAddBack";
            this.BtnAddBack.Size = new System.Drawing.Size(117, 23);
            this.BtnAddBack.TabIndex = 5;
            this.BtnAddBack.Text = "Add at Back";
            this.BtnAddBack.UseVisualStyleBackColor = true;
            this.BtnAddBack.Click += new System.EventHandler(this.BtnAddBack_Click);
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(197, 29);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(117, 23);
            this.BtnGenerate.TabIndex = 4;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // LbLinkedList
            // 
            this.LbLinkedList.FormattingEnabled = true;
            this.LbLinkedList.Location = new System.Drawing.Point(6, 19);
            this.LbLinkedList.Name = "LbLinkedList";
            this.LbLinkedList.Size = new System.Drawing.Size(120, 199);
            this.LbLinkedList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output";
            // 
            // TbOutput
            // 
            this.TbOutput.Location = new System.Drawing.Point(12, 334);
            this.TbOutput.Multiline = true;
            this.TbOutput.Name = "TbOutput";
            this.TbOutput.Size = new System.Drawing.Size(751, 87);
            this.TbOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 453);
            this.Controls.Add(this.TbOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TEST 02-COMP212-Sec003";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Button BtnRemoveFront;
        private System.Windows.Forms.Button BtnAddBack;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.ListBox LbLinkedList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDisplay;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.TextBox tbBankerName;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.TextBox tbCustName;
        private System.Windows.Forms.TextBox tbAccNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbOutput;
    }
}

