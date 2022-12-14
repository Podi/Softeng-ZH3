using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH3_forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void control1_btn_Click(object sender, EventArgs e)
        {
            UserControl1 control = new UserControl1();
            panel1.Controls.Add(control);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl2 control = new UserControl2();
            panel1.Controls.Add(control);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl3 control = new UserControl3();
            panel1.Controls.Add(control);
        }
    }
}
