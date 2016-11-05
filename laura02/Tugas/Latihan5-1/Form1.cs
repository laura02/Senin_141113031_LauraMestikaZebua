using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveFile(RichTextBox rb)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.DefaultExt = "*.rtf";
            sf.Filter = "RTF Files|*.rtf";
            if (richTextBox1.Text == null) return;
            if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK & sf.FileName.Length > 0)
                rb.SaveFile(sf.FileName);
        }
        private void openFile(RichTextBox rb)
        {
            OpenFileDialog sf = new OpenFileDialog();
            sf.DefaultExt = "*.rtf";
            sf.Filter = "RTF Files|*.rtf";
            if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK & sf.FileName.Length > 0)
                rb.LoadFile(sf.FileName);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(richTextBox1);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save this file ?", "Alert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (richTextBox1.Text != null)
            {
                if (dr == DialogResult.Yes) saveFile(richTextBox1);
                else if (dr == DialogResult.No)
                {
                    richTextBox1.Focus();
                }
                else if (dr == DialogResult.Cancel) return;
                richTextBox1.Text = "";
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save this file?", "Alert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (richTextBox1.Text != null)
            {
                if (dr == DialogResult.Yes)
                {
                    saveFile(richTextBox1);
                    openFile(richTextBox1);
                }
                else if (dr == DialogResult.No)
                {
                    richTextBox1.Text = "";
                    openFile(richTextBox1);
                }
                else if (dr == DialogResult.Cancel) return;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = richTextBox1.SelectionFont;
            if (fd.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fd.Font;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font baru, lama;
            lama = richTextBox1.SelectionFont;
            if (lama.Bold)
                baru = new Font(lama, lama.Style & ~FontStyle.Bold);
            else
                baru = new Font(lama, lama.Style | FontStyle.Bold);
            richTextBox1.SelectionFont = baru;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Font baru, lama;
            lama = richTextBox1.SelectionFont;
            if (lama.Italic)
                baru = new Font(lama, lama.Style & ~FontStyle.Italic);
            else
                baru = new Font(lama, lama.Style | FontStyle.Italic);
            richTextBox1.SelectionFont = baru;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Font baru, lama;
            lama = richTextBox1.SelectionFont;
            if (lama.Underline)
                baru = new Font(lama, lama.Style & ~FontStyle.Underline);
            else
                baru = new Font(lama, lama.Style | FontStyle.Underline);
            richTextBox1.SelectionFont = baru;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Font = new Font(comboBox1.Text, richTextBox1.Font.Size);
            }
            catch { }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, float.Parse(comboBox2.SelectedItem.ToString()));
            }
            catch { }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog warna = new ColorDialog();
            warna.ShowDialog();
            richTextBox1.SelectionColor = warna.Color;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult warnaLatar = colorDialog1.ShowDialog();

            if (warnaLatar == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox2.Items.Add("8");
            comboBox2.Items.Add("9");
            comboBox2.Items.Add("10");
            comboBox2.Items.Add("11");
            comboBox2.Items.Add("12");
            comboBox2.Items.Add("14");
            comboBox2.Items.Add("16");
            comboBox2.Items.Add("18");
            comboBox2.Items.Add("20");
            comboBox2.Items.Add("22");
            comboBox2.Items.Add("24");
            comboBox2.Items.Add("26");
            comboBox2.Items.Add("28");
            comboBox2.Items.Add("36");
            comboBox2.Items.Add("48");
            comboBox2.Items.Add("72");
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBox1.Items.Add(font.Name.ToString());
            }

            treeView1.Nodes.Add("Color");
            treeView1.Nodes[0].Nodes.Add("Background color");

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DialogResult warnaLatar = colorDialog1.ShowDialog();

            if (warnaLatar == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }

        }
    }
    }
