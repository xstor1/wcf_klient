using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcFklient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
           ServiceReference1.Task k = new ServiceReference1.Task();
            ServiceReference1.Task t = new ServiceReference1.Task();
            t.value = textBox1.Text;
             k=client.gettask(t);
            label1.Text = k.value;
         
        }
    }
}
