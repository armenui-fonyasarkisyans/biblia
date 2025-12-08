namespace bronbooks
{
    partial class bron
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button3 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightYellow;
            button1.Location = new Point(297, 118);
            button1.Name = "button1";
            button1.Size = new Size(709, 415);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSalmon;
            button2.Location = new Point(297, 118);
            button2.Name = "button2";
            button2.Size = new Size(709, 59);
            button2.TabIndex = 1;
            button2.Text = "Бронирование книг";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 218);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 2;
            label1.Text = "Имя автора";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 299);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 3;
            label2.Text = "Название книги";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(327, 245);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(632, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(327, 335);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(632, 23);
            textBox2.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(817, 473);
            button3.Name = "button3";
            button3.Size = new Size(142, 23);
            button3.TabIndex = 6;
            button3.Text = "Забронировать книгу";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 383);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 7;
            label3.Text = "Выбор библиотеки";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(327, 421);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(632, 23);
            textBox3.TabIndex = 8;
            // 
            // bron
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 695);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "bron";
            Text = "bron";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button3;
        private Label label3;
        private TextBox textBox3;
    }
}