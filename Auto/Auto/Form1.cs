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

        Auto auto = new Auto();
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != string.Empty)
            {
                int cislo = int.Parse(textBox1.Text);
                switch(cislo)
                {
                    case 1:
                        {
                            MessageBox.Show("jedu!");
                            auto.Rozjed();
                            break;
                        }
                    case 2:
                        {
                            MessageBox.Show(auto.Zastav());
                            break;
                        }
                    case 3:
                        {
                            MessageBox.Show(auto.VratUjeteKm());
                            break;
                        }
                    case 4:
                        {
                            MessageBox.Show(auto.CelkovaSpotreba());
                            break;
                        }
                    case 5:
                        {
                            MessageBox.Show(auto.info());
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
