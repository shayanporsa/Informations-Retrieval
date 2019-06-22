using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_Retrieval
{
    public partial class result : Form
    {
        public result()
        {
            InitializeComponent();
        }

        private void result_Load(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            if (frm.lang == 0)
            {
                textBox1.RightToLeft = RightToLeft.No;
            }
            else if(frm.lang == 1)
            {
                textBox1.RightToLeft = RightToLeft.Yes;
            }
        }
    }
}
