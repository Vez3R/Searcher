using MyLib2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp2
{

    public partial class Form3 : Form
    {
        static string path = "base.txt";
        static string[] f2 = File.ReadAllLines(path);
        People file1 = new People(f2);
        Form1 form1 = new Form1();
        public Form3(Form1 owner)
        {
            InitializeComponent();
            form1 = owner;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void Form3_FormClosing(Object sender, FormClosingEventArgs e)
        {
            form1.button1.Enabled = true;
            form1.button2.Enabled = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length == 0) { textBox1.PlaceholderText = "Введите что-то!"; textBox1.Text = ""; }
            else
            {
                string[] inf = textBox1.Text.Split(new char[] { '\n', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in inf)
                {
                    file1.Peo = People.append(file1.Peo, s);
                }

                File.WriteAllLines(path, file1.Peo);
                pictureBox1.Visible = true;
                timer1.Enabled = true;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
