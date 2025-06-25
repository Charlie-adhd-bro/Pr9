namespace Pr9
{
    partial class FormMain
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
            buttonExit = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonExit
            // 
            buttonExit.AutoSize = true;
            buttonExit.Location = new Point(24, 25);
            buttonExit.Margin = new Padding(8);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(266, 35);
            buttonExit.TabIndex = 10;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(118, 25);
            button2.Margin = new Padding(8);
            button2.Name = "button2";
            button2.Size = new Size(78, 74);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Location = new Point(212, 25);
            button3.Margin = new Padding(8);
            button3.Name = "button3";
            button3.Size = new Size(78, 74);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Location = new Point(24, 115);
            button4.Margin = new Padding(8);
            button4.Name = "button4";
            button4.Size = new Size(78, 74);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.Location = new Point(118, 115);
            button5.Margin = new Padding(8);
            button5.Name = "button5";
            button5.Size = new Size(78, 74);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Location = new Point(212, 115);
            button6.Margin = new Padding(8);
            button6.Name = "button6";
            button6.Size = new Size(78, 74);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(8);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(16, 17, 16, 17);
            flowLayoutPanel1.Size = new Size(314, 214);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(24, 25);
            button1.Margin = new Padding(8);
            button1.Name = "button1";
            button1.Size = new Size(78, 74);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(buttonExit);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 214);
            flowLayoutPanel2.Margin = new Padding(8);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(16, 17, 16, 17);
            flowLayoutPanel2.Size = new Size(314, 79);
            flowLayoutPanel2.TabIndex = 13;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 293);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormMain";
            Text = "Главная форма";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExit;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
