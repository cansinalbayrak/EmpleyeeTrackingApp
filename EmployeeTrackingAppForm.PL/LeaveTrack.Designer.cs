namespace EmployeeTrackingAppForm.PL
{
    partial class LeaveTrack
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            listBox1 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 19);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 0;
            label1.Text = "İzin Ekleyiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(419, 19);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 1;
            label2.Text = "İzinleri Listeleyiniz";
            // 
            // button1
            // 
            button1.Location = new Point(41, 391);
            button1.Name = "button1";
            button1.Size = new Size(98, 41);
            button1.TabIndex = 2;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(419, 73);
            button2.Name = "button2";
            button2.Size = new Size(98, 41);
            button2.TabIndex = 3;
            button2.Text = "Listele";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(97, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(241, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(48, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(97, 31);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(241, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(97, 31);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(42, 284);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(97, 31);
            textBox5.TabIndex = 8;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(574, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(308, 404);
            listBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 256);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 10;
            label3.Text = "Bitiş Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 157);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 11;
            label4.Text = "Başlangıç Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(241, 71);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 12;
            label5.Text = "İzin Tipi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 71);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 13;
            label6.Text = "Çalışan Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(241, 157);
            label7.Name = "label7";
            label7.Size = new Size(109, 25);
            label7.TabIndex = 14;
            label7.Text = "İzin Durumu";
            // 
            // LeaveTrack
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 514);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LeaveTrack";
            Text = "LeaveTrack";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ListBox listBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}