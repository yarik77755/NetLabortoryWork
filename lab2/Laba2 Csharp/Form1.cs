using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2_Csharp
{
    public partial class Form1 : Form
    {
        MainClass line = new MainClass();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            line.ShowInfo1(textBox1,textBox2,textBox3,textBox4,textBox5,textBox6,textBox7,textBox8,textBox9);
        }
    }
}
