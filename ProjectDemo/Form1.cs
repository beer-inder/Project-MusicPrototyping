using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
            
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            int color = colorDialog1.Color.ToArgb();
            richTextBox1.BackColor = Color.FromArgb(color);
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            int color = colorDialog1.Color.ToArgb();
            richTextBox1.ForeColor = Color.FromArgb(color);
        }

        private void CuttoolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void LeftAligntoolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void RightAligntoolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void CentreAligntoolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                FonttoolStripComboBox1.Items.Add(font.Name.ToString());
            }
        }

        private void BoldtoolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(FonttoolStripComboBox1.SelectedItem.ToString(), 16, FontStyle.Bold);
            
           
        }

        private void CuttoolStripButton1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void PastetoolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void CopytoolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();   
        }
    }
}
