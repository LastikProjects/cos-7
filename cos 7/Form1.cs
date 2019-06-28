using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cos_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = 4;
            double[] S0 = new double[N];
            for (int i = 0; i < N; i++)
            {
                S0[i] = i;
                textBox2.Text += S0[i] + " ";
            }

            double print = 0;
            double[] example = new double[N];
            for (int i = 0; i < N; i++)
            {
                example[i] = Math.Pow(S0[i], 2);
                print += example[i];
                
            }
            textBox1.Text = print.ToString();

            int stepen = 2;
            for (int i = stepen - 1; i >= 0; i--)
            {
                int razbienie = Convert.ToInt32(Math.Pow(2, i));
                double[] Si = new double[razbienie];
                double[] Di = new double[razbienie];
                for (int j = 0; j < razbienie; j++)
                {
                    Si[j] = (S0[2 * j] + S0[2 * j + 1]) / Math.Sqrt(2);
                    Di[j] = (S0[2 * j] - S0[2 * j + 1]) / Math.Sqrt(2);
                }
                for (int j = 0; j < razbienie; j++)
                {
                    S0[j] = Si[j];
                    S0[j + razbienie] = Di[j];
                }
            }
            print = 0;
            for (int i = 0; i < N; i++)
            {
                example[i] = Math.Pow(S0[i], 2);
                print += example[i];
            }
            textBox3.Text = print.ToString();
            for (int i = 0; i < N; i++)
            {
                textBox5.Text += Convert.ToString(S0[i]) + " ";
            }
            for(int i=0;i<stepen;i++)
            {
                int razbienie = Convert.ToInt32(Math.Pow(2, i));
                double[] Si = new double[razbienie * 2];
                for (int j = 0; j < razbienie * 2; j += 2)
                {
                    Si[j] = (S0[j / 2] + S0[Convert.ToInt32(j / 2 + razbienie)]) * Math.Sqrt(2) / 2;
                    Si[j + 1] = (S0[j / 2] - S0[Convert.ToInt32(j / 2 + razbienie)]) * Math.Sqrt(2) / 2;
                }
                for (int j = 0; j < razbienie * 2; j++)
                {
                    S0[j] = Si[j];
                }
            }
            print = 0;
            for (int i = 0; i < N; i++)
            {
                example[i] = Math.Pow(S0[i], 2);
                print += example[i];
            }
            textBox4.Text = print.ToString();
            for (int i = 0; i < N; i++)
            {
                textBox6.Text += Convert.ToString(S0[i]) + " ";
            }


        }
    }
}
