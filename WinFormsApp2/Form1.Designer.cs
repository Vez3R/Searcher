namespace WinFormsApp2
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(418, 22);
            label1.TabIndex = 0;
            label1.Text = "Выберите поиск или добавление информации.";
            // 
            // button1
            // 
            button1.BackColor = Color.OldLace;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 57);
            button1.MaximumSize = new Size(183, 64);
            button1.MinimumSize = new Size(183, 64);
            button1.Name = "button1";
            button1.Size = new Size(183, 64);
            button1.TabIndex = 1;
            button1.Text = "НАЙТИ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.OldLace;
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(224, 57);
            button2.Name = "button2";
            button2.Size = new Size(183, 64);
            button2.TabIndex = 2;
            button2.Text = "ДОБАВИТЬ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(419, 133);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(435, 172);
            MinimumSize = new Size(435, 172);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Поисковик";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button button1;
        public Button button2;
        public Label label1;
    }
}