namespace winFormOrder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            queryComboBox = new ComboBox();
            queryBtn = new Button();
            queryTextBox = new TextBox();
            panel2 = new Panel();
            exportOrderBtn = new Button();
            importOrderBtn = new Button();
            deleteOrderBtn = new Button();
            modifyOrderBtn = new Button();
            addOrderBtn = new Button();
            splitContainer1 = new SplitContainer();
            orderView = new DataGridView();
            orderDetailView = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(queryComboBox);
            panel1.Controls.Add(queryBtn);
            panel1.Controls.Add(queryTextBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6, 5, 6, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 84);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // queryComboBox
            // 
            queryComboBox.BackColor = SystemColors.ScrollBar;
            queryComboBox.FormattingEnabled = true;
            queryComboBox.Location = new Point(98, 23);
            queryComboBox.Margin = new Padding(6, 5, 6, 5);
            queryComboBox.Name = "queryComboBox";
            queryComboBox.Size = new Size(238, 39);
            queryComboBox.TabIndex = 2;
            // 
            // queryBtn
            // 
            queryBtn.Location = new Point(902, 24);
            queryBtn.Margin = new Padding(6, 5, 6, 5);
            queryBtn.Name = "queryBtn";
            queryBtn.Size = new Size(150, 42);
            queryBtn.TabIndex = 1;
            queryBtn.Text = "查询";
            queryBtn.UseVisualStyleBackColor = true;
            // 
            // queryTextBox
            // 
            queryTextBox.Location = new Point(401, 24);
            queryTextBox.Margin = new Padding(6, 5, 6, 5);
            queryTextBox.Name = "queryTextBox";
            queryTextBox.Size = new Size(414, 38);
            queryTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(exportOrderBtn);
            panel2.Controls.Add(importOrderBtn);
            panel2.Controls.Add(deleteOrderBtn);
            panel2.Controls.Add(modifyOrderBtn);
            panel2.Controls.Add(addOrderBtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 84);
            panel2.Margin = new Padding(6, 5, 6, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1600, 84);
            panel2.TabIndex = 1;
            // 
            // exportOrderBtn
            // 
            exportOrderBtn.Location = new Point(780, 24);
            exportOrderBtn.Margin = new Padding(6, 5, 6, 5);
            exportOrderBtn.Name = "exportOrderBtn";
            exportOrderBtn.Size = new Size(150, 42);
            exportOrderBtn.TabIndex = 4;
            exportOrderBtn.Text = "导出订单";
            exportOrderBtn.UseVisualStyleBackColor = true;
            // 
            // importOrderBtn
            // 
            importOrderBtn.Location = new Point(600, 24);
            importOrderBtn.Margin = new Padding(6, 5, 6, 5);
            importOrderBtn.Name = "importOrderBtn";
            importOrderBtn.Size = new Size(150, 42);
            importOrderBtn.TabIndex = 3;
            importOrderBtn.Text = "导入订单";
            importOrderBtn.UseVisualStyleBackColor = true;
            // 
            // deleteOrderBtn
            // 
            deleteOrderBtn.Location = new Point(420, 24);
            deleteOrderBtn.Margin = new Padding(6, 5, 6, 5);
            deleteOrderBtn.Name = "deleteOrderBtn";
            deleteOrderBtn.Size = new Size(150, 42);
            deleteOrderBtn.TabIndex = 2;
            deleteOrderBtn.Text = "删除订单";
            deleteOrderBtn.UseVisualStyleBackColor = true;
            // 
            // modifyOrderBtn
            // 
            modifyOrderBtn.Location = new Point(240, 24);
            modifyOrderBtn.Margin = new Padding(6, 5, 6, 5);
            modifyOrderBtn.Name = "modifyOrderBtn";
            modifyOrderBtn.Size = new Size(150, 42);
            modifyOrderBtn.TabIndex = 1;
            modifyOrderBtn.Text = "修改订单";
            modifyOrderBtn.UseVisualStyleBackColor = true;
            // 
            // addOrderBtn
            // 
            addOrderBtn.Anchor = AnchorStyles.None;
            addOrderBtn.Location = new Point(60, 24);
            addOrderBtn.Margin = new Padding(6, 5, 6, 5);
            addOrderBtn.Name = "addOrderBtn";
            addOrderBtn.Size = new Size(150, 42);
            addOrderBtn.TabIndex = 0;
            addOrderBtn.Text = "添加订单";
            addOrderBtn.UseVisualStyleBackColor = true;
            addOrderBtn.Click += button2_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 168);
            splitContainer1.Margin = new Padding(6, 5, 6, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(orderView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(orderDetailView);
            splitContainer1.Size = new Size(1600, 653);
            splitContainer1.SplitterDistance = 788;
            splitContainer1.SplitterWidth = 8;
            splitContainer1.TabIndex = 2;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // orderView
            // 
            orderView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderView.Dock = DockStyle.Fill;
            orderView.Location = new Point(0, 0);
            orderView.Margin = new Padding(6, 5, 6, 5);
            orderView.Name = "orderView";
            orderView.RowHeadersWidth = 82;
            orderView.RowTemplate.Height = 25;
            orderView.Size = new Size(788, 653);
            orderView.TabIndex = 0;
            // 
            // orderDetailView
            // 
            orderDetailView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDetailView.Dock = DockStyle.Fill;
            orderDetailView.Location = new Point(0, 0);
            orderDetailView.Margin = new Padding(6, 5, 6, 5);
            orderDetailView.Name = "orderDetailView";
            orderDetailView.RowHeadersWidth = 82;
            orderDetailView.RowTemplate.Height = 25;
            orderDetailView.Size = new Size(804, 653);
            orderDetailView.TabIndex = 0;
            orderDetailView.CellContentClick += orderDetailView_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 821);
            Controls.Add(splitContainer1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)orderView).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private SplitContainer splitContainer1;
        private DataGridView orderView;
        private DataGridView orderDetailView;
        private Button queryBtn;
        private TextBox queryTextBox;
        private Button deleteOrderBtn;
        private Button modifyOrderBtn;
        private Button addOrderBtn;
        private ComboBox queryComboBox;
        private Button exportOrderBtn;
        private Button importOrderBtn;
    }
}