namespace Pr9
{
    partial class pr9_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pr9_1));
            label5 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            labelResult = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelResult2 = new Label();
            labelResult3 = new Label();
            labelResult4 = new Label();
            buttonBack = new Button();
            buttonReset = new Button();
            buttonResult = new Button();
            flowLayoutPanel5 = new FlowLayoutPanel();
            textBoxSymbol = new TextBox();
            label2 = new Label();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(25, 21);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(300, 25);
            label5.TabIndex = 3;
            label5.Text = "Работа с символьным свойством\r\n";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(label5);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(10, 10);
            flowLayoutPanel2.Margin = new Padding(6);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(19, 21, 19, 21);
            flowLayoutPanel2.Size = new Size(697, 67);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(textBoxSymbol);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel3.Dock = DockStyle.Top;
            flowLayoutPanel3.Location = new Point(10, 77);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(10);
            flowLayoutPanel3.Size = new Size(697, 87);
            flowLayoutPanel3.TabIndex = 15;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(16, 10);
            labelResult.Margin = new Padding(6, 0, 6, 0);
            labelResult.MaximumSize = new Size(1920, 1080);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 25);
            labelResult.TabIndex = 11;
            labelResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(labelResult);
            flowLayoutPanel1.Controls.Add(labelResult2);
            flowLayoutPanel1.Controls.Add(labelResult3);
            flowLayoutPanel1.Controls.Add(labelResult4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(10, 164);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(697, 89);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // labelResult2
            // 
            labelResult2.AutoSize = true;
            labelResult2.Location = new Point(28, 10);
            labelResult2.Margin = new Padding(6, 0, 6, 0);
            labelResult2.MaximumSize = new Size(1920, 1080);
            labelResult2.Name = "labelResult2";
            labelResult2.Size = new Size(0, 25);
            labelResult2.TabIndex = 12;
            labelResult2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelResult3
            // 
            labelResult3.AutoSize = true;
            labelResult3.Location = new Point(40, 10);
            labelResult3.Margin = new Padding(6, 0, 6, 0);
            labelResult3.MaximumSize = new Size(1920, 1080);
            labelResult3.Name = "labelResult3";
            labelResult3.Size = new Size(0, 25);
            labelResult3.TabIndex = 13;
            labelResult3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelResult4
            // 
            labelResult4.AutoSize = true;
            labelResult4.Location = new Point(52, 10);
            labelResult4.Margin = new Padding(6, 0, 6, 0);
            labelResult4.MaximumSize = new Size(1920, 1080);
            labelResult4.Name = "labelResult4";
            labelResult4.Size = new Size(0, 25);
            labelResult4.TabIndex = 14;
            labelResult4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonBack
            // 
            buttonBack.AutoSize = true;
            buttonBack.Location = new Point(207, 13);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(111, 35);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Вернуться";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonReset
            // 
            buttonReset.AutoSize = true;
            buttonReset.Location = new Point(125, 13);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(76, 35);
            buttonReset.TabIndex = 1;
            buttonReset.Text = "Сброс";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonResult
            // 
            buttonResult.AutoSize = true;
            buttonResult.Location = new Point(13, 13);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(106, 35);
            buttonResult.TabIndex = 0;
            buttonResult.Text = "Результат";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(buttonResult);
            flowLayoutPanel5.Controls.Add(buttonReset);
            flowLayoutPanel5.Controls.Add(buttonBack);
            flowLayoutPanel5.Location = new Point(353, 13);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(10);
            flowLayoutPanel5.Size = new Size(331, 61);
            flowLayoutPanel5.TabIndex = 3;
            // 
            // textBoxSymbol
            // 
            textBoxSymbol.Location = new Point(178, 16);
            textBoxSymbol.Margin = new Padding(6);
            textBoxSymbol.MaxLength = 100000000;
            textBoxSymbol.Name = "textBoxSymbol";
            textBoxSymbol.Size = new Size(166, 33);
            textBoxSymbol.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 10);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 14;
            label2.Text = "Введите размер";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pr9_1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(717, 263);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(720, 250);
            Name = "pr9_1";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pr9_1";
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        //private Label label4;
        //private TextBox textBoxEnd;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label labelResult;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelResult2;
        private Label labelResult3;
        private Label labelResult4;
        private Label label2;
        private TextBox textBoxSymbol;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button buttonResult;
        private Button buttonReset;
        private Button buttonBack;
    }
}