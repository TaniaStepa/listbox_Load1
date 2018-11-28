using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox_Load1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            public string[] listData = { "K-01", "K-91", "K-81", "K-71", "MK-01", "MK-91" };
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = listData;
        }
    }
}
