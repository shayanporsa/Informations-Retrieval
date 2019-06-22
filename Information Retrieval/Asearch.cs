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
    public partial class Asearch : Form
    {
        string andresult;
        string orresult;
        string notresult;
        int and;
        int or;
        int not;
        string docnot = null;

        public int x;
        int c = Convert.ToInt32(File.ReadAllText("C:\\ShayanSystem\\SoftWares\\IR\\Start\\Start.txt"));
        public Asearch()
        {
            InitializeComponent();
        }
        private void Asearch_Load(object sender, EventArgs e)
        {
            
        }
        public void OR(string query)
        {
            result r = new result();
            TextBox t = new TextBox();
            int NWords = 0; //nubmer of words
            //string query = textBox3.Text;
            string[] words = query.Split(',');
            query = "";
            for (int j = 0; j < words.Length; j++)
            {
                NWords++;         
            }
            for (int i = 1; i <= x; i++)
            {
                or = 0;
                t.Text = File.ReadAllText("C:\\ShayanSystem\\SoftWares\\IR\\Docs\\" + "Untitled" + Convert.ToString(i) + ".txt");
                for (int j = 0; j < words.Length; j++)
                {
                    if (t.Text.Contains(words[j]) || (Convert.ToString(t.Text).ToUpper()).Contains(words[j]) || Convert.ToString(t.Text).ToLower().Contains(words[j]))
                    {
                        or++;

                    }
                }
                if (or>=1)
                {
                    orresult = orresult + "1";
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
                else
                {
                    orresult = orresult + "0";
                }

        }
           // MessageBox.Show(orresult);
        

        }

        public void AND(string query) {
            
            result r = new result();
            TextBox t = new TextBox();
            int NWords = 0; //nubmer of words
            //string query = textBox1.Text;
            string[] words = query.Split(',');
            query = "";
            for (int j = 0; j < words.Length; j++)
            {
                NWords++;
            }
            for (int i = 1; i <= x; i++)
            {
                and = 0;
                t.Text = File.ReadAllText("C:\\ShayanSystem\\SoftWares\\IR\\Docs\\" + "Untitled" + Convert.ToString(i) + ".txt");
                for (int j = 0; j < words.Length; j++)
                {
                    if (t.Text.Contains(words[j]) || (Convert.ToString(t.Text).ToUpper()).Contains(words[j]) || Convert.ToString(t.Text).ToLower().Contains(words[j]))
                    {
                        and++;

                    }
                    //MessageBox.Show(Convert.ToString(and));
                }
                    if (and == NWords)
                    {
                    andresult = andresult + "1";
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
                else
                {
                    andresult = andresult + "0";
                }
                }
           // MessageBox.Show(andresult);
         //   MessageBox.Show(Convert.ToString(NWords));
          //  r.ShowDialog();

        }

        public void NOT(string query)
        {

            result r = new result();
            TextBox t = new TextBox();
            int NWords = 0; //nubmer of words
            //query = textBox2.Text;
            string[] words = query.Split(',');
            query = "";
            for (int j = 0; j < words.Length; j++)
            {
                NWords++;
            }
            for (int i = 1; i <= x; i++)
            {
                not = 0;
                t.Text = File.ReadAllText("C:\\ShayanSystem\\SoftWares\\IR\\Docs\\" + "Untitled" + Convert.ToString(i) + ".txt");
                for (int j = 0; j < words.Length; j++)
                {
                    if (t.Text.Contains(words[j]) || (Convert.ToString(t.Text).ToUpper()).Contains(words[j]) || (Convert.ToString(t.Text).ToLower().Contains(words[j])))
                    {

                        docnot = docnot + Convert.ToString(i);
                    }
                    else
                    {
                        docnot = docnot + 0;
                    }
                    //MessageBox.Show(Convert.ToString(and));
                }
                if (not == NWords)
                {
                    notresult = andresult + "1";
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
                else
                {
                    notresult = andresult + "0";
                }
            }

          //  MessageBox.Show(notresult);

            //r.ShowDialog();
        }

        private void btns_Click(object sender, EventArgs e)
        {
                if(textBox2.Text=="" && textBox1.Text=="")
                {
                 
                        OR(textBox3.Text);
                        MessageBox.Show(orresult);

                }
                else if (textBox2.Text == "" && textBox3.Text=="")
                    {
                        AND(textBox1.Text);
                        MessageBox.Show(andresult);

                    }
                else if(textBox2.Text=="" && textBox1.Text!=null && textBox3.Text!="")
                    {
                        AND(textBox1.Text);
                        OR(textBox3.Text);
                        //NOT(textBox2.Text);
                        string result = null;
                        int[] andr = new int[x];
                        int[] orr = new int[x];

                        for (int i = 0; i < x; i++)
                        {
                            andr[i] = Convert.ToInt32(andresult.Substring(0, 1));
                            andresult = andresult.Substring(1, andresult.Length - 1);
                            orr[i] = Convert.ToInt32(orresult.Substring(0, 1));
                            orresult = orresult.Substring(1, orresult.Length - 1);
                        }
                        for (int j = 0; j < x; j++)
                        {
                            if (andr[j] == 1 && orr[j] == 1)
                            {
                                result = result + "1";
                            }
                            else
                            {
                                result = result + "0";
                            }
                        }
                        MessageBox.Show(result);
                    }
                
               
                else if(textBox1.Text!="" && textBox2.Text!="" &&textBox3.Text!=""){
                    AND(textBox1.Text);
                    OR(textBox3.Text);
                    NOT(textBox2.Text);
                    string result = null;
                    int[] andr = new int[x];
                    int[] orr = new int[x];

                    for (int i = 0; i < x; i++)
                    {
                        andr[i] = Convert.ToInt32(andresult.Substring(0, 1));
                        andresult = andresult.Substring(1, andresult.Length - 1);
                        orr[i] = Convert.ToInt32(orresult.Substring(0, 1));
                        orresult = orresult.Substring(1, orresult.Length - 1);
                    }
                    for (int j = 0; j < x; j++)
                    {
                        if (andr[j] == 1 && orr[j] == 1 && !docnot.Contains(Convert.ToString(j + 1)))
                        {
                            result = result + "1";
                        }
                        else
                        {
                            result = result + "0";
                        }
                    }
                    MessageBox.Show(result);
                }
                else if (textBox3.Text == "" && textBox1.Text != "" && textBox2.Text != "")
                {
                    AND(textBox1.Text);
                   // OR(textBox3.Text);
                    NOT(textBox2.Text);
                    string result = null;
                    int[] andr = new int[x];
                    int[] orr = new int[x];

                    for (int i = 0; i < x; i++)
                    {
                        andr[i] = Convert.ToInt32(andresult.Substring(0, 1));
                        andresult = andresult.Substring(1, andresult.Length - 1);
                        //orr[i] = Convert.ToInt32(orresult.Substring(0, 1));
                        //orresult = orresult.Substring(1, orresult.Length - 1);
                    }
                    for (int j = 0; j < x; j++)
                    {
                        if (andr[j] == 1 &&  !docnot.Contains(Convert.ToString(j + 1)))
                        {
                            result = result + "1";
                        }
                        else
                        {
                            result = result + "0";
                        }
                    }
                    MessageBox.Show(result);
                }
                else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text != "")
                {
                  //  AND(textBox1.Text);
                    OR(textBox3.Text);
                    NOT(textBox2.Text);
                    string result = null;
                    int[] andr = new int[x];
                    int[] orr = new int[x];

                    for (int i = 0; i < x; i++)
                    {
                       // andr[i] = Convert.ToInt32(andresult.Substring(0, 1));
                        //andresult = andresult.Substring(1, andresult.Length - 1);
                        orr[i] = Convert.ToInt32(orresult.Substring(0, 1));
                        orresult = orresult.Substring(1, orresult.Length - 1);
                    }
                    for (int j = 0; j < x; j++)
                    {
                        if (orr[j] == 1 && !docnot.Contains(Convert.ToString(j + 1)))
                        {
                            result = result + "1";
                        }
                        else
                        {
                            result = result + "0";
                        }
                    }
                    MessageBox.Show(result);
                }

            

            /*
  
                string prosearch;
                string prosearchtemp;
                string[] prosearchand;
                string [] prosearchor;
                string [] prosearchnot;
                prosearch = textBox5.Text;
                
                while (prosearch.Contains('('))
                {
                    int f1 = prosearch.IndexOf('(');
                    int f2 = prosearch.IndexOf(')');
                    prosearchtemp = prosearch.Substring(f1, f2+1);
                    prosearch = prosearch.Replace(prosearchtemp,".").Trim();
                    if (prosearchtemp.Contains('*'))
                    {                    
                        prosearchand= prosearchtemp.Split('*');
                        try
                        {
                            MessageBox.Show(prosearchand[0]);
                            MessageBox.Show(prosearchand[1]);
                            MessageBox.Show(prosearchand[2]);
                            MessageBox.Show(prosearchand[3]);
                        }
                        catch
                        {
                            MessageBox.Show("");
                        }

                    }
                    else if (prosearchtemp.Contains('+'))
                    {
                        prosearchor = prosearchtemp.Split('+');
                        try
                        {
                            MessageBox.Show(prosearchor[0]);
                            MessageBox.Show(prosearchor[1]);
                        }
                        catch
                        {
                            MessageBox.Show("");
                        }
                    }
                    else if (prosearchtemp.Contains('-'))
                    {
                        prosearchnot = prosearchtemp.Split('-');
                        try
                        {
                            MessageBox.Show(prosearchnot[0]);
                            MessageBox.Show(prosearchnot[1]);
                        }
                        catch
                        {
                            MessageBox.Show("");
                        }
                    }

                }
            
            string prosearch;
            string [] prosearchtemp;
            string[] prosearchand;
            string[] prosearchor;
            string[] prosearchnot;
            prosearch = textBox5.Text;
            try
            {
                prosearch.Replace(")*(", "&");
                prosearchtemp = prosearch.Split('&');
                
            }
            catch
            {

            }*/
           /*string query = textBox5.Text;
            query = query.Replace(")*(", "^").Replace(")*(", "^").Replace(")!*(", "^");
            string[] argms = query.Split('^');
            int argmscount = argms.Length+1;
            MessageBox.Show(Convert.ToString(argmscount));*/

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = textBox1.Text.Replace(","," (AND) ");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text =textBox1.Text.Replace(",", " (OR) ");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                btns.Enabled = true;
                textBox5.Enabled = false;
            }
            else if (radioButton2.Checked)
            {
                textBox5.Enabled = true;
                btns.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                btns.Enabled = true;
                textBox5.Enabled = false;
            }
            else if (radioButton2.Checked)
            {
                textBox5.Enabled = true;
                btns.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
