using ServiceMtk_P1_20180140018;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientCFC_P4_018_Form
{
    public partial class Form1 : Form
    {
        BasicHttpBinding bind = new BasicHttpBinding();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChannelFactory<IMatematika> objChannel = new ChannelFactory<IMatematika>(bind, "http://localhost:1907");
            IMatematika obj = objChannel.CreateChannel();

            int a, b, c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a + b;
            textBox9.Text = c.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChannelFactory<IMatematika> objChannel = new ChannelFactory<IMatematika>(bind, "http://localhost:1907");
            IMatematika obj = objChannel.CreateChannel();

            int a, b, c;
            a = Convert.ToInt32(textBox3.Text);
            b = Convert.ToInt32(textBox4.Text);
            c = a - b;
            textBox10.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChannelFactory<IMatematika> objChannel = new ChannelFactory<IMatematika>(bind, "http://localhost:1907");
            IMatematika obj = objChannel.CreateChannel();

            int a, b, c;
            a = Convert.ToInt32(textBox6.Text);
            b = Convert.ToInt32(textBox7.Text);
            c = a * b;
            textBox11.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChannelFactory<IMatematika> objChannel = new ChannelFactory<IMatematika>(bind, "http://localhost:1907");
            IMatematika obj = objChannel.CreateChannel();

            int a, b, c;
            a = Convert.ToInt32(textBox5.Text);
            b = Convert.ToInt32(textBox8.Text);
            c = a / b;
            textBox12.Text = c.ToString();
        }
    }
}
