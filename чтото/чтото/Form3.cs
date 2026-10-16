using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace чтото
{
    public partial class Form3 : Form
    {
        Random random = new Random();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = random.Next(256);
            int g = random.Next(256);
            int b = random.Next(256);

            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
