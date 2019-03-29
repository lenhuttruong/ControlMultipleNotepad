using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlMultipleNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Process[] processes;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshAccount_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processes = Process.GetProcessesByName("Notepad");
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
