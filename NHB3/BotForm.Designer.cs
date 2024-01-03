namespace NHB3
{
    partial class BotForm
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
            checkBox1 = new System.Windows.Forms.CheckBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            checkBox3 = new System.Windows.Forms.CheckBox();
            button1 = new System.Windows.Forms.Button();
            HighestPrice = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            LowestPrice = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            LowerStepMultiple = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            IncreaseStepMultiple = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(10, 11);
            checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(209, 21);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Refill order when spent hit 90%";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(10, 37);
            checkBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(393, 21);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Lower order price for one step if cheaper hashpower available";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new System.Drawing.Point(10, 64);
            checkBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(375, 21);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Increase order price for one step if order run out of miners";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(383, 225);
            button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(58, 27);
            button1.TabIndex = 3;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HighestPrice
            // 
            HighestPrice.Location = new System.Drawing.Point(95, 86);
            HighestPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            HighestPrice.Name = "HighestPrice";
            HighestPrice.Size = new System.Drawing.Size(278, 23);
            HighestPrice.TabIndex = 13;
            HighestPrice.Text = "1.5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(11, 89);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 17);
            label4.TabIndex = 12;
            label4.Text = "HighestPrice";
            // 
            // LowestPrice
            // 
            LowestPrice.Location = new System.Drawing.Point(95, 115);
            LowestPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            LowestPrice.Name = "LowestPrice";
            LowestPrice.Size = new System.Drawing.Size(278, 23);
            LowestPrice.TabIndex = 15;
            LowestPrice.Text = "1.5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 118);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 17);
            label1.TabIndex = 14;
            label1.Text = "LowestPrice";
            // 
            // LowerStepMultiple
            // 
            LowerStepMultiple.Location = new System.Drawing.Point(145, 144);
            LowerStepMultiple.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            LowerStepMultiple.Name = "LowerStepMultiple";
            LowerStepMultiple.Size = new System.Drawing.Size(228, 23);
            LowerStepMultiple.TabIndex = 17;
            LowerStepMultiple.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 147);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(116, 17);
            label2.TabIndex = 16;
            label2.Text = "LowerStepMultiple";
            // 
            // IncreaseStepMultiple
            // 
            IncreaseStepMultiple.Location = new System.Drawing.Point(145, 173);
            IncreaseStepMultiple.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            IncreaseStepMultiple.Name = "IncreaseStepMultiple";
            IncreaseStepMultiple.Size = new System.Drawing.Size(228, 23);
            IncreaseStepMultiple.TabIndex = 19;
            IncreaseStepMultiple.Text = "0.1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(11, 176);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(130, 17);
            label3.TabIndex = 18;
            label3.Text = "IncreaseStepMultiple";
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(11, 199);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(294, 62);
            label5.TabIndex = 20;
            label5.Text = "LowerStepMultiple and IncreaseStepMultiple: Bot lower/increase order price with price_step_down*StepMultiple";
            // 
            // BotForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(452, 257);
            Controls.Add(label5);
            Controls.Add(IncreaseStepMultiple);
            Controls.Add(label3);
            Controls.Add(LowerStepMultiple);
            Controls.Add(label2);
            Controls.Add(LowestPrice);
            Controls.Add(label1);
            Controls.Add(HighestPrice);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Name = "BotForm";
            Text = "Bot settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox HighestPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LowestPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LowerStepMultiple;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IncreaseStepMultiple;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}