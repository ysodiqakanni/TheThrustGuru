﻿namespace TheThrustGuru
{
    partial class PointOfSaleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchNametextBox = new System.Windows.Forms.TextBox();
            this.searchCategorycomboBox = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SelectSellercomboBox = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalpricetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalQuantitytextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.discountTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.amountPayableTextbox = new System.Windows.Forms.TextBox();
            this.postbutton = new System.Windows.Forms.Button();
            this.generateReceiptButton = new System.Windows.Forms.Button();
            this.cashDrawerButton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.InvoicetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salesTypeComboBox = new System.Windows.Forms.ComboBox();
            this.serviceChargecheckBox = new System.Windows.Forms.CheckBox();
            this.serviceChargeComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(3, 86);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(736, 438);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "S/N";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Category";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Total Qty Available(units)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cost";
            this.Column6.Name = "Column6";
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 70;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Units";
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 70;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Store";
            this.Column8.Name = "Column8";
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView2.Location = new System.Drawing.Point(760, 86);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(374, 438);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "S/N";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cost";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total Quantity";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Unit Price";
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 70;
            // 
            // searchNametextBox
            // 
            this.searchNametextBox.Location = new System.Drawing.Point(27, 50);
            this.searchNametextBox.Name = "searchNametextBox";
            this.searchNametextBox.Size = new System.Drawing.Size(178, 20);
            this.searchNametextBox.TabIndex = 1;
            this.searchNametextBox.Enter += new System.EventHandler(this.searchNametextBox_Enter);
            this.searchNametextBox.Leave += new System.EventHandler(this.serachNametextBox_Leave);
            // 
            // searchCategorycomboBox
            // 
            this.searchCategorycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCategorycomboBox.FormattingEnabled = true;
            this.searchCategorycomboBox.Location = new System.Drawing.Point(221, 50);
            this.searchCategorycomboBox.Name = "searchCategorycomboBox";
            this.searchCategorycomboBox.Size = new System.Drawing.Size(163, 21);
            this.searchCategorycomboBox.TabIndex = 2;
            this.searchCategorycomboBox.DropDown += new System.EventHandler(this.searchCategorycomboBox_DropDown);
            this.searchCategorycomboBox.DropDownClosed += new System.EventHandler(this.searchCategorycomboBox_DropDownClosed);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(397, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 20);
            this.textBox2.TabIndex = 1;
            // 
            // SelectSellercomboBox
            // 
            this.SelectSellercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectSellercomboBox.FormattingEnabled = true;
            this.SelectSellercomboBox.Location = new System.Drawing.Point(599, 50);
            this.SelectSellercomboBox.Name = "SelectSellercomboBox";
            this.SelectSellercomboBox.Size = new System.Drawing.Size(163, 21);
            this.SelectSellercomboBox.TabIndex = 2;
            this.SelectSellercomboBox.DropDown += new System.EventHandler(this.SelectSellercomboBox_DropDown);
            this.SelectSellercomboBox.DropDownClosed += new System.EventHandler(this.SelectSellercomboBox_DropDownClosed);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(942, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 15);
            this.dateLabel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Price";
            // 
            // totalpricetextBox
            // 
            this.totalpricetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpricetextBox.Location = new System.Drawing.Point(17, 577);
            this.totalpricetextBox.Name = "totalpricetextBox";
            this.totalpricetextBox.ReadOnly = true;
            this.totalpricetextBox.Size = new System.Drawing.Size(150, 21);
            this.totalpricetextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Quantity";
            // 
            // totalQuantitytextbox
            // 
            this.totalQuantitytextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalQuantitytextbox.Location = new System.Drawing.Point(179, 577);
            this.totalQuantitytextbox.Name = "totalQuantitytextbox";
            this.totalQuantitytextbox.ReadOnly = true;
            this.totalQuantitytextbox.Size = new System.Drawing.Size(150, 21);
            this.totalQuantitytextbox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Discount (%)";
            // 
            // discountTextbox
            // 
            this.discountTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTextbox.Location = new System.Drawing.Point(339, 577);
            this.discountTextbox.Name = "discountTextbox";
            this.discountTextbox.Size = new System.Drawing.Size(150, 21);
            this.discountTextbox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount Payable";
            // 
            // amountPayableTextbox
            // 
            this.amountPayableTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountPayableTextbox.Location = new System.Drawing.Point(503, 577);
            this.amountPayableTextbox.Name = "amountPayableTextbox";
            this.amountPayableTextbox.ReadOnly = true;
            this.amountPayableTextbox.Size = new System.Drawing.Size(150, 21);
            this.amountPayableTextbox.TabIndex = 5;
            // 
            // postbutton
            // 
            this.postbutton.Location = new System.Drawing.Point(798, 530);
            this.postbutton.Name = "postbutton";
            this.postbutton.Size = new System.Drawing.Size(75, 36);
            this.postbutton.TabIndex = 6;
            this.postbutton.Text = "&Post";
            this.postbutton.UseVisualStyleBackColor = true;
            // 
            // generateReceiptButton
            // 
            this.generateReceiptButton.Location = new System.Drawing.Point(879, 530);
            this.generateReceiptButton.Name = "generateReceiptButton";
            this.generateReceiptButton.Size = new System.Drawing.Size(75, 36);
            this.generateReceiptButton.TabIndex = 6;
            this.generateReceiptButton.Text = "&Generate Receipt";
            this.generateReceiptButton.UseVisualStyleBackColor = true;
            // 
            // cashDrawerButton
            // 
            this.cashDrawerButton.Location = new System.Drawing.Point(960, 529);
            this.cashDrawerButton.Name = "cashDrawerButton";
            this.cashDrawerButton.Size = new System.Drawing.Size(75, 36);
            this.cashDrawerButton.TabIndex = 6;
            this.cashDrawerButton.Text = "&Cash Drawer";
            this.cashDrawerButton.UseVisualStyleBackColor = true;
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(1041, 529);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 36);
            this.clearbutton.TabIndex = 6;
            this.clearbutton.Text = "C&lear";
            this.clearbutton.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(798, 572);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 36);
            this.button5.TabIndex = 6;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(879, 572);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 36);
            this.button6.TabIndex = 6;
            this.button6.Text = "button1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(960, 571);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 36);
            this.button7.TabIndex = 6;
            this.button7.Text = "button1";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1041, 571);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 36);
            this.button8.TabIndex = 6;
            this.button8.Text = "button1";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            // 
            // InvoicetextBox
            // 
            this.InvoicetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoicetextBox.Location = new System.Drawing.Point(783, 51);
            this.InvoicetextBox.Name = "InvoicetextBox";
            this.InvoicetextBox.ReadOnly = true;
            this.InvoicetextBox.Size = new System.Drawing.Size(156, 20);
            this.InvoicetextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(782, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Invoice no.";
            // 
            // salesTypeComboBox
            // 
            this.salesTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.salesTypeComboBox.FormattingEnabled = true;
            this.salesTypeComboBox.Location = new System.Drawing.Point(945, 49);
            this.salesTypeComboBox.Name = "salesTypeComboBox";
            this.salesTypeComboBox.Size = new System.Drawing.Size(163, 21);
            this.salesTypeComboBox.TabIndex = 2;
            this.salesTypeComboBox.DropDown += new System.EventHandler(this.salesTypeComboBox_DropDown);
            this.salesTypeComboBox.DropDownClosed += new System.EventHandler(this.salesTypeComboBox_DropDownClosed);
            // 
            // serviceChargecheckBox
            // 
            this.serviceChargecheckBox.AutoSize = true;
            this.serviceChargecheckBox.Location = new System.Drawing.Point(491, 530);
            this.serviceChargecheckBox.Name = "serviceChargecheckBox";
            this.serviceChargecheckBox.Size = new System.Drawing.Size(137, 17);
            this.serviceChargecheckBox.TabIndex = 8;
            this.serviceChargecheckBox.Text = "Include Service Charge";
            this.serviceChargecheckBox.UseVisualStyleBackColor = true;
            this.serviceChargecheckBox.CheckedChanged += new System.EventHandler(this.serviceChargecheckBox_CheckedChanged);
            // 
            // serviceChargeComboBox
            // 
            this.serviceChargeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceChargeComboBox.Enabled = false;
            this.serviceChargeComboBox.FormattingEnabled = true;
            this.serviceChargeComboBox.Location = new System.Drawing.Point(642, 530);
            this.serviceChargeComboBox.Name = "serviceChargeComboBox";
            this.serviceChargeComboBox.Size = new System.Drawing.Size(145, 21);
            this.serviceChargeComboBox.TabIndex = 9;
            this.serviceChargeComboBox.DropDown += new System.EventHandler(this.serviceChargeComboBox_DropDown);
            this.serviceChargeComboBox.DropDownClosed += new System.EventHandler(this.serviceChargeComboBox_DropDownClosed);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(286, 529);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 21);
            this.textBox1.TabIndex = 5;
            // 
            // PointOfSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 610);
            this.Controls.Add(this.serviceChargeComboBox);
            this.Controls.Add(this.serviceChargecheckBox);
            this.Controls.Add(this.InvoicetextBox);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.cashDrawerButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.generateReceiptButton);
            this.Controls.Add(this.postbutton);
            this.Controls.Add(this.amountPayableTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.discountTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalQuantitytextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalpricetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.salesTypeComboBox);
            this.Controls.Add(this.SelectSellercomboBox);
            this.Controls.Add(this.searchCategorycomboBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.searchNametextBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PointOfSaleForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sale";
            this.Load += new System.EventHandler(this.PointOfSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox searchNametextBox;
        private System.Windows.Forms.ComboBox searchCategorycomboBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox SelectSellercomboBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalpricetextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalQuantitytextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox discountTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amountPayableTextbox;
        private System.Windows.Forms.Button postbutton;
        private System.Windows.Forms.Button generateReceiptButton;
        private System.Windows.Forms.Button cashDrawerButton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox InvoicetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox salesTypeComboBox;
        private System.Windows.Forms.CheckBox serviceChargecheckBox;
        private System.Windows.Forms.ComboBox serviceChargeComboBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}