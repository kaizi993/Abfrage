using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotenDLL;

namespace AbfrageGUI
{
    public partial class Form1 : Form
    {
        Class1 NotenDLL;

        public Form1()
        {
            InitializeComponent();
            NotenDLL = new Class1();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
