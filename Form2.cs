using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace Dropz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != 132)
                return;
            m.Result = (IntPtr)2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var drops = new WebClient().DownloadString("raw paste url");
            richTextBox1.Text = drops;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("discord invite");
            Application.Exit();
        }
    }
}
