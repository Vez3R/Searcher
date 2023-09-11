namespace WinFormsApp2
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            bindingSource1 = new BindingSource(components);
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            hScrollBar1 = new HScrollBar();
            label2 = new Label();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            button2 = new Button();
            checkBox1 = new CheckBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            numericUpDown1 = new NumericUpDown();
            checkBox2 = new CheckBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 17);
            label1.TabIndex = 1;
            label1.Text = "Введите данные для поиска.";
            // 
            // button1
            // 
            button1.BackColor = Color.OldLace;
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(361, 29);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Найти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 21);
            textBox1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.HotTrack = true;
            tabControl1.Location = new Point(12, 58);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(544, 182);
            tabControl1.TabIndex = 3;
            tabControl1.TabStop = false;
            tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.BackColor = Color.Tan;
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(hScrollBar1);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(536, 154);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Список";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(99, 121);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(16, 98);
            label6.Name = "label6";
            label6.Size = new Size(0, 19);
            label6.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 77);
            label5.Name = "label5";
            label5.Size = new Size(0, 19);
            label5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 56);
            label4.Name = "label4";
            label4.Size = new Size(0, 19);
            label4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 35);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 2;
            // 
            // hScrollBar1
            // 
            hScrollBar1.LargeChange = 1;
            hScrollBar1.Location = new Point(16, 119);
            hScrollBar1.Maximum = 10;
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(80, 17);
            hScrollBar1.TabIndex = 1;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 14);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.AutoScroll = true;
            tabPage2.BackColor = Color.Tan;
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(checkBox1);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(numericUpDown1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(536, 154);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Изменить";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Searcher.Properties.Resources.img_1500051;
            pictureBox1.Location = new Point(503, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(35, 64);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Оставьте поле пустым если хотите удалить строку";
            textBox2.Size = new Size(462, 21);
            textBox2.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = Color.OldLace;
            button2.Enabled = false;
            button2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(6, 93);
            button2.Name = "button2";
            button2.Size = new Size(129, 51);
            button2.TabIndex = 7;
            button2.Text = "Заменить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Tan;
            checkBox1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(141, 125);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(147, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Вы согласны на замену?";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(3, 67);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 4;
            label11.Text = "на:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(74, 38);
            label10.Name = "label10";
            label10.Size = new Size(0, 21);
            label10.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(6, 44);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 2;
            label9.Text = "изменить:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(90, 14);
            label8.Name = "label8";
            label8.Size = new Size(374, 15);
            label8.TabIndex = 1;
            label8.Text = "Выберите номер строки которую хотите изменить, на вкладке \"Список\".";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(6, 6);
            numericUpDown1.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(78, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(205, 9);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(211, 19);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Выберите если хотите точный поиск.";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(567, 245);
            Controls.Add(checkBox2);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Поисковик";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private HScrollBar hScrollBar1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label8;
        private NumericUpDown numericUpDown1;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox textBox2;
        private Button button2;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private CheckBox checkBox2;
        private ToolTip toolTip1;
    }
}