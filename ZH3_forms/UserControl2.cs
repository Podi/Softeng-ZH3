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
    public partial class UserControl2 : UserControl
    {
        Models.TankonyvContext context = new Models.TankonyvContext();
        public UserControl2()
        {
            InitializeComponent();
        }
    }
}
