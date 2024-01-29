namespace WinFormsApp2
{
    using Newtonsoft.Json;
    using MyLib2;
    using System.IO;
    using static System.Windows.Forms.LinkLabel;
    using System.Collections;
    using System;
    using Newtonsoft.Json.Linq;
    using System.Xml.Linq;

    public partial class Form2 : Form
    {
        Form1 form1;
        public static string path = "base.txt";
        static string[] f2 = File.ReadAllLines(path);
        People file1 = new People(f2);
        int[] searched = new int[0];
        Dictionary<string, int[]> filter;
        string[] inf;
        string box;
        int cou;
        bool full;
        public Form2(Form1 owner)
        {
            string path = "base.txt";
            string[] f2 = File.ReadAllLines(path);
            People file1 = new People(f2);
            Filter.search_list(file1.Peo);
            InitializeComponent();
            form1 = owner;
            this.Size = new System.Drawing.Size(459, 96);
            this.MaximumSize = new System.Drawing.Size(459, 96);
            this.MinimumSize = new System.Drawing.Size(459, 96);
        }
        public void button1_Click(object sender, EventArgs e)
        {
            f2 = File.ReadAllLines(path);
            box = textBox1.Text;
            if (textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length == 0) { textBox1.PlaceholderText = "Введите что-то!"; textBox1.Text = ""; }
            else
            {
                tabControl1.SelectedIndex = 0;
                this.tabControl1.Visible = true;
                this.Size = new System.Drawing.Size(583, 284);
                this.MaximumSize = new System.Drawing.Size(583, 284);
                this.MinimumSize = new System.Drawing.Size(583, 284);
                string data = File.ReadAllText("filter.json");
                filter = JsonConvert.DeserializeObject<Dictionary<string, int[]>>(data);

                inf = box.ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                cou = 0;
                searched = new int[0];
                full = checkBox2.Checked;
                if (full)
                {
                    bool skip = false;
                    foreach (string o in inf)
                    {
                        if (filter.Keys.Any(str => str == o)) { }
                        else { skip = true; break; };
                    }
                    if (!skip)
                    {
                        foreach (string n in filter.Keys)
                        {

                            foreach (string o in inf)
                            {
                                if (n == o) { if (cou == 0) { searched = filter[n]; cou++; break; } else { searched = People.append(searched, filter[n], true); break; } };
                            }
                        }

                        int count = 0;
                        int[] listt = new int[0];
                        foreach (int i in searched)
                        {
                            int numb = 0;
                            foreach (int n in searched)
                            {
                                if (i == n) { numb++; }

                            }
                            if (count == 0) { if (numb == inf.Length) { count++; listt = new int[1] { i }; } }
                            else { if (numb == inf.Length) { listt = People.append(listt, i); } }
                        }
                        searched = listt;
                    }
                    else { searched = new int[0]; }

                }
                else
                {
                    foreach (string n in filter.Keys)
                    {

                        foreach (string o in inf)
                        {
                            if (n.Contains(o)) { if (cou == 0) { searched = filter[n]; cou++; break; } else { searched = People.append(searched, filter[n]); break; } };
                        }
                    }
                }
                hScrollBar1.Value = 0;
                if (searched.Length == 0) { label2.Text = "Данные не найдены."; hScrollBar1.Maximum = 0; }
                else { hScrollBar1.Maximum = (((searched.Length + 4) / 5) - 1); }
                label7.Text = $"1 из {hScrollBar1.Maximum + 1}";
                if (searched.Length >= 5 * hScrollBar1.Value + 1) { label2.Text = System.Convert.ToString(5 * hScrollBar1.Value + 1) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value])).Hum; }
                else { label2.Text = "Данные не найдены."; }
                if (searched.Length >= 5 * hScrollBar1.Value + 2) { label3.Text = System.Convert.ToString(5 * hScrollBar1.Value + 2) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value + 1])).Hum; }
                else { label3.Text = ""; }
                if (searched.Length >= 5 * hScrollBar1.Value + 3) { label4.Text = System.Convert.ToString(5 * hScrollBar1.Value + 3) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value + 2])).Hum; }
                else { label4.Text = ""; }
                if (searched.Length >= 5 * hScrollBar1.Value + 4) { label5.Text = System.Convert.ToString(5 * hScrollBar1.Value + 4) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value + 3])).Hum; }
                else { label5.Text = ""; }
                if (searched.Length >= 5 * hScrollBar1.Value + 5) { label6.Text = System.Convert.ToString(5 * hScrollBar1.Value + 5) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value + 4])).Hum; }
                else { label6.Text = ""; }
                numericUpDown1.Maximum = searched.Length;
                numericUpDown1.Value = 0;
                checkBox1.Enabled = false;
                button2.Enabled = false;
                checkBox1.Checked = false;
                pictureBox1.Visible = false;
            }
        }
        private void Form2_FormClosing(Object sender, FormClosingEventArgs e)
        {
            form1.button1.Enabled = true;
            form1.button2.Enabled = true;

        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label7.Text = $"{hScrollBar1.Value + 1} из {hScrollBar1.Maximum + 1}";
            if (searched.Length >= 5 * hScrollBar1.Value + 1) { label2.Text = System.Convert.ToString(5 * hScrollBar1.Value + 1) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value])).Hum; }
            if (searched.Length >= 5 * hScrollBar1.Value + 2) { label3.Text = System.Convert.ToString(5 * hScrollBar1.Value + 2) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value + 1])).Hum; }
            else
            {
                label3.Text = "";
            }
            if (searched.Length >= 5 * hScrollBar1.Value + 3) { label4.Text = System.Convert.ToString(5 * hScrollBar1.Value + 3) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value + 2])).Hum; }
            else
            {
                label4.Text = "";
            }
            if (searched.Length >= 5 * hScrollBar1.Value + 4) { label5.Text = System.Convert.ToString(5 * hScrollBar1.Value + 4) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value + 3])).Hum; }
            else
            {
                label5.Text = "";
            }
            if (searched.Length >= 5 * hScrollBar1.Value + 5) { label6.Text = System.Convert.ToString(5 * hScrollBar1.Value + 5) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value + 4])).Hum; }
            else
            {
                label6.Text = "";
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            pictureBox1.Visible = false;
            if (numericUpDown1.Value == 0) { label10.Text = ""; textBox2.Text = ""; checkBox1.Enabled = false; button2.Enabled = false; }
            else
            {
                checkBox1.Checked = false;
                label10.Text = (new Human(f2, searched[System.Convert.ToInt16(numericUpDown1.Value) - 1])).Hum;
                textBox2.Text = label10.Text;
                checkBox1.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { button2.Enabled = true; }
            else { button2.Enabled = false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            button2.Enabled = false;
            checkBox1.Checked = false;
            if (textBox2.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length == 0)
            {
                string[] lst = file1.Peo;
                for (int i = searched[System.Convert.ToInt64(numericUpDown1.Value) - 1]; i < lst.Length - 1; i++)
                {
                    lst[i] = lst[i + 1];
                }
                Array.Resize(ref lst, lst.Length - 1);
                file1.Peo = lst;
                File.WriteAllLines(path, file1.Peo);
                filter = Filter.search_list(file1.Peo);
                cou = 0;
                searched = new int[0];
                if (full)
                {
                    bool skip = false;
                    foreach (string o in inf)
                    {
                        if (filter.Keys.Any(str => str == o)) { }
                        else { skip = true; break; };
                    }
                    if (!skip)
                    {
                        foreach (string n in filter.Keys)
                        {

                            foreach (string o in inf)
                            {
                                if (n == o) { if (cou == 0) { searched = filter[n]; cou++; break; } else { searched = People.append(searched, filter[n], true); break; } };
                            }
                        }

                        int count = 0;
                        int[] listt = new int[0];
                        foreach (int i in searched)
                        {
                            int numb = 0;
                            foreach (int n in searched)
                            {
                                if (i == n) { numb++; }

                            }
                            if (count == 0) { if (numb == inf.Length) { count++; listt = new int[1] { i }; } }
                            else { if (numb == inf.Length) { listt = People.append(listt, i); } }
                        }
                        searched = listt;
                    }
                    else { searched = new int[0]; }

                }
                else
                {
                    foreach (string n in filter.Keys)
                    {

                        foreach (string o in inf)
                        {
                            if (n.Contains(o)) { if (cou == 0) { searched = filter[n]; cou++; break; } else { searched = People.append(searched, filter[n]); break; } };
                        }
                    }
                }
                if (searched.Length == 0) { label2.Text = "Данные не найдены."; hScrollBar1.Maximum = 0; }
                else { hScrollBar1.Maximum = (((searched.Length + 4) / 5) - 1); }
                label7.Text = $"1 из {hScrollBar1.Maximum + 1}";
                if (searched.Length >= 5 * hScrollBar1.Value + 1) { label2.Text = System.Convert.ToString(5 * hScrollBar1.Value + 1) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value])).Hum; }
                else { label2.Text = "Данные не найдены."; }
                if (searched.Length >= 5 * hScrollBar1.Value + 2) { label3.Text = System.Convert.ToString(5 * hScrollBar1.Value + 2) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value + 1])).Hum; }
                else { label3.Text = ""; }
                if (searched.Length >= 5 * hScrollBar1.Value + 3) { label4.Text = System.Convert.ToString(5 * hScrollBar1.Value + 3) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value + 2])).Hum; }
                else { label4.Text = ""; }
                if (searched.Length >= 5 * hScrollBar1.Value + 4) { label5.Text = System.Convert.ToString(5 * hScrollBar1.Value + 4) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value + 3])).Hum; }
                else { label5.Text = ""; }
                if (searched.Length >= 5 * hScrollBar1.Value + 5) { label6.Text = System.Convert.ToString(5 * hScrollBar1.Value + 5) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value + 4])).Hum; }
                else { label6.Text = ""; }
                numericUpDown1.Value = numericUpDown1.Value - 1;
                numericUpDown1.Maximum = searched.Length;
                pictureBox1.Visible = true;
            }
            else
            {
                file1.Peo[searched[System.Convert.ToInt64(numericUpDown1.Value) - 1]] = textBox2.Text;
                File.WriteAllLines(path, file1.Peo);
                Filter.search_list(file1.Peo);
                checkBox1.Checked = false;
                label10.Text = (new Human(f2, searched[System.Convert.ToInt16(numericUpDown1.Value) - 1])).Hum;
                textBox2.Text = label10.Text;
                checkBox1.Enabled = true;
                label7.Text = $"{hScrollBar1.Value + 1} из {hScrollBar1.Maximum + 1}";
                if (searched.Length >= 5 * hScrollBar1.Value + 1) { label2.Text = System.Convert.ToString(5 * hScrollBar1.Value + 1) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value])).Hum; }
                else { label2.Text = "Данные не найдены."; }
                if (searched.Length >= 5 * hScrollBar1.Value + 2) { label3.Text = System.Convert.ToString(5 * hScrollBar1.Value + 2) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value + 1])).Hum; }
                else
                {
                    label3.Text = "";
                }
                if (searched.Length >= 5 * hScrollBar1.Value + 3) { label4.Text = System.Convert.ToString(5 * hScrollBar1.Value + 3) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value + 2])).Hum; }
                else
                {
                    label4.Text = "";
                }
                if (searched.Length >= 5 * hScrollBar1.Value + 4) { label5.Text = System.Convert.ToString(5 * hScrollBar1.Value + 4) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value + 3])).Hum; }
                else
                {
                    label5.Text = "";
                }
                if (searched.Length >= 5 * hScrollBar1.Value + 5) { label6.Text = System.Convert.ToString(5 * hScrollBar1.Value + 5) + ". " + (new Human(f2, searched[5 * hScrollBar1.Value + 4])).Hum; }
                else
                {
                    label6.Text = "";
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(checkBox2, "Точный поиск покажет варианты которые идеально совпадают с каждым словом.");
        }
    }
}