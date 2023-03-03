namespace project2
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
            operateNum1 = new TextBox();
            operateNum2 = new TextBox();
            caculate = new Button();
            result = new Label();
            calOperator = new TextBox();
            SuspendLayout();
            // 
            // operateNum1
            // 
            operateNum1.Location = new Point(381, 212);
            operateNum1.Name = "operateNum1";
            operateNum1.PlaceholderText = "请输入整数操作数1";
            operateNum1.Size = new Size(276, 38);
            operateNum1.TabIndex = 0;
            // 
            // operateNum2
            // 
            operateNum2.Location = new Point(790, 212);
            operateNum2.Name = "operateNum2";
            operateNum2.PlaceholderText = "请输入整数操作数2";
            operateNum2.Size = new Size(291, 38);
            operateNum2.TabIndex = 1;
            // 
            // caculate
            // 
            caculate.Location = new Point(650, 377);
            caculate.Name = "caculate";
            caculate.Size = new Size(150, 46);
            caculate.TabIndex = 2;
            caculate.Text = "Caculate";
            caculate.UseVisualStyleBackColor = true;
            caculate.Click += caculate_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(671, 473);
            result.Name = "result";
            result.Size = new Size(110, 31);
            result.TabIndex = 3;
            result.Text = "操作结果";
            // 
            // calOperator
            // 
            calOperator.Location = new Point(613, 309);
            calOperator.Name = "calOperator";
            calOperator.PlaceholderText = "请输入四则运算符";
            calOperator.Size = new Size(216, 38);
            calOperator.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 987);
            Controls.Add(calOperator);
            Controls.Add(result);
            Controls.Add(caculate);
            Controls.Add(operateNum2);
            Controls.Add(operateNum1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox operateNum1;
        private TextBox operateNum2;
        private Button caculate;
        private Label result;
        private TextBox calOperator;
    }
}