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
            textBox1 = new TextBox();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label3 = new Label();
            button6 = new Button();
            button5 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(410, 22);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 93);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 2;
            label2.Text = "Git Auth Token";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Lime;
            linkLabel1.Location = new Point(249, 93);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(175, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Generate One (GitHub)";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(14, 166);
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
            button2.Location = new Point(106, 166);
            button2.Name = "button2";
            button2.Size = new Size(86, 38);
            button2.TabIndex = 5;
            button2.Text = "PUSH";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(246, 166);
            button3.Name = "button3";
            button3.Size = new Size(86, 38);
            button3.TabIndex = 6;
            button3.Text = "FETCH";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(338, 166);
            button4.Name = "button4";
            button4.Size = new Size(86, 38);
            button4.TabIndex = 7;
            button4.Text = "COMMIT";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 148);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 8;
            label1.Text = "ACTIONS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 233);
            label3.Name = "label3";
            label3.Size = new Size(151, 15);
            label3.TabIndex = 10;
            label3.Text = "Active Directories";
            // 
            // button6
            // 
            button6.Font = new Font("Agave Nerd Font Mono", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Lime;
            button6.Location = new Point(344, 210);
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
            button5.Location = new Point(387, 210);
            button5.Name = "button5";
            button5.Size = new Size(37, 35);
            button5.TabIndex = 11;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(14, 251);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(410, 259);
            listBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(438, 528);
            Controls.Add(listBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Font = new Font("Agave Nerd Font Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "GitGud";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label3;
        private Button button6;
        private Button button5;
        private ListBox listBox1;
    }
}