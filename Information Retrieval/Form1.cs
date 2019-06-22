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
    public partial class Form1 : Form
    {
        
        public int lang = 0;
        result r = new result();
        TextBox t = new TextBox();
        int a = 1;
        TextBox t1 = new TextBox();
        string us;
        public int c;
        
        

        public Form1()
        {
            InitializeComponent();
        }

        void Ctext()
        {

            t1.Name = Convert.ToString(a);
            t1.Text = t.Text;
            a++;
            us = textBox1.Text;
            r.textBox1.Text = this.textBox1.Text;

        }
        void wildcard()
        {
            result r = new result();
            TextBox t = new TextBox();

            for (int i = 1; i <= c; i++)
            {
                t.Text = File.ReadAllText("C:\\ShayanSystem\\SoftWares\\IR\\Docs\\" + "Untitled" + Convert.ToString(i) + ".txt");
                string[] worddoc = t.Text.Split(' ');
                string wordw="";
                if (textBox1.Text.IndexOf('*') == 0)
                {
                    string queryw = textBox1.Text.Replace('*', ' ').Trim();
                    for (int j = 0; j < worddoc.Length; j++)
                    {
                        if (worddoc[j].Contains(queryw))
                        {
                            wordw = wordw + worddoc[j] + "(" + Convert.ToString(i) + ")";
                            MessageBox.Show(wordw);

                        }
                    }
                }
                else if (textBox1.Text.IndexOf('*') == textBox1.TextLength - 1)
                {
                    string queryw = textBox1.Text.Replace('*', ' ').Trim();
                    for (int j = 0; j < worddoc.Length; j++)
                    {
                        if (worddoc[j].Contains(queryw))
                        {
                            wordw = wordw + worddoc[j] + "(" + Convert.ToString(i) + ")";
                            MessageBox.Show(wordw);

                        }
                    }
                }
                else
                {
                    string[] queryw = textBox1.Text.Split('*');
                    for(int j = 0; j < worddoc.Length; j++)
                    {
                        if (worddoc[j].Contains(queryw[0]))
                        {
                            int index1 = worddoc[j].IndexOf(queryw[0]);
                            if (worddoc[j].Contains(queryw[1]))
                            {
                                int index2 = worddoc[j].IndexOf(queryw[1]);
                                if (index2 > index1)
                                {
                                    MessageBox.Show(Convert.ToString(i));
                                }
                            }
                        }
                    }
                }
            }
            }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Contains('*'))
            {
                wildcard();
            }
            else
            {
                find();
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                c = Convert.ToInt32(File.ReadAllText("C:\\ShayanSystem\\SoftWares\\IR\\Start\\Start.txt"));
                
            }
            catch
            {
                c = 0;
            }
            Directory.CreateDirectory("C:\\ShayanSystem\\SoftWares\\IR\\Start");
            File.WriteAllText("C:\\ShayanSystem\\SoftWares\\IR\\Start\\Start.txt", "0");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (lang == 0)
            {
                btns.Text = "جستجو";
                btnlang.Text = "تغییر زبان";
                lblslang.Text = "زبان فعلی جستجو";
                lbllang.Text = "فارسی";
                lang = 1;
                btnfiles.Text = "افزودن";
                textBox1.RightToLeft = RightToLeft.Yes;


            }
            else if (lang == 1)
            {
                btns.Text = "Search";
                btnlang.Text = "Change Language";
                lblslang.Text = "Search Language";
                lbllang.Text = "English";
                lang = 0;
                btnfiles.Text = "Files";
                textBox1.RightToLeft = RightToLeft.No;




            }
        }
        public void find()
        {
            result r = new result();
            TextBox t = new TextBox();
            //string sp = (Convert.ToString(t)).Split('""');

            for (int i = 1; i <= c; i++)
            {
                t.Text = File.ReadAllText("C:\\ShayanSystem\\SoftWares\\IR\\Docs\\" + "Untitled" + Convert.ToString(i) + ".txt");

                if ((textBox1.Text.Substring(0, 1) == "\"") && ((Convert.ToString(textBox1.Text)).Substring(Convert.ToInt32((Convert.ToString(textBox1.Text)).Length - 1), 1)) == "\"")
                {
                    string srch = ((Convert.ToString(textBox1.Text)).Substring(1, (Convert.ToString(textBox1.Text)).Length - 2));
                    //MessageBox.Show(srch);
                    if (t.Text.Contains(srch))
                    {
                        if (r.lblr.Text == ".")
                        {
                            r.lblr.Text = Convert.ToString(i);
                        }
                        else if (r.lblr2.Text == ".")
                        {
                            r.lblr2.Text = Convert.ToString(i);
                        }
                        else if (r.lblr3.Text == ".")
                        {
                            r.lblr3.Text = Convert.ToString(i);
                        }
                        else if (r.lblr4.Text == ".")
                        {
                            r.lblr4.Text = Convert.ToString(i);
                        }
                        else if (r.lblr5.Text == ".")
                        {
                            r.lblr5.Text = Convert.ToString(i);
                        }
                        else if (r.lblr6.Text == ".")
                        {
                            r.lblr6.Text = Convert.ToString(i);
                        }
                        else if (r.lblr7.Text == ".")
                        {
                            r.lblr7.Text = Convert.ToString(i);
                        }
                    }

                }
                else
                {
                    if (t.Text.Contains(textBox1.Text) || (Convert.ToString(t.Text).ToUpper()).Contains(textBox1.Text) || (Convert.ToString(t.Text).ToLower()).Contains(textBox1.Text))
                    {
                        if (r.lblr.Text == ".")
                        {
                            r.lblr.Text = Convert.ToString(i);
                        }
                        else if (r.lblr2.Text == ".")
                        {
                            r.lblr2.Text = Convert.ToString(i);
                        }
                        else if (r.lblr3.Text == ".")
                        {
                            r.lblr3.Text = Convert.ToString(i);
                        }
                        else if (r.lblr4.Text == ".")
                        {
                            r.lblr4.Text = Convert.ToString(i);
                        }
                        else if (r.lblr5.Text == ".")
                        {
                            r.lblr5.Text = Convert.ToString(i);
                        }
                        else if (r.lblr6.Text == ".")
                        {
                            r.lblr6.Text = Convert.ToString(i);
                        }
                        else if (r.lblr7.Text == ".")
                        {
                            r.lblr7.Text = Convert.ToString(i);
                        }
                    }
                }
                if (textBox1.Text.Contains("(AND)"))
                {
 

                }

            }
            r.textBox1.Text = this.textBox1.Text;
            r.ShowDialog();
        }
        private void btnfiles_Click(object sender, EventArgs e)
        {

            Directory.CreateDirectory("C:\\ShayanSystem\\SoftWares\\IR\\Docs");
            FileStream fileStream = new FileStream("C:\\ShayanSystem\\SoftWares\\IR\\Docs\\" + "Untitled" + Convert.ToString(c + 1) + ".txt", FileMode.Create);
            try
            {
                // read from file or write to file
            }
            finally
            {
                fileStream.Close();
            }
            TextFile tf = new TextFile();
            tf.Text = "Untitled" + Convert.ToString(c + 1);
            tf.x = c + 1;
           
            tf.ShowDialog();
            c++;
            




        }

        private void tab1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText("C:\\ShayanSystem\\SoftWares\\IR\\Start\\Start.txt", Convert.ToString(c));
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            find();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            Stg s = new Stg();
            s.x = c;
            s.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('*'))
            {
                label1.Text = "WildCard";
            }
            else { 
            if (textBox1.Text.Contains('a') || textBox1.Text.Contains('c') || textBox1.Text.Contains('d') || textBox1.Text.Contains('e') || textBox1.Text.Contains('f') || textBox1.Text.Contains('g') || textBox1.Text.Contains('h') || textBox1.Text.Contains('i') || textBox1.Text.Contains('j') || textBox1.Text.Contains('k') || textBox1.Text.Contains('l') || textBox1.Text.Contains('m') || textBox1.Text.Contains('n') || textBox1.Text.Contains('o') || textBox1.Text.Contains('p') || textBox1.Text.Contains('q') || textBox1.Text.Contains('r') || textBox1.Text.Contains('s') || textBox1.Text.Contains('t') || textBox1.Text.Contains('u') || textBox1.Text.Contains('v') || textBox1.Text.Contains('w') || textBox1.Text.Contains('x') || textBox1.Text.Contains('y') || textBox1.Text.Contains('z') || textBox1.Text.Contains('A') || textBox1.Text.Contains('B') || textBox1.Text.Contains('C') || textBox1.Text.Contains('D') || textBox1.Text.Contains('E') || textBox1.Text.Contains('F') || textBox1.Text.Contains('G') || textBox1.Text.Contains('H') || textBox1.Text.Contains('I') || textBox1.Text.Contains('J') || textBox1.Text.Contains('K') || textBox1.Text.Contains('L') || textBox1.Text.Contains('M') || textBox1.Text.Contains('N') || textBox1.Text.Contains('O') || textBox1.Text.Contains('P') || textBox1.Text.Contains('Q') || textBox1.Text.Contains('R') || textBox1.Text.Contains('S') || textBox1.Text.Contains('T') || textBox1.Text.Contains('U') || textBox1.Text.Contains('V') || textBox1.Text.Contains('W') || textBox1.Text.Contains('X') || textBox1.Text.Contains('Y') || textBox1.Text.Contains('Z')) {
                label1.Text = "EN";

            }
            else if (textBox1.Text.Contains('0') || textBox1.Text.Contains('1') || textBox1.Text.Contains('2') || textBox1.Text.Contains('3') || textBox1.Text.Contains('4') || textBox1.Text.Contains('5') || textBox1.Text.Contains('6') || textBox1.Text.Contains('7') || textBox1.Text.Contains('8') || textBox1.Text.Contains('9')) {
                label1.Text = "NUM";
            }
            else if (textBox1.Text.Contains('ا') || textBox1.Text.Contains('ب') || textBox1.Text.Contains('پ') || textBox1.Text.Contains('ت') || textBox1.Text.Contains('ث') || textBox1.Text.Contains('ج') || textBox1.Text.Contains('چ') || textBox1.Text.Contains('ح') || textBox1.Text.Contains('خ') || textBox1.Text.Contains('د') || textBox1.Text.Contains('ذ') || textBox1.Text.Contains('ر') || textBox1.Text.Contains('ز') || textBox1.Text.Contains('س') || textBox1.Text.Contains('ش') || textBox1.Text.Contains('ص') || textBox1.Text.Contains('ض') || textBox1.Text.Contains('ط') || textBox1.Text.Contains('ظ') || textBox1.Text.Contains('ع') || textBox1.Text.Contains('غ') || textBox1.Text.Contains('ف') || textBox1.Text.Contains('ق') || textBox1.Text.Contains('ک') || textBox1.Text.Contains('گ') || textBox1.Text.Contains('ل') || textBox1.Text.Contains('م') || textBox1.Text.Contains('ن') || textBox1.Text.Contains('و') || textBox1.Text.Contains('ه') || textBox1.Text.Contains('ی') || textBox1.Text.Contains('ی')) {
                label1.Text = "FA";
            }
            }
        }
     
    }
}
