namespace winFormOrder
{
    partial class Form2
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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            basicInforGroupBox = new GroupBox();
            orderDetailGroupBox = new GroupBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            orderIdLabel = new Label();
            customerLabel = new Label();
            orderTimeLabel = new Label();
            customComboBox = new ComboBox();
            orderTextBox = new TextBox();
            timeLabel = new Label();
            addDetailBtn = new Button();
            modifyDetailBtn = new Button();
            deleteDetailBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            basicInforGroupBox.SuspendLayout();
            orderDetailGroupBox.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Top;
            splitContainer1.Location = new Point(3, 34);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(orderIdLabel);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(orderTextBox);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1690, 82);
            splitContainer1.SplitterDistance = 180;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Top;
            splitContainer2.Location = new Point(3, 116);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(customerLabel);
            splitContainer2.Panel1.Paint += splitContainer2_Panel1_Paint;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(customComboBox);
            splitContainer2.Size = new Size(1690, 82);
            splitContainer2.SplitterDistance = 180;
            splitContainer2.TabIndex = 0;
            splitContainer2.SplitterMoved += splitContainer2_SplitterMoved;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(3, 198);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(orderTimeLabel);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(timeLabel);
            splitContainer3.Size = new Size(1690, 86);
            splitContainer3.SplitterDistance = 180;
            splitContainer3.TabIndex = 0;
            splitContainer3.SplitterMoved += splitContainer3_SplitterMoved;
            // 
            // basicInforGroupBox
            // 
            basicInforGroupBox.Controls.Add(splitContainer3);
            basicInforGroupBox.Controls.Add(splitContainer2);
            basicInforGroupBox.Controls.Add(splitContainer1);
            basicInforGroupBox.Dock = DockStyle.Top;
            basicInforGroupBox.Location = new Point(0, 0);
            basicInforGroupBox.Name = "basicInforGroupBox";
            basicInforGroupBox.Size = new Size(1696, 287);
            basicInforGroupBox.TabIndex = 4;
            basicInforGroupBox.TabStop = false;
            basicInforGroupBox.Text = "基本信息";
            basicInforGroupBox.Enter += groupBox1_Enter;
            // 
            // orderDetailGroupBox
            // 
            orderDetailGroupBox.Controls.Add(dataGridView1);
            orderDetailGroupBox.Dock = DockStyle.Top;
            orderDetailGroupBox.Location = new Point(0, 287);
            orderDetailGroupBox.Name = "orderDetailGroupBox";
            orderDetailGroupBox.Size = new Size(1696, 838);
            orderDetailGroupBox.TabIndex = 5;
            orderDetailGroupBox.TabStop = false;
            orderDetailGroupBox.Text = "订单明细";
            // 
            // panel1
            // 
            panel1.Controls.Add(deleteDetailBtn);
            panel1.Controls.Add(modifyDetailBtn);
            panel1.Controls.Add(addDetailBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 1125);
            panel1.Name = "panel1";
            panel1.Size = new Size(1696, 78);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(1690, 801);
            dataGridView1.TabIndex = 0;
            // 
            // orderIdLabel
            // 
            orderIdLabel.Anchor = AnchorStyles.Right;
            orderIdLabel.AutoSize = true;
            orderIdLabel.Location = new Point(88, 23);
            orderIdLabel.Name = "orderIdLabel";
            orderIdLabel.Size = new Size(86, 31);
            orderIdLabel.TabIndex = 0;
            orderIdLabel.Text = "订单号";
            // 
            // customerLabel
            // 
            customerLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            customerLabel.AutoSize = true;
            customerLabel.Location = new Point(109, 25);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(62, 31);
            customerLabel.TabIndex = 0;
            customerLabel.Text = "客户";
            // 
            // orderTimeLabel
            // 
            orderTimeLabel.Anchor = AnchorStyles.Right;
            orderTimeLabel.AutoSize = true;
            orderTimeLabel.Location = new Point(67, 26);
            orderTimeLabel.Name = "orderTimeLabel";
            orderTimeLabel.Size = new Size(110, 31);
            orderTimeLabel.TabIndex = 0;
            orderTimeLabel.Text = "下单时间";
            // 
            // customComboBox
            // 
            customComboBox.BackColor = SystemColors.ScrollBar;
            customComboBox.FormattingEnabled = true;
            customComboBox.Location = new Point(16, 21);
            customComboBox.Name = "customComboBox";
            customComboBox.Size = new Size(656, 39);
            customComboBox.TabIndex = 0;
            // 
            // orderTextBox
            // 
            orderTextBox.Location = new Point(16, 23);
            orderTextBox.Name = "orderTextBox";
            orderTextBox.Size = new Size(656, 38);
            orderTextBox.TabIndex = 0;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(16, 26);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(118, 31);
            timeLabel.TabIndex = 0;
            timeLabel.Text = "2020-1-1";
            // 
            // addDetailBtn
            // 
            addDetailBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addDetailBtn.Location = new Point(46, 13);
            addDetailBtn.Name = "addDetailBtn";
            addDetailBtn.Size = new Size(150, 46);
            addDetailBtn.TabIndex = 0;
            addDetailBtn.Text = "添加明细";
            addDetailBtn.UseVisualStyleBackColor = true;
            // 
            // modifyDetailBtn
            // 
            modifyDetailBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            modifyDetailBtn.Location = new Point(217, 13);
            modifyDetailBtn.Name = "modifyDetailBtn";
            modifyDetailBtn.Size = new Size(150, 46);
            modifyDetailBtn.TabIndex = 1;
            modifyDetailBtn.Text = "修改明细";
            modifyDetailBtn.UseVisualStyleBackColor = true;
            // 
            // deleteDetailBtn
            // 
            deleteDetailBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            deleteDetailBtn.Location = new Point(388, 13);
            deleteDetailBtn.Name = "deleteDetailBtn";
            deleteDetailBtn.Size = new Size(150, 46);
            deleteDetailBtn.TabIndex = 2;
            deleteDetailBtn.Text = "删除明细";
            deleteDetailBtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1696, 1203);
            Controls.Add(panel1);
            Controls.Add(orderDetailGroupBox);
            Controls.Add(basicInforGroupBox);
            Name = "Form2";
            Text = "Form2";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            basicInforGroupBox.ResumeLayout(false);
            orderDetailGroupBox.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private Label label1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private GroupBox basicInforGroupBox;
        private GroupBox orderDetailGroupBox;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label orderIdLabel;
        private Label customerLabel;
        private TextBox orderTextBox;
        private ComboBox customComboBox;
        private Label orderTimeLabel;
        private Label timeLabel;
        private Button deleteDetailBtn;
        private Button modifyDetailBtn;
        private Button addDetailBtn;
    }
}