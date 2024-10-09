using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manigu
{
    public partial class setari : UserControl
    {
        public setari()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)//culoare == 2 pt light
        {
            Theme1.changeTheme((Form1)this.ParentForm);
            Form1.culoare = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Theme1.changeColor2((Form1)this.ParentForm);
            Form1.culoare = 0;
        }

        private void button2_Click(object sender, EventArgs e)//culoare == 1 pt light
        {
            Theme1.changeColor3((Form1)this.ParentForm);
            Form1.culoare = 2;
        }
    }
}
