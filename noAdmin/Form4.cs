using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noAdmin
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Thread.Sleep(1);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(2);
            Form Form2 = new Form2();
            this.Hide();
            Form2.Show();
        }
    }
}
