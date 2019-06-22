using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Information_Retrieval
{
    public partial class Stg : Form
    {
        public int x;
        int c;
        public Stg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Asearch As = new Asearch();
            As.x = x;
            this.Hide();
            As.ShowDialog();

        }

        private void Stg_Load(object sender, EventArgs e)
        {
            try
            {
                c = Convert.ToInt32(File.ReadAllText("C:\\ShayanSystem\\SoftWares\\IR\\Start\\Start.txt"));
            }
            catch
            {
                c = 0;
            }
        }
    }
}
