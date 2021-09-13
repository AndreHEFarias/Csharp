using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExBrad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int v1 = int.Parse(Console.ReadLine());
            int v2 = int.Parse(Console.ReadLine());
            int r = v1 + v2;
            Console.WriteLine(r);
        }
    }
}
