namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            button5 = new Button();
            label3 = new Label();
            label4 = new Label();
            button6 = new Button();
            button7 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(431, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 25);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(431, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 25);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(624, 53);
            button1.Name = "button1";
            button1.Size = new Size(97, 28);
            button1.TabIndex = 2;
            button1.Text = "Toplama";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(624, 88);
            button2.Name = "button2";
            button2.Size = new Size(97, 28);
            button2.TabIndex = 3;
            button2.Text = "Çıkarma";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(624, 123);
            button3.Name = "button3";
            button3.Size = new Size(97, 28);
            button3.TabIndex = 4;
            button3.Text = "Bölme";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(294, 57);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 5;
            label1.Text = "Sayı 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(294, 97);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 6;
            label2.Text = "Sayı 2";
            // 
            // button5
            // 
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 7;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 1;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            // 
            // button6
            // 
            button6.Location = new Point(624, 157);
            button6.Name = "button6";
            button6.Size = new Size(97, 27);
            button6.TabIndex = 9;
            button6.Text = "Çarpma";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.ForeColor = Color.IndianRed;
            button7.Location = new Point(431, 157);
            button7.Name = "button7";
            button7.Size = new Size(128, 27);
            button7.TabIndex = 10;
            button7.Text = "Çıkış";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(471, 128);
            label5.Name = "label5";
            label5.Size = new Size(48, 18);
            label5.TabIndex = 11;
            label5.Text = "_____";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(294, 133);
            label6.Name = "label6";
            label6.Size = new Size(76, 17);
            label6.TabIndex = 12;
            label6.Text = "SONUÇ =";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            CancelButton = button7;
            ClientSize = new Size(1028, 540);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "HESAP MAKİNESİ";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Button button5;
        private Label label3;
        private Label label4;
        private Button button6;
        private Button button7;
        private Label label5;
        private Label label6;
    }
}