using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello_world
{
    public partial class Frmhelloworld : Form
    {
        public Frmhelloworld()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            lblhelloworld.Text = "hello world !";
        }

        private void Frmhelloworld_Load(object sender, EventArgs e)
        {

        }
    }
}
