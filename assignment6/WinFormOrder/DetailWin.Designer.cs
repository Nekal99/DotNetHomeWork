namespace WinFormOrder
{
    partial class DetailWin
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
            this.components = new System.ComponentModel.Container();
            this.basicInformationGB = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.orderTimeLb = new System.Windows.Forms.Label();
            this.timeLb = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.customerLb = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.orderIdLb = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.orderDetailGB = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveOrderBtn = new System.Windows.Forms.Button();
            this.deleteDetailBtn = new System.Windows.Forms.Button();
            this.modifyDetailBtn = new System.Windows.Forms.Button();
            this.addDetailBtn = new System.Windows.Forms.Button();
            this.basicInformationGB.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.orderDetailGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // basicInformationGB
            // 
            this.basicInformationGB.Controls.Add(this.panel4);
            this.basicInformationGB.Controls.Add(this.panel3);
            this.basicInformationGB.Controls.Add(this.panel2);
            this.basicInformationGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.basicInformationGB.Location = new System.Drawing.Point(0, 0);
            this.basicInformationGB.Name = "basicInformationGB";
            this.basicInformationGB.Size = new System.Drawing.Size(1656, 341);
            this.basicInformationGB.TabIndex = 0;
            this.basicInformationGB.TabStop = false;
            this.basicInformationGB.Text = "基本信息";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.splitContainer3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 231);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1650, 107);
            this.panel4.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.orderTimeLb);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.timeLb);
            this.splitContainer3.Size = new System.Drawing.Size(1650, 107);
            this.splitContainer3.SplitterDistance = 169;
            this.splitContainer3.TabIndex = 0;
            // 
            // orderTimeLb
            // 
            this.orderTimeLb.AutoSize = true;
            this.orderTimeLb.Location = new System.Drawing.Point(27, 33);
            this.orderTimeLb.Name = "orderTimeLb";
            this.orderTimeLb.Size = new System.Drawing.Size(106, 24);
            this.orderTimeLb.TabIndex = 0;
            this.orderTimeLb.Text = "下单时间";
            // 
            // timeLb
            // 
            this.timeLb.AutoSize = true;
            this.timeLb.Location = new System.Drawing.Point(15, 43);
            this.timeLb.Name = "timeLb";
            this.timeLb.Size = new System.Drawing.Size(82, 24);
            this.timeLb.TabIndex = 0;
            this.timeLb.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1650, 100);
            this.panel3.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.customerLb);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer2.Size = new System.Drawing.Size(1650, 100);
            this.splitContainer2.SplitterDistance = 169;
            this.splitContainer2.TabIndex = 0;
            // 
            // customerLb
            // 
            this.customerLb.AutoSize = true;
            this.customerLb.Location = new System.Drawing.Point(75, 34);
            this.customerLb.Name = "customerLb";
            this.customerLb.Size = new System.Drawing.Size(58, 24);
            this.customerLb.TabIndex = 0;
            this.customerLb.Text = "客户";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Customer1",
            "Customer2"});
            this.comboBox1.Location = new System.Drawing.Point(19, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(567, 32);
            this.comboBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1650, 100);
            this.panel2.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.orderIdLb);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1650, 100);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 0;
            // 
            // orderIdLb
            // 
            this.orderIdLb.AutoSize = true;
            this.orderIdLb.Location = new System.Drawing.Point(51, 41);
            this.orderIdLb.Name = "orderIdLb";
            this.orderIdLb.Size = new System.Drawing.Size(82, 24);
            this.orderIdLb.TabIndex = 0;
            this.orderIdLb.Text = "订单号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(567, 35);
            this.textBox1.TabIndex = 0;
            // 
            // orderDetailGB
            // 
            this.orderDetailGB.Controls.Add(this.dataGridView1);
            this.orderDetailGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderDetailGB.Location = new System.Drawing.Point(0, 341);
            this.orderDetailGB.Name = "orderDetailGB";
            this.orderDetailGB.Size = new System.Drawing.Size(1656, 437);
            this.orderDetailGB.TabIndex = 1;
            this.orderDetailGB.TabStop = false;
            this.orderDetailGB.Text = "订单明细";
            this.orderDetailGB.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderDetailBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1650, 403);
            this.dataGridView1.TabIndex = 0;
            // 
            // goodsDataGridViewTextBoxColumn
            // 
            this.goodsDataGridViewTextBoxColumn.DataPropertyName = "Goods";
            this.goodsDataGridViewTextBoxColumn.HeaderText = "货物";
            this.goodsDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
            this.goodsDataGridViewTextBoxColumn.Width = 200;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "数量";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "价格";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(OrderApp.OrderDetail);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveOrderBtn);
            this.panel1.Controls.Add(this.deleteDetailBtn);
            this.panel1.Controls.Add(this.modifyDetailBtn);
            this.panel1.Controls.Add(this.addDetailBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 778);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1656, 86);
            this.panel1.TabIndex = 2;
            // 
            // saveOrderBtn
            // 
            this.saveOrderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveOrderBtn.Location = new System.Drawing.Point(1489, 18);
            this.saveOrderBtn.Name = "saveOrderBtn";
            this.saveOrderBtn.Size = new System.Drawing.Size(137, 43);
            this.saveOrderBtn.TabIndex = 3;
            this.saveOrderBtn.Text = "保存订单";
            this.saveOrderBtn.UseVisualStyleBackColor = true;
            this.saveOrderBtn.Click += new System.EventHandler(this.saveOrderBtn_Click);
            // 
            // deleteDetailBtn
            // 
            this.deleteDetailBtn.Location = new System.Drawing.Point(381, 18);
            this.deleteDetailBtn.Name = "deleteDetailBtn";
            this.deleteDetailBtn.Size = new System.Drawing.Size(137, 43);
            this.deleteDetailBtn.TabIndex = 2;
            this.deleteDetailBtn.Text = "删除明细";
            this.deleteDetailBtn.UseVisualStyleBackColor = true;
            // 
            // modifyDetailBtn
            // 
            this.modifyDetailBtn.Location = new System.Drawing.Point(195, 18);
            this.modifyDetailBtn.Name = "modifyDetailBtn";
            this.modifyDetailBtn.Size = new System.Drawing.Size(137, 43);
            this.modifyDetailBtn.TabIndex = 1;
            this.modifyDetailBtn.Text = "修改明细";
            this.modifyDetailBtn.UseVisualStyleBackColor = true;
            // 
            // addDetailBtn
            // 
            this.addDetailBtn.Location = new System.Drawing.Point(23, 18);
            this.addDetailBtn.Name = "addDetailBtn";
            this.addDetailBtn.Size = new System.Drawing.Size(137, 43);
            this.addDetailBtn.TabIndex = 0;
            this.addDetailBtn.Text = "添加明细";
            this.addDetailBtn.UseVisualStyleBackColor = true;
            this.addDetailBtn.Click += new System.EventHandler(this.addDetailBtn_Click);
            // 
            // DetailWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 864);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.orderDetailGB);
            this.Controls.Add(this.basicInformationGB);
            this.Name = "DetailWin";
            this.Text = "DetailWin";
            this.basicInformationGB.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.orderDetailGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox basicInformationGB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox orderDetailGB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label orderTimeLb;
        private System.Windows.Forms.Label timeLb;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label customerLb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label orderIdLb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.Button saveOrderBtn;
        private System.Windows.Forms.Button deleteDetailBtn;
        private System.Windows.Forms.Button modifyDetailBtn;
        private System.Windows.Forms.Button addDetailBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
    }
}