using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void N(int n, int a)
        {
            if (a <= n)
            {
                for (int i = 1; i <= a; i++)
                {
                    rez.Text += a + " ";                
                }
                rez.Text += Environment.NewLine;
                N(n, a + 1);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int n = Convert.ToInt32(Num.Text);
                if (n > 0)
                { N(n, 1); }
                else rez.Text = Convert.ToString("Число должно быть больше 0!");
            }
            catch { rez.Text = Convert.ToString("Некорректный ввод!"); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rez.Clear();
            Num.Clear();
        }
    }
}
