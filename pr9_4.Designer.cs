namespace Pr9
{
    partial class pr9_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pr9_4));
            buttonResult = new Button();
            buttonReset = new Button();
            label5 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label2 = new Label();
            textBoxIndex = new TextBox();
            label1 = new Label();
            numericCount = new NumericUpDown();
            label3 = new Label();
            textBoxIndexInsert = new TextBox();
            label4 = new Label();
            textBoxValueInsert = new TextBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            buttonBack = new Button();
            labelResult = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCount).BeginInit();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(25, 21);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(309, 25);
            label5.TabIndex = 3;
            label5.Text = "Работа со статическим свойством";
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
            flowLayoutPanel2.Size = new Size(843, 67);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(textBoxIndex);
            flowLayoutPanel3.Controls.Add(label1);
            flowLayoutPanel3.Controls.Add(numericCount);
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(textBoxIndexInsert);
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Controls.Add(textBoxValueInsert);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel3.Dock = DockStyle.Top;
            flowLayoutPanel3.Location = new Point(10, 77);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(10);
            flowLayoutPanel3.Size = new Size(843, 177);
            flowLayoutPanel3.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 10);
            label2.Margin = new Padding(6, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(254, 25);
            label2.TabIndex = 14;
            label2.Text = "Введите начальный индекс \r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxIndex
            // 
            textBoxIndex.Location = new Point(279, 16);
            textBoxIndex.Margin = new Padding(6);
            textBoxIndex.MaxLength = 100000000;
            textBoxIndex.Name = "textBoxIndex";
            textBoxIndex.Size = new Size(75, 33);
            textBoxIndex.TabIndex = 13;
            textBoxIndex.Text = "-1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 10);
            label1.Margin = new Padding(6, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(277, 25);
            label1.TabIndex = 16;
            label1.Text = "Введите размер массива          ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // numericCount
            // 
            numericCount.Location = new Point(649, 13);
            numericCount.Name = "numericCount";
            numericCount.Size = new Size(76, 33);
            numericCount.TabIndex = 15;
            numericCount.Value = new decimal(new int[] { 11, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 55);
            label3.Margin = new Padding(6, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(254, 25);
            label3.TabIndex = 18;
            label3.Text = "Введите индекс для вставки";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxIndexInsert
            // 
            textBoxIndexInsert.Location = new Point(279, 61);
            textBoxIndexInsert.Margin = new Padding(6);
            textBoxIndexInsert.MaxLength = 100000000;
            textBoxIndexInsert.Name = "textBoxIndexInsert";
            textBoxIndexInsert.Size = new Size(75, 33);
            textBoxIndexInsert.TabIndex = 17;
            textBoxIndexInsert.Text = "-1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 55);
            label4.Margin = new Padding(6, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(276, 25);
            label4.TabIndex = 20;
            label4.Text = "Введите значение для вставки";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxValueInsert
            // 
            textBoxValueInsert.Location = new Point(650, 61);
            textBoxValueInsert.Margin = new Padding(6);
            textBoxValueInsert.MaxLength = 100000000;
            textBoxValueInsert.Name = "textBoxValueInsert";
            textBoxValueInsert.Size = new Size(75, 33);
            textBoxValueInsert.TabIndex = 19;
            textBoxValueInsert.Text = "1000";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(buttonResult);
            flowLayoutPanel5.Controls.Add(buttonReset);
            flowLayoutPanel5.Controls.Add(buttonBack);
            flowLayoutPanel5.Location = new Point(13, 103);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(10);
            flowLayoutPanel5.Size = new Size(331, 61);
            flowLayoutPanel5.TabIndex = 3;
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
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(10, 254);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(843, 58);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // pr9_4
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(863, 322);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(879, 361);
            Name = "pr9_4";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pr9_4";
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericCount).EndInit();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonResult;
        private Button buttonReset;
        //private Label label4;
        //private TextBox textBoxEnd;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button buttonBack;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label labelResult;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox textBoxIndex;
        private Label label1;
        private NumericUpDown numericCount;
        private Label label3;
        private TextBox textBoxIndexInsert;
        private Label label4;
        private TextBox textBoxValueInsert;
    }
}