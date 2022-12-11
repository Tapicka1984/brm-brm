using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != string.Empty)
            {
                int cislo = int.Parse(textBox1.Text);
                Auto auto = new Auto();
                switch(cislo)
                {
                    case 1:
                        {
                            MessageBox.Show(auto.Rozjed());
                            break;
                        }
                    case 2:
                        {
                            MessageBox.Show(auto.Zastav());
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("spatne cislo");
                            break;
                        }
                }
            }
        }
    }
}
