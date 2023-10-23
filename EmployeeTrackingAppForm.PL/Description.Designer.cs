namespace EmployeeTrackingAppForm.PL
{
    partial class Description
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 57);
            label1.Name = "label1";
            label1.Size = new Size(323, 25);
            label1.TabIndex = 0;
            label1.Text = "Görüntülemek istediğiniz sayfayı seçiniz";
            // 
            // button1
            // 
            button1.Location = new Point(123, 160);
            button1.Name = "button1";
            button1.Size = new Size(242, 34);
            button1.TabIndex = 1;
            button1.Text = "Çalışan listele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(123, 232);
            button2.Name = "button2";
            button2.Size = new Size(242, 34);
            button2.TabIndex = 2;
            button2.Text = "Çalışan özlük Kontrol";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(123, 299);
            button3.Name = "button3";
            button3.Size = new Size(242, 34);
            button3.TabIndex = 3;
            button3.Text = "Çalışan ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(398, 160);
            button4.Name = "button4";
            button4.Size = new Size(220, 34);
            button4.TabIndex = 4;
            button4.Text = "Departman/Kıdem Ekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(398, 232);
            button5.Name = "button5";
            button5.Size = new Size(220, 34);
            button5.TabIndex = 5;
            button5.Text = "Avans Takip";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(398, 299);
            button6.Name = "button6";
            button6.Size = new Size(220, 34);
            button6.TabIndex = 6;
            button6.Text = "İzin Takip";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(123, 365);
            button7.Name = "button7";
            button7.Size = new Size(242, 34);
            button7.TabIndex = 7;
            button7.Text = "Bordro göster";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(398, 365);
            button8.Name = "button8";
            button8.Size = new Size(220, 34);
            button8.TabIndex = 8;
            button8.Text = "Eğitim Bilgileri Kontrol";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Description
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Description";
            Text = "Description";
            Load += Description_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}