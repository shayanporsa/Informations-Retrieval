using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_Retrieval
{
    public partial class TextFile : Form
    {
        int c;
        public TextFile()
        {
            InitializeComponent();
        }
        public int x;

        private void TextFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fr = new Form1();


            if (c == 0)
            {
              //  MessageBox.Show("First Save File");

            }
        }

        private void TextFile_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt";
            //هیچ فایلی در ابتدا انتخاب نشود
            openFileDialog1.FileName = String.Empty;

            //پنجره‌ای برای انتخاب فایل باز شود
            DialogResult result = openFileDialog1.ShowDialog();

            //کلیک شد Open اگر دکمه
            if (result == DialogResult.OK)
            {
                //مسیر فایل انتخاب شده در یک متغیر ذخیره می‌شود 
                Stream fs = openFileDialog1.OpenFile();
                // فایل مسیر فایل خوانده می‌شود StreamReader با استفاده از 
                StreamReader reader = new StreamReader(fs);
                //محتویات فایل خوانده می‌شود
                string ss = openFileDialog1.FileName;

               textBox1.Text = reader.ReadToEnd();

                //Close the reader and the stream

                reader.Close();
            }
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form1 f1 = new Form1();
         //   x = f1.rname();
            
            TextFile tx = new TextFile();
            

            File.WriteAllText("C:\\ShayanSystem\\SoftWares\\IR\\Docs\\"+"Untitled"+x+".txt",textBox1.Text);
            MessageBox.Show("File Saved");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
