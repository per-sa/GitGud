namespace GitGud
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label3 = new Label();
            button6 = new Button();
            button5 = new Button();
            listBox1 = new ListBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(12, 27);
            button1.Name = "button1";
            button1.Size = new Size(86, 38);
            button1.TabIndex = 4;
            button1.Text = "PULL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(104, 27);
            button2.Name = "button2";
            button2.Size = new Size(86, 38);
            button2.TabIndex = 5;
            button2.Text = "PUSH";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(248, 27);
            button3.Name = "button3";
            button3.Size = new Size(86, 38);
            button3.TabIndex = 6;
            button3.Text = "FETCH";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(338, 27);
            button4.Name = "button4";
            button4.Size = new Size(86, 38);
            button4.TabIndex = 7;
            button4.Text = "COMMIT";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 8;
            label1.Text = "ACTIONS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(151, 15);
            label3.TabIndex = 10;
            label3.Text = "Active Directories";
            // 
            // button6
            // 
            button6.Font = new Font("Agave Nerd Font Mono", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Lime;
            button6.Location = new Point(344, 68);
            button6.Name = "button6";
            button6.Size = new Size(37, 35);
            button6.TabIndex = 12;
            button6.Text = "+";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Agave Nerd Font Mono", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Red;
            button5.Location = new Point(387, 68);
            button5.Name = "button5";
            button5.Size = new Size(37, 35);
            button5.TabIndex = 11;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 109);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(410, 259);
            listBox1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 399);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 14;
            label2.Text = "LOGS";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InfoText;
            richTextBox1.ForeColor = SystemColors.Menu;
            richTextBox1.Location = new Point(12, 417);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(410, 290);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(438, 719);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Agave Nerd Font Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "GitGud";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label3;
        private Button button6;
        private Button button5;
        private ListBox listBox1;
        private Label label2;
        private RichTextBox richTextBox1;
    }
}